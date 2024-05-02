using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
