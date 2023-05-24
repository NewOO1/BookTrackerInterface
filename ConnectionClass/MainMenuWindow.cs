using BookTrackerInterface;
using FunctionalityForms;
using WeifenLuo.WinFormsUI.Docking;

namespace ConnectionClass
{
    public partial class MainMenuWindow : Form
    {
        public string cConnectionString = null;
        public string cCoverLocation = null;

        private DockPanel dockPanel;

        public AddNewBookForm cAddNewBookForm;

        public MainMenuWindow()
        {
            InitializeComponent();
            this.dockPanel = new DockPanel();
            this.Controls.Add(this.dockPanel);
            //var theme = new ThemeVS2015();
            //this.dockPanel.Theme = theme;

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
            BooksReadThisYear cBooksReadThisYear = new BooksReadThisYear(cConnectionString, cCoverLocation);
            cBooksReadThisYear.Show();  
        }
    }
}