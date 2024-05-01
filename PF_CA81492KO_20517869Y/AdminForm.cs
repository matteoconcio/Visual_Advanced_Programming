using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static PF_CA81492KO_20517869Y.Login;

namespace PF_CA81492KO_20517869Y
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
           PopulateAdminCombox();
            GBManagement.Enabled = false;
            GBModifyPart.Enabled = false;
            lvtienda.Enabled = false;
        }
        SqlConnection sqlConnection = new SqlConnection("server=MATTASUS\\SQLEXPRESS;database=master; Integrated Security=SSPI");

        private void PopulateAdminCombox()
        {
            string query = "SELECT Username FROM Admins";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string adminUsername = sqlDataReader["Username"].ToString();
                    CBManageAdmin.Items.Add(adminUsername);
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally 
            { 
                sqlConnection.Close(); 
            }
        }

        private void btnManageAdmin_Click_1(object sender, EventArgs e)
        {
            //enable GBManagment
            GBManagement.Enabled = true;

            //populate txtNombreAdmin and txtOldPassword in the groupbox
            string selectedUsername = CBManageAdmin.SelectedItem as string;

            if (selectedUsername != null)
            {
                string query = "SELECT Password FROM Admins WHERE Username = @Username";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Username", selectedUsername);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        string adminPassword = sqlDataReader["Password"].ToString();
                        TxtBoxNombreAdmin.Text = selectedUsername; //populate the admin username
                        TxtBoxOldPassword.Text = adminPassword; //populate the admin password
                    }
                    else
                    {
                        //username not found in the Admins table
                        MessageBox.Show("Selected username not found in the database.");
                    }

                    sqlDataReader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            else
            {
                //no username selected in the ComboBox
                MessageBox.Show("Please select a username.");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SALIR DE LA APLICACION?", "SALIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnSaveAdmin_Click(object sender, EventArgs e)
        {
                string oldPassword = TxtBoxOldPassword.Text;
                string newPassword = TxtBoxNewPassword.Text;
                string confirmPassword = TxtBoxRepeatNewPass.Text;
                string selectedUsername = TxtBoxNombreAdmin.Text;

                //check if the old password matches the password in the database for the selected username
                string query = "SELECT Password FROM Admins WHERE Username = @Username";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Username", selectedUsername);

                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        string dbPassword = sqlDataReader["Password"].ToString();
                        sqlDataReader.Close();

                        if (oldPassword != dbPassword)
                        {
                            MessageBox.Show("Old password is incorrect.");
                            return;
                        }
                    }
                    else
                    {
                        // Username not found in the Admins table
                        MessageBox.Show("Selected username not found in the database.");
                        sqlDataReader.Close();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    sqlConnection.Close();
                    return;
                }

                // Check if the new password and confirm password match
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New password and confirm password do not match.");
                    return;
                }

                // Check if the new password meets the minimum length requirement
                if (newPassword.Length < 5)
                {
                    MessageBox.Show("New password must be at least 5 characters long.");
                    return;
                }

                // Update the password in the Admins table
                query = "UPDATE Admins SET Password = @NewPassword WHERE Username = @Username";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                sqlCommand.Parameters.AddWithValue("@Username", selectedUsername);

                try
                {
                    int rowsAffected = sqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.");
                        TxtBoxNombreAdmin.Clear();
                        TxtBoxOldPassword.Clear();
                        TxtBoxNewPassword.Clear();
                        TxtBoxRepeatNewPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            bool isVisible = !TxtBoxOldPassword.UseSystemPasswordChar;

            TxtBoxOldPassword.UseSystemPasswordChar = isVisible;
            TxtBoxNewPassword.UseSystemPasswordChar = isVisible;
            TxtBoxRepeatNewPass.UseSystemPasswordChar = isVisible;
        }

        
        private void btnManagePart_Click(object sender, EventArgs e)
        {
            GBModifyPart.Enabled = true;
            lvtienda.Enabled = true;
            CargarDatosTienda();
            lvtienda.LabelEdit = true;

        }

        private void CargarDatosTienda()
        {
            // Limpiar los elementos anteriores del ListView
            lvtienda.Items.Clear();

            // Obtener el tipo seleccionado
            string tipo = CBManagePart.SelectedItem.ToString();


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

        private void TxtBoxRepeatNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblModifyPasswordAdmin_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxNombreAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvtienda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvtienda.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = lvtienda.SelectedItems[0];

                // Populate the textboxes with the corresponding values
                TxtBoxManagePart.Text = selectedItem.SubItems[2].Text; // Assuming the name is in the third column (index 2)
                TxtBoxQuantity.Text = selectedItem.SubItems[3].Text; // Assuming the quantity is in the fourth column (index 3)
                TxtBoxPrice.Text = selectedItem.SubItems[4].Text; // Assuming the price is in the fifth column (index 4)
            }
            else
            {
                // Clear the textboxes if no item is selected
                TxtBoxManagePart.Clear();
                TxtBoxQuantity.Clear();
                TxtBoxPrice.Clear();
            }
        }
    }
}

