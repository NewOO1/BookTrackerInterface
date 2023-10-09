using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionalityForms
{
    public partial class AddNewCompletionForm : Form
    {
        private string cConnectionString;

        public AddNewCompletionForm(string cConnectionString)
        {
            this.cConnectionString = cConnectionString;

            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);

            //Medium Box Setup from database
            FillMediumListBox();
            //Medium Box Setup from database
            FillTitleComboBox();
            //Who Box Setup from database
            FillWhoComboBox();

            tbDate.Validating += bookDate_Validating;

        }

        //####################################################################################
        //Queries the Users table in database and fills out the combobox Who
        //####################################################################################
        private void FillWhoComboBox()
        {
            string query = "SELECT NAME FROM users ORDER BY Name ASC";

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string whoName = reader.GetString("NAME");
                            cbWho.Items.Add(whoName); // Add each meidum name to the ListBox
                        }
                    }

                    conn.Close(); // Close the database connection
                }
            }
        }

        //####################################################################################
        //Auto sets date box to current date when form is loaded
        //####################################################################################
        private void Form1_Load(object sender, EventArgs e)
        {
            tbDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

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
        //Queries the Titles table in database and fills out cbTitle 
        //####################################################################################
        private void FillTitleComboBox()
        {
            string query = "SELECT * FROM books ORDER BY name;";

            using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    conn.Open();

                    using (MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader.GetString("name");
                            cbTitle.Items.Add(title); // Add each title name to the combo box
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
                        MessageBox.Show("New medium added to mediums");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new medium");
                    }
                }
                connection.Close();
            }
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string inputTitle = cbTitle.Text.Trim();
            string inputDate = tbDate.Text.Trim();
            string inputMedium = cbMedium.Text.Trim();
            string inputWho = cbWho.Text.Trim();

            if (inputWho == "Seth") { inputWho = "1"; }
            if (inputWho == "Em") { inputWho = "2"; }


            if (inputTitle == "" || inputDate == "" || inputMedium == "")
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
                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
                {
                    connection.Open();

                    string insertBooksSql = "INSERT INTO book_history (book_id, finished_date, user_id) VALUES ((SELECT id FROM books WHERE name = @name), @FinishDate, @Who);";

                    using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertBooksSql, connection))
                    {
                        command.Parameters.AddWithValue("@name", inputTitle);
                        command.Parameters.AddWithValue("@FinishDate", inputDate);
                        //command.Parameters.AddWithValue("@medium", inputMedium);
                        command.Parameters.AddWithValue("@Who", inputWho);



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

                    string insertBooksSql2 = "INSERT INTO book_medium_associations (history_id, medium_id) VALUES (LAST_INSERT_ID(),(SELECT id FROM mediums WHERE medium_name = @medium));";

                    using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertBooksSql2, connection))
                    {

                        command.Parameters.AddWithValue("@medium", inputMedium);

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


                    connection.Close();
                }

                //Clear out form for a second book
                cbTitle.Text = string.Empty;
                tbDate.Text = string.Empty;
                cbMedium.Text = string.Empty;
                cbWho.Text = string.Empty;
                //Medium Box Setup from database
                FillMediumListBox();
                //Series Box Setup from database
                FillTitleComboBox();



            }
        }
    }
}
