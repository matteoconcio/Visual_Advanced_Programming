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
    }
}
