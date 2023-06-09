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
            cConnectionString = "server=192.168.1.53;port=3307;uid=BookTracker;pwd=0$c0edC7vsui6cSg;database=BookTracker";
            cCoverLocation = "C:\\Users\\edens\\OneDrive\\Documents\\ProjectsHobbies\\BookTracker\\CoverImages\\";

            //Text = Text;

            Initialize();
        }


    }
}