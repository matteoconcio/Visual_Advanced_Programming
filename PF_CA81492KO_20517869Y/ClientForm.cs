using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PF_CA81492KO_20517869Y.Login;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Identity.Client;

namespace PF_CA81492KO_20517869Y
{
    public partial class ClientForm : Form
    {
        decimal totalCarrito = 0; // Variable para almacenar el total del carrito

        public ClientForm()
        {
            InitializeComponent();

            // Evento para cuando se seleccione un tipo en el ComboBox
            cbTipo.SelectedIndexChanged += CbTipo_SelectedIndexChanged;

            // Inicializar el TextBox con "0.00€"
            labeltotal.Text = "0.00€";

            // Seleccionar el primer ítem del ComboBox y cargar los datos en lvTienda
            if (cbTipo.Items.Count > 0)
            {
                cbTipo.SelectedIndex = 0;
                CargarDatosTienda();
            }
        }

        private void CbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar los datos de la tienda cuando se cambie la selección del ComboBox
            CargarDatosTienda();
        }

        private void CargarDatosTienda()
        {
            // Limpiar los elementos anteriores del ListView
            lvtienda.Items.Clear();

            // Obtener el tipo seleccionado
            string tipo = cbTipo.SelectedItem.ToString();

            // Realizar la consulta SQL para obtener los datos del tipo seleccionado
            string query = $"SELECT ID, Nombre, Unidades, Precio FROM {tipo}";

            // Establecer la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(ConexionBD.Conexion.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                try
                {
                    connection.Open();

                    // Ejecutar la consulta y leer los datos
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Obtener los datos del producto
                        string id = reader["ID"].ToString();
                        string nombre = reader["Nombre"].ToString();
                        string unidades = reader["Unidades"].ToString();
                        string precio = reader["Precio"].ToString() + "€";

                        // Cargar la imagen desde el archivo JPG en la carpeta imagenes
                        string imagePath = $"imagenes/{id}.jpg"; // Ruta de la imagen
                        string imageName = File.Exists(imagePath) ? id + ".jpg" : ""; // Nombre de la imagen o cadena vacía si no existe

                        // Agregar la imagen al ImageList si existe
                        if (File.Exists(imagePath))
                        {
                            imageList1.Images.Add(id, Image.FromFile(imagePath));
                        }

                        // Crear una nueva fila para el ListView
                        ListViewItem item = new ListViewItem();
                        item.ImageKey = id; // Establecer el índice de imagen

                        item.SubItems.Add(id);
                        item.SubItems.Add(nombre);
                        item.SubItems.Add(unidades);
                        item.SubItems.Add(precio);

                        // Agregar la fila al ListView
                        lvtienda.Items.Add(item);
                    }
                    reader.Close();

                    // Después de agregar los elementos al ListView
                    lvtienda.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al recuperar datos: " + ex.Message);
                }
            }
        }


        private void btncarrito_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en lvTienda
            if (lvtienda.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un elemento de la tienda primero.");
                return;
            }

            // Obtener los datos del elemento seleccionado en lvTienda
            ListViewItem selectedItem = lvtienda.SelectedItems[0];
            string id = selectedItem.SubItems[1].Text; // ID
            string nombre = selectedItem.SubItems[2].Text; // Nombre
            string precio = selectedItem.SubItems[4].Text.Replace("€", ""); // Precio

            // Obtener la cantidad disponible en la tienda
            int cantidadDisponible = int.Parse(selectedItem.SubItems[3].Text);

            // Verificar si el producto ya está en lvCarrito
            bool encontrado = false;
            foreach (ListViewItem item in lvcarrito.Items) 
            {
                if (item.SubItems[0].Text == id)
                {
                    // Si el producto ya está en lvCarrito, aumenta la cantidad si hay suficiente cantidad en la tienda
                    int cantidadActual = int.Parse(item.SubItems[2].Text);
                    if (cantidadActual < cantidadDisponible)
                    {
                        // Si hay suficiente cantidad en la tienda, aumentar la cantidad en el carrito
                        cantidadActual++;
                        item.SubItems[2].Text = cantidadActual.ToString();

                        // Actualizar el precio total del producto en el carrito
                        decimal precioUnitario = decimal.Parse(precio);
                        item.SubItems[3].Text = (cantidadActual * precioUnitario).ToString("0.00") + "€";

                        encontrado = true;
                    }
                    else
                    {
                        // Si no hay suficiente cantidad en la tienda, mostrar un mensaje y salir del método
                        MessageBox.Show("No hay suficiente cantidad disponible en la tienda.");
                        return;
                    }
                    break;
                }
            }

            // Si el producto no está en lvCarrito y hay suficiente cantidad en la tienda, agrégalo
            if (!encontrado && cantidadDisponible > 0)
            {
                // Crear un nuevo elemento para lvCarrito
                ListViewItem newItem = new ListViewItem(id); // ID
                newItem.SubItems.Add(nombre); // Nombre
                newItem.SubItems.Add("1"); // Cantidad
                newItem.SubItems.Add(precio + "€"); // Precio

                // Agregar el nuevo elemento a lvCarrito
                lvcarrito.Items.Add(newItem);

                encontrado = true;
            }

            // Actualizar el total del carrito
            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            // Reiniciar el total
            totalCarrito = 0;

            // Calcular el total sumando los precios de los productos en lvcarrito
            foreach (ListViewItem item in lvcarrito.Items)
            {
                string precio = item.SubItems[3].Text.Replace("€", "");
                int cantidad = int.Parse(item.SubItems[2].Text);
                totalCarrito += decimal.Parse(precio) * cantidad;
            }

            // Mostrar el total en el Label
            labeltotal.Text = totalCarrito.ToString("0.00") + "€";
        }

        private void btnborrararticulo_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en lvCarrito
            if (lvcarrito.SelectedItems.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un artículo del carrito primero.");
                return;
            }

            // Obtener el elemento seleccionado de lvCarrito
            ListViewItem selectedItem = lvcarrito.SelectedItems[0];
            int cantidadActual = int.Parse(selectedItem.SubItems[2].Text); // Obtener la cantidad actual del producto

            // Si la cantidad es mayor que 1, disminuir la cantidad en uno
            if (cantidadActual > 1)
            {
                // Restar uno a la cantidad
                cantidadActual--;
                selectedItem.SubItems[2].Text = cantidadActual.ToString(); // Actualizar la cantidad en el ListView
            }
            else
            {
                // Si la cantidad es igual a 1, eliminar el producto
                lvcarrito.Items.Remove(selectedItem);
            }

            // Actualizar el precio total del carrito
            ActualizarTotal();
        }

        private void btnborrarcarrito_Click(object sender, EventArgs e)
        {
            lvcarrito.Items.Clear();

            // Reiniciar el total del carrito
            totalCarrito = 0;
            labeltotal.Text = "0.00€";
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            // Crear una aplicación Excel
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            // Crear un nuevo libro de Excel
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // Encabezados
            worksheet.Cells[1, 1] = "ID";
            worksheet.Cells[1, 2] = "Nombre";
            worksheet.Cells[1, 3] = "Cantidad";
            worksheet.Cells[1, 4] = "Precio";

            // Datos de lvcarrito
            int row = 2;
            foreach (ListViewItem item in lvcarrito.Items)
            {
                worksheet.Cells[row, 1] = item.SubItems[0].Text; // ID
                worksheet.Cells[row, 2] = item.SubItems[1].Text; // Nombre
                worksheet.Cells[row, 3] = item.SubItems[2].Text; // Cantidad
                worksheet.Cells[row, 4] = item.SubItems[3].Text; // Precio
                row++;
            }

            // Precio total
            worksheet.Cells[row, 3] = "Precio Total:";
            worksheet.Cells[row, 4] = labeltotal.Text;

            // Fecha y hora
            worksheet.Cells[row + 1, 3] = "Fecha:";
            worksheet.Cells[row + 1, 4] = DateTime.Now.ToShortDateString();
            worksheet.Cells[row + 2, 3] = "Hora:";
            worksheet.Cells[row + 2, 4] = DateTime.Now.ToShortTimeString();

            // Mensaje de agradecimiento
            worksheet.Cells[row + 4, 1] = "Gracias por su compra!";

            // Guardar el libro de Excel en la carpeta del proyecto
            string projectPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string facturasPath = System.IO.Path.Combine(projectPath, "facturas");
            if (!System.IO.Directory.Exists(facturasPath))
            {
                System.IO.Directory.CreateDirectory(facturasPath);
            }
            string filePath = System.IO.Path.Combine(facturasPath, $"Factura_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx");
            workbook.SaveAs(filePath);

            // Liberar recursos [opcionales, quiero ver la factura]
            //workbook.Close();
            //excelApp.Quit();

            // Mostrar mensaje de confirmación
            MessageBox.Show("Factura generada correctamente en la carpeta de facturas.", "Factura Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SALIR DE LA APLICACION?", "SALIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
               this.Close();
            }
        }

        private void btnBicicleta_Click(object sender, EventArgs e)
        {
            BiciForm biciForm = new BiciForm();
            biciForm.ShowDialog();
        }
    }
}
