using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookTrackerInterface
{
    public partial class MultiSelectComboBoxcs : UserControl
    {
        public MultiSelectComboBoxcs()
        {
            InitializeComponent();
            bookGenreBox.Click += bookGenreBox_Click;
            listBoxGenre.SelectedIndexChanged += listBoxGenre_SelectedIndexChanged;
        }

        private bool listBoxVisible = false;

        private void bookGenreBox_Click(object sender, EventArgs e)
        {
            listBoxVisible = !listBoxVisible;
            listBoxGenre.Visible = listBoxVisible;
        }

        private void listBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookGenreBox.Text = string.Join(", ", listBoxGenre.SelectedItems.Cast<string>());
        }
    }
}
