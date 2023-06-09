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

        List<BookDataDisplay> books = new List<BookDataDisplay>();

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

                        while (reader.Read())
                        {
                            //Each iteration of the read stores the info into a single class of type bookInfo
                            string finishedDate = reader["FinishedDate"].ToString();
                            DateTime dateTime = DateTime.Parse(finishedDate); // Parse the string into a DateTime object

                            var bookCache = new BookDataDisplay(
                                cNewCoverFileLocation,
                                reader["Title"].ToString(),
                                reader["SeriesName"].ToString(),
                                reader["Author"].ToString(),
                                reader["BookNumber"].ToString(),
                                reader["CoverFilepath"].ToString(),
                                dateTime.ToShortDateString());


                            //Add to list of type bookKInfo as a cache
                            books.Add(bookCache);

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
                FillOut(tpl);
            }
            //FillOut(tpl);
        }

        private void FillOut(TableLayoutPanel tpl)
        {
            tpl.Controls.Clear();

            int numColumns = tpl.ColumnCount;
            int numRows = (books.Count + numColumns - 1) / numColumns;

            tpl.RowCount = numRows;

            for (int i = 0; i < books.Count; i++)
            {
                BookDataDisplay cBookDataDisplay = books[i];

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

        }

    }
}
