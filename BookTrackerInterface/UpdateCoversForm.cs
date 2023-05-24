using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionalityForms
{
    public partial class UpdateCoversForm : Form
    {
        private string cConnectionString;
        private string cNewCoverFileLocation;

        public UpdateCoversForm(string passedConnection, string passedCover)
        {
            InitializeComponent();

            this.cConnectionString = passedConnection;
            this.cNewCoverFileLocation = passedCover;

            //Title Box Setup from database
            FillTitleComboBox();
        }

        //####################################################################################
        //Queries the Titles table in database and fills out cbTitle 
        //####################################################################################
        private void FillTitleComboBox()
        {
            string query = "SELECT name FROM books WHERE image_url IS NULL OR image_url = '';";

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

        //Dialog box to get Cover image URL
        private void bCover_Click(object sender, EventArgs e)
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

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string inputTitle = cbTitle.Text.Trim();
            string inputCoverURL = tbCover.Text.Trim();
            DateTime now = DateTime.Now;

            if (inputTitle == "" || inputCoverURL == "")
            {
                //Cannot Submit because data is missing
                MessageBox.Show("Please Fill Out Required Fields");
            }
            else
            {
                //Good to Submit Cover 

                //Copy over Cover File, Rename and store URL for databse
                string newCoverFileName = string.Format("{0:yyyyMMddHHmmss}-{1}.jpg", now, Guid.NewGuid());
                string outputCoverURL = cNewCoverFileLocation + newCoverFileName;
                System.IO.File.Copy(inputCoverURL, outputCoverURL, true);
                System.IO.File.SetLastWriteTime(outputCoverURL, DateTime.Now);

                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
                {
                    connection.Open();

                    // Insert into books table
                    string insertBooksSql = "UPDATE books SET image_url = @ImageUrl WHERE name = @Title";

                    using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertBooksSql, connection))
                    {
                        command.Parameters.AddWithValue("@Title", inputTitle);
                        command.Parameters.AddWithValue("@ImageURL", newCoverFileName);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("Insert into books table successful.");
                        }
                        else
                        {
                            //Only show message box if issue
                            MessageBox.Show("Insert into books table failed.");
                        }
                    }

                    connection.Close();


                }

                //Reset Stuff (should functionalize through FunctionalityForms function
                cbTitle.Text = string.Empty;
                cbTitle.Items.Clear();
                tbCover.Text = string.Empty;
                pbCover.Image = null;
                FillTitleComboBox();
            }
        }
    }
}
