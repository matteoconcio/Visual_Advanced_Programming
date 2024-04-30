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

namespace PF_CA81492KO_20517869Y
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
           PopulateAdminCombox();
            GBManagement.Enabled = false;
        }
        SqlConnection sqlConnection = new SqlConnection("server=MATTXPS\\SQLEXPRESS;database=master; Integrated Security=SSPI");

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

            //Unlock and populate in this the manage part
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("EXIT FROM APPLICATION?", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
