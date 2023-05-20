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
            bookGenre.Text = string.Join(",", listBookGenre.SelectedItems.Cast<string>());
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

        //Validates that it was a Date in YYYY-MM-DD format in the Date textbo
        private void bookDate_Validating(object sender, CancelEventArgs e)
        {
            string enteredDate = bookDate.Text.Trim();

            if (!DateTime.TryParseExact(enteredDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Please enter the date in the format YYYY-MM-DD.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Prevents the TextBox from losing focus
            }
        }

        //Adds new Series Name if Name isn't in List
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

        //Adds new Authro Name if Name isn't in List
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
            string inputTitle = bookTitle.Text.Trim();
            string inputAuthor = bookAuthor.Text.Trim();
            string inputSeries = bookSeries.Text.Trim();
            string inputNum = bookNum.Text.Trim();
            string inputGenrestring = bookGenre.Text.Trim(); //can be deliniated by ,
            string[] inputGenre = inputGenrestring.Split(',');
            string inputDate = bookDate.Text.Trim();
            string who = "Seth"; //Seth = 1, Em = 2 for SQL
            string inputMedium = bookMedium.Text.Trim();

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=192.168.1.53;port=3307;uid=BookTracker;pwd=0$c0edC7vsui6cSg;database=BookTracker";
            //conn = new MySql.Data.MySqlClient.MySqlConnection();
            //conn.ConnectionString = myConnectionString;
            //conn.Open();
            /*
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
            } */

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString))
            {
                connection.Open();

                // Insert into books table
                string insertBooksSql = "INSERT INTO books (name, author, series_name, book_number_in_series, who) " +
                                        "VALUES (@name, @author, @seriesName, @bookNumber, @who)";

                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertBooksSql, connection))
                {
                    command.Parameters.AddWithValue("@name", inputTitle);
                    command.Parameters.AddWithValue("@author", inputAuthor);
                    command.Parameters.AddWithValue("@seriesName", inputSeries);
                    command.Parameters.AddWithValue("@bookNumber", inputNum);
                    command.Parameters.AddWithValue("@who", 1);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Insert into books table successful.");
                    }
                    else
                    {
                        MessageBox.Show("Insert into books table failed.");
                    }
                }

                // Insert into book_genre_associtations table taking into account that there could be more than 1 as well
                foreach (string genre in inputGenre)
                {
                    string insertGenreAssociationsSql = "INSERT INTO book_genre_associations (book_id, genre_id) " +
                                                        "VALUES (LAST_INSERT_ID(), (SELECT id FROM genres WHERE name = @genreName))";

                    using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertGenreAssociationsSql, connection))
                    {
                        command.Parameters.AddWithValue("@genreName", genre);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Insert into book_genre_associations table successful.");
                        }
                        else
                        {
                            MessageBox.Show("Insert into book_genre_associations table failed.");
                        }
                    }
                }


                // Insert into book_history table
                string insertBookHistorySql = "INSERT INTO book_history (book_id, finished_date) " +
                                              "VALUES (LAST_INSERT_ID(), @finishedDate)";

                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertBookHistorySql, connection))
                {
                    command.Parameters.AddWithValue("@finishedDate", inputDate);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Insert into book_history table successful.");
                    }
                    else
                    {
                        MessageBox.Show("Insert into book_history table failed.");
                    }
                }

                // Insert into book_medium_associations table
                string insertMediumAssociationsSql = "INSERT INTO book_medium_associations (history_id, medium_id) " +
                                                     "VALUES (LAST_INSERT_ID(), (SELECT id FROM mediums WHERE medium_name = @mediumName))";

                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertMediumAssociationsSql, connection))
                {
                    command.Parameters.AddWithValue("@mediumName", inputMedium);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Insert into book_medium_associations table successful.");
                    }
                    else
                    {
                        MessageBox.Show("Insert into book_medium_associations table failed.");
                    }
                }
            }

            //Clear out form for a second book
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