using System.Windows.Forms;
using BookTrackerInterface;
using ConnectionClass;

namespace BookTracker_Prod
{
    public partial class BTProd : MainMenuWindow
    {
        public BTProd()
        {
            InitializeComponent();
            //For Production
            cConnectionString = "";
            cCoverLocation = "";

            //Text = Text;

            Initialize();
        }


    }
}