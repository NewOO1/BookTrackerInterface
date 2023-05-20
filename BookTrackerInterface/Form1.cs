using MySqlConnector;
using System.Data.SqlClient;
using System.IO;
using System;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace BookTrackerInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bookGenre.Click += bookGenre_Click;
            listBookGenre.SelectedIndexChanged += listBookGenre_SelectedIndexChanged;

            listBookGenre.LostFocus += listBookGenre_LostFocus;

            listBookGenre.SelectionMode = SelectionMode.MultiExtended;
            bookDate.Validating += bookDate_Validating;
            bookNum.Validating += bookNum_Validating;
        }

        private void bookNum_Validating(object? sender, CancelEventArgs e)
        {
            string enteredValue = bookNum.Text.Trim();
            if (!int.TryParse(enteredValue, out _))
            {
                // Display an error message or perform necessary actions when the value is not a valid integer
                MessageBox.Show("Please enter a numerical value for the book number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bookNum.Focus(); // Set focus back to the bookNum TextBox
                e.Cancel = true; // Prevent the focus from moving to the next control
            }
        }

        private bool listBoxVisible = false;

        private void bookGenre_Click(object sender, EventArgs e)
        {
            listBoxVisible = !listBoxVisible;
            listBookGenre.Visible = listBoxVisible;
        }

        private void listBookGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookGenre.Text = string.Join(", ", listBookGenre.SelectedItems.Cast<string>());
        }

        private void listBookGenre_LostFocus(object sender, EventArgs e)
        {
            listBoxVisible = false;
            listBookGenre.Visible = listBoxVisible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bookDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void bookDate_Validating(object sender, CancelEventArgs e)
        {
            string enteredDate = bookDate.Text.Trim();

            if (!DateTime.TryParseExact(enteredDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Please enter the date in the format YYYY-MM-DD.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Prevents the TextBox from losing focus
            }
        }

        private void bookSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookSeries.SelectedItem != null && bookSeries.SelectedIndex == bookSeries.Items.Count - 1)
            {
                string newItem = bookSeries.SelectedItem.ToString();
                // Process the new item
                // Example: Add the new item to the list
                bookSeries.Items.Insert(bookSeries.Items.Count - 1, newItem);
                bookSeries.SelectedIndex = bookSeries.Items.Count - 2;
            }
        }

        private void bookAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookAuthor.SelectedItem != null && bookAuthor.SelectedIndex == bookAuthor.Items.Count - 1)
            {
                string newItem = bookAuthor.SelectedItem.ToString();
                // Process the new item
                // Example: Add the new item to the list
                bookAuthor.Items.Insert(bookAuthor.Items.Count - 1, newItem);
                bookAuthor.SelectedIndex = bookAuthor.Items.Count - 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=192.168.1.53;port=3307;uid=BookTracker;pwd=0$c0edC7vsui6cSg;database=BookTracker";
            //conn = new MySql.Data.MySqlClient.MySqlConnection();
            //conn.ConnectionString = myConnectionString;
            //conn.Open();

            string sql = "SELECT * FROM books";
            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, connection))
                {
                    command.CommandTimeout = 0;
                    connection.Open();
                    using (MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(1);
                                string author = reader.GetString(2);
                                //string path = Path.Combine(dir, fname);
                                bookTitle.Text = name;
                                MessageBox.Show(name);
                            }
                        }
                    }
                }
            }

            /*try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            /*string cLCI_ConnectString = @"server=192.168.1.53;"
                                + @"Database=BookTracker;"
                                + @"uid=root;"
                                + @"pwd=F%I30F%%uSuF;"
                                //+ @"Trusted_Connection=False;"
                                //+ @"Encrypt=True;"
                                + @"Connection Timeout=5;";
            //+ @"TrustServerCertificate=True;";

            string sql = "SELECT * FROM books";


            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(cLCI_ConnectString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(sql, connection))
                {
                    command.CommandTimeout = 0;
                    connection.Open();
                    using (MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                string author = reader.GetString(1);
                                //string path = Path.Combine(dir, fname);
                                bookTitle.Text = name;

                            }
                        }
                    }
                }
            }*/












            /*
            string connString = "Server=192.168.1.53;Database=BookTracker;Uid=root;Pwd=F%I30F%%uSuF;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM books", conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader.GetString("name");
                        string author = reader.GetString("author");
                        // ... handle other columns as needed
                        textBox1.Text = name;
                    }
                }
            }*/

            bookTitle.Text = string.Empty;
            bookSeries.Text = string.Empty;
            bookAuthor.Text = string.Empty;
            bookNum.Text = string.Empty;
            bookGenre.Text = string.Empty;
            bookMedium.Text = string.Empty;
            bookDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }

      
    }
}