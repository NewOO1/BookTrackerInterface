using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace FunctionalityForms
{
    public partial class BooksReadThisYear : Form
    {
        private string cConnectionString;
        private string cNewCoverFileLocation;

        public BooksReadThisYear(string passedConnection, string passedCover)
        {
            InitializeComponent();

            this.cConnectionString = passedConnection;
            this.cNewCoverFileLocation = passedCover;

        }

        private void bTrigger_Click(object sender, EventArgs e)
        {
            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(cConnectionString))
            {
                connection.Open();

                // Insert into books table
                string insertBooksSql = @"SELECT b.name as Title, 
                                                 b.author as Author, 
                                                 b.series_name as SeriesName, 
                                                 b.book_number_in_series as BookNumber,
                                                 b.image_url as CoverFilepath,
                                                 h.finished_date as FinishedDate
                                         FROM books b
                                         JOIN book_history h ON b.id = h.book_id
                                         WHERE YEAR(h.finished_date) = YEAR(CURDATE())
                                         GROUP BY b.id, h.finished_date
                                         ORDER BY h.finished_date ASC
                                         LIMIT 1";

                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertBooksSql, connection))
                {
                    using(MySqlDataReader reader = command.ExecuteReader()) 
                    { 
                        while (reader.Read())
                        {
                            string title = reader["Title"].ToString();
                            string author = reader["Author"].ToString();
                            string series = reader["SeriesName"].ToString();
                            string num = reader["BookNumber"].ToString();
                            string coverFilePath = reader["CoverFilepath"].ToString();                         
                            string finishedDate = reader["FinishedDate"].ToString();
                            DateTime dateTime = DateTime.Parse(finishedDate); // Parse the string into a DateTime object
                            finishedDate = dateTime.ToShortDateString(); // Convert to short date string

                            //finishedDate = finishedDate.Substring(0, 10);

                            BookDataDisplay cBookDataDisplay = new BookDataDisplay(cNewCoverFileLocation,title, series,author,num,coverFilePath,finishedDate);
                            cBookDataDisplay.Location = new Point(50,50);
                            this.Controls.Add(cBookDataDisplay);


                        }
                    }
                }
            }
        }
    }
}
