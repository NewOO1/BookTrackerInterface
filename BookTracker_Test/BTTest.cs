using System.Windows.Forms;
using BookTrackerInterface;
using ConnectionClass;

namespace BookTracker_Test
{
    public partial class BTTest : ConnectionClass.MainMenuWindow
    {
        public BTTest()
        {
            InitializeComponent();
            //For Production
            cConnectionString = "";
            cCoverLocation = "";

            Initialize();
        }


    }
}