using MySqlConnector;
using System.Data.SqlClient;
using System.IO;
using System;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;
using MySqlX.XDevAPI.Relational;
using WeifenLuo.WinFormsUI.Docking;
using BookTrackerInterface;

namespace FunctionalityForms
{
    public partial class AddNewBookForm : Form
    {
        private string cConnectionString;
        private string cNewCoverFileLocation;

        public AddNewBookForm(string passedConnection, string passedCover)
        {
            InitializeComponent();

            this.cConnectionString = passedConnection;
            this.cNewCoverFileLocation = passedCover;


            //Genre Box Setup
            FillGenreListBox(); //Fills out from database
            tbGenre.Click += bookGenre_Click; //on click make list visable
            listBookGenre.SelectedIndexChanged += listBookGenre_SelectedIndexChanged; //as items are selected in the listbox add them to the textbox
            listBookGenre.SelectionMode = SelectionMode.MultiExtended; //allow for multi seletion with ctrl or shift

            listBookGenre.LostFocus += listBookGenre_LostFocus;

            //Medium Box Setup from database
            FillMediumListBox();
            //Series Box Setup from database
            FillSeriesListBox();
            //Author Box Setup from database
            FillAuthorListBox();

            tbDate.Validating += bookDate_Validating;
            tbNum.Validating += bookNum_Validating;
        }

        private bool listBoxVisible = false;

        //####################################################################################
        //Auto sets date box to current date when form is loaded
        //####################################################################################
        private void Form1_Load(object sender, EventArgs e)
        {
            tbDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }

        //####################################################################################
        //Queries the Genres table in database and fills out the listBookGenre box
        //####################################################################################
        private void FillGenreListBox()
        {
            string query = "SELECT name FROM genres ORDER BY name ASC";

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string genreName = reader.GetString("name");
                            listBookGenre.Items.Add(genreName); // Add each genre name to the ListBox
                        }
                    }

                    conn.Close(); // Close the database connection
                }
            }
        }

        //####################################################################################
        //Queries the Mediums table in database and fills out the bookMedium combox
        //####################################################################################
        private void FillMediumListBox()
        {
            string query = "SELECT medium_name FROM mediums ORDER BY medium_name ASC";

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string mediumName = reader.GetString("medium_name");
                            cbMedium.Items.Add(mediumName); // Add each meidum name to the ListBox
                        }
                    }

                    conn.Close(); // Close the database connection
                }
            }
        }

        //####################################################################################
        //Queries the Series column in the Books table and fills out the bookSeries combox
        //####################################################################################
        private void FillSeriesListBox()
        {
            string query = "SELECT DISTINCT series_name FROM books WHERE series_name <> '' ORDER BY series_name ASC";

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string seriesName = reader.GetString("series_name");
                            cbSeries.Items.Add(seriesName); // Add each meidum name to the ListBox
                        }
                    }
                    conn.Close(); // Close the database connection
                }
            }
        }

        //####################################################################################
        //Queries the Author column in the Books table and fills out the bookSeries combox
        //####################################################################################
        private void FillAuthorListBox()
        {
            string query = "SELECT DISTINCT author FROM books WHERE author <> '' ORDER BY author ASC";

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string authorName = reader.GetString("author");
                            cbAuthor.Items.Add(authorName); // Add each meidum name to the ListBox
                        }
                    }
                    conn.Close(); // Close the database connection
                }
            }
        }

        //####################################################################################
        //Validates that the string in bookNum is a numerical value or blank (null)
        //####################################################################################
        private void bookNum_Validating(object? sender, CancelEventArgs e)
        {
            string enteredValue = tbNum.Text.Trim();
            if (!int.TryParse(enteredValue, out _) && enteredValue != "")
            {
                // Display an error message or perform necessary actions when the value is not a valid integer
                MessageBox.Show("Please enter a numerical value for the book number.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNum.Focus(); // Set focus back to the bookNum TextBox
                e.Cancel = true; // Prevent the focus from moving to the next control
            }
        }

        //####################################################################################
        //Unique behavior for genre
        //  - hides listbox and makes appear when textbox is clicked
        //  - Concatinates multiclick choices into single string with ',' separator
        //  - rehides listbox when focus is lost
        //####################################################################################
        private void bookGenre_Click(object sender, EventArgs e)
        {
            listBoxVisible = !listBoxVisible;
            listBookGenre.Visible = listBoxVisible;
        }
        private void listBookGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbGenre.Text = string.Join(",", listBookGenre.SelectedItems.Cast<string>());
        }
        private void listBookGenre_LostFocus(object sender, EventArgs e)
        {
            listBoxVisible = false;
            listBookGenre.Visible = listBoxVisible;
        }

        //####################################################################################
        //Validates that there is a Date in YYYY-MM-DD format in the Date textbox
        //####################################################################################
        private void bookDate_Validating(object sender, CancelEventArgs e)
        {
            string enteredDate = tbDate.Text.Trim();

            if (!DateTime.TryParseExact(enteredDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show("Please enter the date in the format YYYY-MM-DD.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Prevents the TextBox from losing focus
            }
        }

        //####################################################################################
        //Adds new genre if genre isn't in List
        //####################################################################################
        private void bookGenre_AddNew(string inputGenre)
        {

            string insertGenreSql = "INSERT INTO genres (name) " +
                                        "VALUES (@genre)";

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
            {
                connection.Open();

                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertGenreSql, connection))
                {
                    command.Parameters.AddWithValue("@genre", inputGenre);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //MessageBox.Show("New Genre added to Genres");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new genre");
                    }
                }
                connection.Close();
            }
        }

        //####################################################################################
        //Adds new medium if medium isn't in List
        //####################################################################################
        private void bookMedium_AddNew(string inputMedium)
        {

            string insertGenreSql = "INSERT INTO mediums (medium_name) " +
                                        "VALUES (@medium)";

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
            {
                connection.Open();

                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertGenreSql, connection))
                {
                    command.Parameters.AddWithValue("@medium", inputMedium);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //MessageBox.Show("New medium added to mediums");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new medium");
                    }
                }
                connection.Close();
            }
        }

        //####################################################################################
        //Adds book to database
        //####################################################################################
        private void Submit_Click(object sender, EventArgs e)
        {
            string inputTitle = tbTitle.Text.Trim();
            string inputAuthor = cbAuthor.Text.Trim();
            string inputSeries = cbSeries.Text.Trim();
            if (inputSeries == "") { inputSeries = null; }
            string inputNum = tbNum.Text.Trim();
            if (inputNum == "") { inputNum = null; }
            string inputCoverURL = tbCover.Text.Trim();
            DateTime now = DateTime.Now;
            string inputGenrestring = tbGenre.Text.Trim(); //can be deliniated by ,
            string[] inputGenre = inputGenrestring.Split(',');
            string inputDate = tbDate.Text.Trim();
            string who = "Seth"; //Seth = 1, Em = 2 for SQL
            if (who == "Seth") { who = "1"; }
            string inputMedium = cbMedium.Text.Trim();

            if (inputTitle == "" || inputAuthor == "" || inputGenrestring == "" || inputMedium == "" || inputCoverURL == "" || inputDate == "")
            {
                //Cannot Submit because data is missing
                MessageBox.Show("Please Fill Out Required Fields");
            }
            else
            {
                //Check to see if new medium and if so, add to database
                if (!cbMedium.Items.Contains(inputMedium))
                {
                    bookMedium_AddNew(inputMedium);
                }

                //Check to see if new genre and if so, add to database
                foreach (string genre in inputGenre)
                {
                    if (!listBookGenre.Items.Contains(genre))
                    {
                        bookGenre_AddNew(genre);
                    }
                }

                //Copy over Cover File, Rename and store URL for databse
                string newCoverFileName = string.Format("{0:yyyyMMddHHmmss}-{1}.jpg", now, Guid.NewGuid());
                string outputCoverURL = cNewCoverFileLocation + newCoverFileName;
                System.IO.File.Copy(inputCoverURL, outputCoverURL, true);
                System.IO.File.SetLastWriteTime(outputCoverURL, DateTime.Now);

                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
                {
                    connection.Open();

                    // Insert into books table
                    string insertBooksSql = "INSERT INTO books (name, author, series_name, book_number_in_series, image_url, who) " +
                                            "VALUES (@name, @author, @seriesName, @bookNumber, @cover, @who)";

                    using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertBooksSql, connection))
                    {
                        command.Parameters.AddWithValue("@name", inputTitle);
                        command.Parameters.AddWithValue("@author", inputAuthor);
                        command.Parameters.AddWithValue("@seriesName", inputSeries);
                        command.Parameters.AddWithValue("@bookNumber", inputNum);
                        command.Parameters.AddWithValue("@cover", newCoverFileName);
                        command.Parameters.AddWithValue("@who", 1);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("Insert into books table successful.");
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
                                //MessageBox.Show("Insert into book_genre_associations table successful.");
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
                            //MessageBox.Show("Insert into book_history table successful.");
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
                            //MessageBox.Show("Insert into book_medium_associations table successful.");
                        }
                        else
                        {
                            MessageBox.Show("Insert into book_medium_associations table failed.");
                        }
                    }

                    connection.Close();

                }

                //Clear out form for a second book
                tbTitle.Text = string.Empty;
                cbSeries.Text = string.Empty;
                cbAuthor.Text = string.Empty;
                cbAuthor.Items.Clear();
                tbNum.Text = string.Empty;
                tbGenre.Text = string.Empty;
                cbMedium.Text = string.Empty;
                cbMedium.Items.Clear();
                tbCover.Text = string.Empty;
                tbDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                listBookGenre.Visible = false;
                listBookGenre.Items.Clear();
                //Medium Box Setup from database
                FillMediumListBox();
                //Series Box Setup from database
                FillSeriesListBox();
                //Author Box Setup from database
                FillAuthorListBox();
            }

        }

        private void bCoverFile_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory, the type of files to look for, etc.
            openFileDialog.InitialDirectory = "c:\\Users\\edens\\Downloads";
            openFileDialog.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            // Show the OpenFileDialog and get the result
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // If the user selected a file, get the file's full path
                string filePath = openFileDialog.FileName;

                // You can now use the file for whatever you need
                tbCover.Text = filePath;
                pbCover.Image = Image.FromFile(filePath);


            }

        }


    }
}