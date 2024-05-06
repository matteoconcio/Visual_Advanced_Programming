using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Azure.Identity;
using OfficeOpenXml;
using static PF_CA81492KO_20517869Y.Login;
using Excel = Microsoft.Office.Interop.Excel;

namespace PF_CA81492KO_20517869Y
{
    public partial class BiciForm : Form
    {
        public BiciForm()
        {
            InitializeComponent();
            FillCombox();
        }

        private void FillCombox()
        {
            string connectionString = "server=MATTASUS\\SQLEXPRESS;database=master; Trusted_Connection=True; Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT nombre FROM Bikes";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                cbModelo.Items.Clear();

                while (reader.Read())
                {
                    cbModelo.Items.Add(reader["nombre"].ToString());
                }
                reader.Close();

            }
        }
        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvModelo.Items.Clear();

            // Get the selected bike name
            string selectedBikeName = cbModelo.SelectedItem.ToString();

            // Get the parts and their prices for the selected bike
            List<Tuple<string, decimal>> bikePartsAndPrices = GetBikePartsAndPrices(selectedBikeName);

            // Populate ListView with piece names and prices
            foreach (Tuple<string, decimal> partAndPrice in bikePartsAndPrices)
            {
                ListViewItem lvItem = new ListViewItem(partAndPrice.Item1); // Piece name
                lvItem.SubItems.Add(partAndPrice.Item2.ToString() + "€"); // Piece price
                lvModelo.Items.Add(lvItem);
            }
        }
        private List<Tuple<string, decimal>> GetBikePartsAndPrices(string bikeName)
        {
            List<Tuple<string, decimal>> bikePartsAndPrices = new List<Tuple<string, decimal>>();

            // SQL query to retrieve the names of bike parts and their prices for the selected bike
            string query = "SELECT Cuadro, Cadena, Cierre, Disco, Manillar, Neumaticos, Rueda, Pedal, Plato, Sillin FROM Bikes WHERE nombre = @nombre";

            string connectionString = "server=MATTASUS\\SQLEXPRESS;database=master; Trusted_Connection=True; Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                sqlCommand.Parameters.AddWithValue("@nombre", bikeName);

                try
                {
                    connection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        // Iterate through the columns of the selected bike
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string columnName = reader.GetName(i);
                            string pieceName = reader.IsDBNull(i) ? null : reader.GetString(i);

                            if (!string.IsNullOrEmpty(pieceName))
                            {
                                // Fetch the price of the piece from the 'piezas' table
                                decimal piecePrice = GetPiecePrice(pieceName);
                                bikePartsAndPrices.Add(new Tuple<string, decimal>(pieceName, piecePrice));
                            }
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return bikePartsAndPrices;
        }

        private decimal GetPiecePrice(string pieceName)
        {
            // SQL query to retrieve the price of the piece from the 'piezas' table
            string query = "SELECT precio FROM piezas WHERE nombre = @nombre";

            string connectionString = "server=MATTASUS\\SQLEXPRESS;database=master; Trusted_Connection=True; Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand sqlCommand = new SqlCommand(query, connection))
            {
                sqlCommand.Parameters.AddWithValue("@nombre", pieceName);

                try
                {
                    connection.Open();
                    object result = sqlCommand.ExecuteScalar();
                    decimal price = result == null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
                    return price;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return 0;
                }
            }
        }

        public class ShoppingCartItem
        {
            public string PieceName { get; set; }
            public decimal PiecePrice { get; set; }

            public ShoppingCartItem(string pieceName, decimal piecePrice)
            {
                PieceName = pieceName;
                PiecePrice = piecePrice;
            }

            // Override ToString method to display item information
            public override string ToString()
            {
                return $"{PieceName}:  {PiecePrice.ToString()}€";
            }
        }

        // Define a list to store items in the shopping cart
        private List<ShoppingCartItem> shoppingCart = new List<ShoppingCartItem>();

        // Event handler for adding items to the shopping cart
        private void btncarrito_Click(object sender, EventArgs e)
        {
            decimal totalBici = 0;

            // Add items from lvModelo to the shopping cart and calculate total price
            foreach (ListViewItem item in lvModelo.Items)
            {
                string pieceName = item.SubItems[0].Text;
                decimal piecePrice = int.Parse(item.SubItems[1].Text.TrimEnd('€')); // Remove '€' symbol and parse to decimal
                totalBici += piecePrice;

                // Add the piece to the shopping cart
                AddToShoppingCart(pieceName, piecePrice);
            }

            // Display total price in labelTotalBici
            labelTotalBici.Text = totalBici.ToString() + "€";
        }

        // Method to add an item to the shopping cart
        private void AddToShoppingCart(string pieceName, decimal piecePrice)
        {
            // Create a new ShoppingCartItem and add it to the shopping cart list
            shoppingCart.Add(new ShoppingCartItem(pieceName, piecePrice));

            // Refresh the display of the shopping cart (e.g., update a ListBox, DataGridView, etc.)
            RefreshShoppingCartDisplay();
        }


        // Method to refresh the display of the shopping cart
        private void RefreshShoppingCartDisplay()
        {
            // Clear the display of the shopping cart (e.g., ListBox)
            lvCarritoBicicleta.Items.Clear();

            // Add each item in the shopping cart to the display
            foreach (var item in shoppingCart)
            {
                ListViewItem lvcarrito = new ListViewItem(item.PieceName);

                lvcarrito.SubItems.Add(item.PiecePrice.ToString() + "€");
                lvCarritoBicicleta.Items.Add(lvcarrito);
            }
        }

        private void btnborrarcarrito_Click(object sender, EventArgs e)
        {
            lvCarritoBicicleta.Items.Clear();

            labelTotalBici.Text = "0.00€";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Salir de la aplicacion?", "SALIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK){
                ClientForm clientForm = Application.OpenForms.OfType<ClientForm>().FirstOrDefault();
                clientForm?.Close(); // Close only if not null

                // Close the current form
                this.Close();
            }
        }

        string username = GlobalVariables.Username;
        private void btnFinalizarBicicleta_Click(object sender, EventArgs e)
        {
            //crear una aplicación Excel
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            //crear un nuevo libro de Excel
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            //encabezados
            worksheet.Cells[1, 1] = "Nombre";
            worksheet.Cells[1, 2] = "Precio";

            //datos de lvcarritoBicicleta
            int row = 2;
            foreach (ListViewItem item in lvCarritoBicicleta.Items)
            {
                worksheet.Cells[row, 1] = item.SubItems[0].Text; //nombre
                worksheet.Cells[row, 2] = item.SubItems[1].Text; //precio
                row++;
            }

            //precio total
            worksheet.Cells[row, 3] = "Precio Total:";
            worksheet.Cells[row, 4] = labelTotalBici.Text + "€";

            //fecha y hora
            worksheet.Cells[row + 1, 3] = "Fecha:";
            worksheet.Cells[row + 1, 4] = DateTime.Now.ToShortDateString();
            worksheet.Cells[row + 2, 3] = "Hora:";
            worksheet.Cells[row + 2, 4] = DateTime.Now.ToShortTimeString();

            //poner la venta en la Tabla SQL
            DateTime fechaVenta = DateTime.Now;

            //obtener el cliente (podrías obtenerlo de algún control en tu formulario)
            string cliente = username;

            //guardar la información de la venta en la tabla Ventas
            decimal ventaID = GuardarVenta(fechaVenta, cliente);

            //print client in worksheet
            worksheet.Cells[row + 4, 4] = "Cliente: " + username.ToString();
            worksheet.Cells[row + 5, 4] = "ID Venta: " + Convert.ToString(ventaID);

            //mensaje de agradecimiento
            worksheet.Cells[row + 4, 1] = "Gracias por su compra!";
            worksheet.Cells[row + 5, 1] = "BikeShop.es";

            //guardar el libro de Excel en la carpeta del proyecto
            string projectPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string facturasPath = System.IO.Path.Combine(projectPath, "facturas");
            if (!System.IO.Directory.Exists(facturasPath))
            {
                System.IO.Directory.CreateDirectory(facturasPath);
            }
            string filePath = System.IO.Path.Combine(facturasPath, $"Factura_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx");
            workbook.SaveAs(filePath);

           
        }

        //guardar informacion ventas in tabla Ventas
        private decimal GuardarVenta(DateTime fechaVenta, string cliente)
        {
            decimal ventaID = 0;

            string connectionString = "server=MATTASUS\\SQLEXPRESS;database=master; Trusted_Connection=True; Integrated Security=SSPI";
            string query = "INSERT INTO Ventas (FechaVenta, Cliente) VALUES (@FechaVenta, @Cliente); SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //parametros
                    command.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                    command.Parameters.AddWithValue("@Cliente", cliente);

                    try
                    {
                        connection.Open();
                        ventaID = Convert.ToDecimal(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al guardar la venta: " + ex.Message);
                    }
                }
            }
            return ventaID;
        }
    }
}
