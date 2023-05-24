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
    public partial class BookDataDisplay : UserControl
    {
        private string cNewCoverFileLocation;

        public BookDataDisplay(string passedCoverFileLocation, string title, string series, string author, string num, string coverfilePath, string datedone)
        {
            InitializeComponent();

            cNewCoverFileLocation = passedCoverFileLocation;

            tbAuthor.Text = author;
            tbNum.Text = num;
            tbSeries.Text = series;
            tbTitle.Text = title;
            coverfilePath = cNewCoverFileLocation + coverfilePath;
            pbCover.Image = Image.FromFile(coverfilePath);
            tbDate.Text = datedone;


        }
    }
}
