using Microsoft.Identity.Client;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_CA81492KO_20517869Y
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public class ConexionBD
        {
            public static SqlConnection Conexion { get; private set; }
            private static string connectionString = "server=MATTASUS\\SQLEXPRESS;database=master; Trusted_Connection=True; Integrated Security=SSPI";
            static ConexionBD()
            {
                // Create and initialize the SqlConnection object
                Conexion = new SqlConnection(connectionString);
            }

            public static void OpenConnection()
            {
                if(Conexion.State != ConnectionState.Closed)
                {
                    Conexion.Close();
                }
            }

            public static void CloseConnection()
            {
                if(Conexion.State != ConnectionState.Closed)
                {
                    Conexion.Close();
                }
            }
        }

        //btnExit works properly
        private void bntExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SALIR DE LA APLICACION?", "SALIDA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public string UserType
        {
            get { return UserType; }
            set { UserType = CbUserType.SelectedItem as string; }
        }
        public static class GlobalVariables
        {
            public static string Username { get; set; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtBoxUser.Text.Trim();
            string password = TxtBoxPassword.Text;
            string userType = CbUserType.SelectedItem as string;

            if (string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Please, select a User Type");
                return;
            }

            string tableName = (userType == "Client") ? "Clients" : "Admins";
            string queryDB = $"SELECT Password FROM {tableName} WHERE Username = @Username";
            string connectionLogin = "server=MATTASUS\\SQLEXPRESS;database=master; Trusted_Connection=True; Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(connectionLogin))
            using (SqlCommand sqlCommand = new SqlCommand(queryDB, connection))
            {
                sqlCommand.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    object result = sqlCommand.ExecuteScalar();

                    // el usuario existe en la base de datos
                    if (result != null)
                    {
                        string passwordDB = result.ToString();

                        // compara las contraseñas
                        if (password == passwordDB)
                        {
                            Console.WriteLine("Login Successful");
                            // abre AdminForm o ClientForm
                            if (userType == "Client")
                            {
                                GlobalVariables.Username = username;
                                ClientForm clientForm = new ClientForm();
                                clientForm.ShowDialog();
                            }
                            else if (userType == "Admin")
                            {
                                AdminForm adminForm = new AdminForm();
                                adminForm.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        //limpia TxtBoxUser y TxtBoxPassword al cambiar de Admin a Client y viceversa
        private void CbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtBoxUser.Clear();
            TxtBoxPassword.Clear();
        }

        //abre el form RegisterClient
        private void bntRegisterClient_Click(object sender, EventArgs e)
        {
            RegisterClient registerClient = new RegisterClient();
            registerClient.ShowDialog();
        }

        //muestra password en TxtBoxPassword
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            bool showPassword = !TxtBoxPassword.UseSystemPasswordChar;
            TxtBoxPassword.UseSystemPasswordChar = showPassword;
        }

        private void Login_Load(object sender, EventArgs e)
        {
           ConexionBD.OpenConnection();
        }

        private void TxtBoxPassword_Enter(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }

        private void TxtBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Perform the login action
                btnLogin.PerformClick();
            }
        }
    }

}
