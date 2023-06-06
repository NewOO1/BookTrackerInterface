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
using MySqlX.XDevAPI.Relational;

namespace FunctionalityForms
{
    public partial class BooksReadThisYear : Form
    {
        private string cConnectionString;
        private string cNewCoverFileLocation;

        private const int MinColumnWidth = 196;

        public BooksReadThisYear(string passedConnection, string passedCover)
        {
            InitializeComponent();

            this.cConnectionString = passedConnection;
            this.cNewCoverFileLocation = passedCover;


            // Initialize with the current form size
            AdjustColumnCount(tlp);


            // Handle the Resize event to adjust the column count when the form size changes
            this.Resize += (sender, e) => AdjustColumnCount(tlp);

            //tbTotal.Text = tlp.Controls.Count;

        }

        private void FillOut()
        {
            //tpl.Controls.Clear();

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
                                         ORDER BY h.finished_date ASC";

                using (MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(insertBooksSql, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        int col = 0;
                        int row = 0;
                        int count = 0;

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

                            BookDataDisplay cBookDataDisplay = new BookDataDisplay(cNewCoverFileLocation, title, series, author, num, coverFilePath, finishedDate);

                            //finishedDate = finishedDate.Substring(0, 10);

                            if (col == 0)
                            {
                                // If it's the first column of a row, add a new row
                                tlp.RowCount++;
                                tlp.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                            }

                            tlp.Controls.Add(cBookDataDisplay, col, row);

                            // Increment column and check if it exceeds the column count
                            col++;
                            if (col >= tlp.ColumnCount)
                            {
                                col = 0; // Reset column
                                row++; // Move to next row
                            }

                            count++;




                            //tlp.Controls.Add(cBookDataDisplay, 0, currRow);
                            //cBookDataDisplay.Location = new Point(50, 50);
                            //this.Controls.Add(cBookDataDisplay);

                            //currCol++;
                            //currRow++;
                        }
                    }
                }
            }

            tbTotal.Text = tlp.Controls.Count.ToString();

        }

        private void AdjustColumnCount(TableLayoutPanel tpl)
        {
            int columnCount = this.ClientSize.Width / MinColumnWidth;
            columnCount = Math.Max(columnCount, 1);  // Ensure at least one column


            if (columnCount != tpl.ColumnCount)
            {

                tpl.ColumnCount = columnCount;
                tpl.ColumnStyles.Clear();

                for (int i = 0; i < columnCount; i++)
                {
                    tpl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columnCount));
                }
                tpl.Controls.Clear();
                FillOut();
            }
        }

        private void bTrigger_Click(object sender, EventArgs e)
        {
            tlp.Controls.Clear();
            FillOut();
        }
    }
}
