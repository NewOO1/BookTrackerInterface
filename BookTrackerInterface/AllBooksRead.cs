using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FunctionalityForms
{
    public partial class AllBooksRead : Form
    {
        private string cConnectionString;
        private string cNewCoverFileLocation;

        private const int MinColumnWidth = 196;

        List<BookInfo> books = new List<BookInfo>();

        public AllBooksRead(string passedConnection, string passedCover)
        {
            InitializeComponent();

            this.cConnectionString = passedConnection;
            this.cNewCoverFileLocation = passedCover;

            GetBooks();

            // Initialize with the current form size
            AdjustColumnCount(tlp);


            // Handle the Resize event to adjust the column count when the form size changes
            this.Resize += (sender, e) => AdjustColumnCount(tlp);

            //tbTotal.Text = tlp.Controls.Count;

        }

        private void GetBooks()
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
                            var bookInfo = new BookInfo();

                            bookInfo.cTitle = reader["Title"].ToString();
                            bookInfo.cAuthor = reader["Author"].ToString();
                            bookInfo.cSeries = reader["SeriesName"].ToString();
                            bookInfo.cBookNumber = reader["BookNumber"].ToString();
                            bookInfo.cCoverPath = reader["CoverFilepath"].ToString();
                            string finishedDate = reader["FinishedDate"].ToString();
                            DateTime dateTime = DateTime.Parse(finishedDate); // Parse the string into a DateTime object
                            bookInfo.cFinishDate = dateTime.ToShortDateString(); // Convert to short date string

                            /*
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
                            */

                            //Add to list of type bookKInfo as a cache
                            books.Add(bookInfo);

                        }
                    }
                }
            }

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
                //FillOut(tpl);
            }
            FillOut(tpl);
        }

        private void FillOut(TableLayoutPanel tpl)
        {
            tpl.Controls.Clear();

            int numColumns = tpl.ColumnCount;
            int numRows = (books.Count + numColumns - 1) / numColumns;

            tpl.RowCount = numRows;

            for (int i = 0; i < books.Count; i++)
            {
                var bookInfo = books[i];

                // Create a new BookDataDisplay and set its properties based on the current BookInfo
                BookDataDisplay cBookDataDisplay = new BookDataDisplay(cNewCoverFileLocation, bookInfo.cTitle, bookInfo.cSeries, bookInfo.cAuthor, bookInfo.cBookNumber, bookInfo.cCoverPath, bookInfo.cFinishDate);


                // Calculate the row and column indices
                int row = i / numColumns;
                int column = i % numColumns;

                // Add the BookDataDisplay to the TableLayoutPanel
                tpl.Controls.Add(cBookDataDisplay, column, row);
            }

            tbTotal.Text = tlp.Controls.Count.ToString();
        }

        private void bTrigger_Click(object sender, EventArgs e)
        {
            tlp.Controls.Clear();
            GetBooks();
            AdjustColumnCount(tlp);
        }

    }
}
