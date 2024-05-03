using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_CA81492KO_20517869Y
{
    public partial class RegisterClient : Form
    {
        public RegisterClient()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection("server=MATTASUS\\SQLEXPRESS;database=master; Trusted_Connection=True; Integrated Security=SSPI");
        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            string username = TxtBoxRegisterUser.Text;
            string password = TxtBoxRegisterPassword.Text;
            

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Invalid username or password\n");
                return;
            }
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection; 
                connection.Open();

                //retrive lastClientID
                int lastClientID;
                using (SqlCommand sqlCommandID = new SqlCommand("SELECT ISNULL(MAX(ClientID),0) FROM Clients", connection))
                {
                    lastClientID = (int)sqlCommandID.ExecuteScalar();
                }

                //Increment lastClientID to get newClientID
                int newClientID = lastClientID + 1;

                //Insert into Table new client
                sqlCommand.CommandText = "INSERT INTO [dbo].[Clients] ([ClientID],[Username],[Password]) VALUES (@clientID, @username, @password)";
                sqlCommand.Parameters.AddWithValue("clientID", newClientID);
                sqlCommand.Parameters.AddWithValue("username", username);
                sqlCommand.Parameters.AddWithValue("password", password);
                sqlCommand.ExecuteNonQuery();

                TxtBoxRegisterUser.Clear();
                TxtBoxRegisterPassword.Clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
            finally
            {
                connection.Close();
                Close();
            }

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            bool showPassword = !TxtBoxRegisterPassword.UseSystemPasswordChar;
            TxtBoxRegisterPassword.UseSystemPasswordChar = showPassword;
        }

        private void btnShowPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegister.PerformClick();
            }
        }
    }
}
