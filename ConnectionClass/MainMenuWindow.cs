using BookTrackerInterface;
using FunctionalityForms;
using WeifenLuo.WinFormsUI.Docking;

namespace ConnectionClass
{
    public partial class MainMenuWindow : Form
    {
        public string cConnectionString = null;
        public string cCoverLocation = null;
        public string Name { get; set; }
        private DockPanel dockPanel;

        public AddNewBookForm cAddNewBookForm;

        public string cSQLQuery_AllBooksReadSeth = @"SELECT b.name as Title, 
                                                 b.author as Author, 
                                                 b.series_name as SeriesName, 
                                                 b.book_number_in_series as BookNumber,
                                                 b.image_url as CoverFilepath,
                                                 h.finished_date as FinishedDate,
                                                 h.user_id as Who
                                         FROM books b
                                         JOIN book_history h ON b.id = h.book_id
                                         WHERE h.user_id = 1
                                         GROUP BY b.id, h.finished_date
                                         ORDER BY h.finished_date ASC";

        public string cSQLQuery_BooksReadThisYearSeth = @"SELECT b.name as Title, 
                                                 b.author as Author, 
                                                 b.series_name as SeriesName, 
                                                 b.book_number_in_series as BookNumber,
                                                 b.image_url as CoverFilepath,
                                                 h.finished_date as FinishedDate,
                                                 h.user_id as Who
                                         FROM books b
                                         JOIN book_history h ON b.id = h.book_id
                                         WHERE YEAR(h.finished_date) = YEAR(CURDATE()) AND h.user_id = 1
                                         GROUP BY b.id, h.finished_date
                                         ORDER BY h.finished_date ASC";

        public string cSQLQuery_AllBooksReadEm = @"SELECT b.name as Title, 
                                                 b.author as Author, 
                                                 b.series_name as SeriesName, 
                                                 b.book_number_in_series as BookNumber,
                                                 b.image_url as CoverFilepath,
                                                 h.finished_date as FinishedDate,
                                                 h.user_id as Who
                                         FROM books b
                                         JOIN book_history h ON b.id = h.book_id
                                         WHERE h.user_id = 2
                                         GROUP BY b.id, h.finished_date
                                         ORDER BY h.finished_date ASC";

        public string cSQLQuery_BooksReadThisYearEm = @"SELECT b.name as Title, 
                                                 b.author as Author, 
                                                 b.series_name as SeriesName, 
                                                 b.book_number_in_series as BookNumber,
                                                 b.image_url as CoverFilepath,
                                                 h.finished_date as FinishedDate,
                                                 h.user_id as Who
                                         FROM books b
                                         JOIN book_history h ON b.id = h.book_id
                                         WHERE YEAR(h.finished_date) = YEAR(CURDATE()) AND h.user_id = 2
                                         GROUP BY b.id, h.finished_date
                                         ORDER BY h.finished_date ASC";

        public MainMenuWindow()
        {
            InitializeComponent();
            this.dockPanel = new DockPanel();
            this.Controls.Add(this.dockPanel);
            //var theme = new ThemeVS2015();
            //this.dockPanel.Theme = theme;

            Text = "Book Tracker Hub";

            this.dockPanel.Dock = DockStyle.Fill;
        }




        public void Initialize()
        {
            //cAddNewComplBookForm = new AddNewComplBookForm();
            //cAddNewComplBookForm.Visible = true;
            //cAddNewComplBookForm.Show(dockPanel, DockState.DockLeft);
            //throw new NotImplementedException();
        }

        private void bAddNewBook_Click(object sender, EventArgs e)
        {
            AddNewBookForm cAddNewComplBookForm = new AddNewBookForm(cConnectionString, cCoverLocation);
            cAddNewComplBookForm.Show();
        }

        private void bUpdateCover_Click(object sender, EventArgs e)
        {
            UpdateCoversForm cUpdateCoversForm = new UpdateCoversForm(cConnectionString, cCoverLocation);
            cUpdateCoversForm.Show();
        }

        private void bAddNewCompletion_Click(object sender, EventArgs e)
        {
            AddNewCompletionForm cAddNewCompletionForm = new AddNewCompletionForm(cConnectionString);
            cAddNewCompletionForm.Show();
        }

        private void bBooksReadThisYear_Click(object sender, EventArgs e)
        {
            TiledDisplay cBooksReadThisYear = new TiledDisplay(cConnectionString, cCoverLocation, cSQLQuery_BooksReadThisYearSeth);

            //BooksReadThisYear cBooksReadThisYear = new BooksReadThisYear(cConnectionString, cCoverLocation);
            cBooksReadThisYear.Show();
        }

        private void bAllBooks_Click(object sender, EventArgs e)
        {
            TiledDisplay cAllBooksRead = new TiledDisplay(cConnectionString, cCoverLocation, cSQLQuery_AllBooksReadSeth);

            //AllBooksRead cAllBooksRead = new AllBooksRead(cConnectionString, cCoverLocation);
            cAllBooksRead.Show();
        }

        private void bAllBooksEm_Click(object sender, EventArgs e)
        {
            TiledDisplay cAllBooksRead = new TiledDisplay(cConnectionString, cCoverLocation, cSQLQuery_AllBooksReadEm);

            //AllBooksRead cAllBooksRead = new AllBooksRead(cConnectionString, cCoverLocation);
            cAllBooksRead.Show();
        }

        private void bBooksReadThisYearEm_Click(object sender, EventArgs e)
        {
            TiledDisplay cBooksReadThisYear = new TiledDisplay(cConnectionString, cCoverLocation, cSQLQuery_BooksReadThisYearEm);

            //BooksReadThisYear cBooksReadThisYear = new BooksReadThisYear(cConnectionString, cCoverLocation);
            cBooksReadThisYear.Show();
        }
    }
}