using BookTrackerInterface;
using WeifenLuo.WinFormsUI.Docking;

namespace ConnectionClass
{
    public partial class MainMenuWindow : Form
    {
        public string cConnectionString = null;
        public string cCoverLocation = null;

        private DockPanel dockPanel;

        public AddNewComplBookForm cAddNewComplBookForm;

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
            AddNewComplBookForm cAddNewComplBookForm = new AddNewComplBookForm(cConnectionString, cCoverLocation);
            cAddNewComplBookForm.Show();
        }
    }
}