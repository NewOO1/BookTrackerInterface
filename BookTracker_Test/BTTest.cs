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
            cConnectionString = "server=192.168.1.53;port=3307;uid=BookTracker;pwd=0$c0edC7vsui6cSg;database=BookTrackerTest";
            cCoverLocation = "C:\\Users\\edens\\OneDrive\\Documents\\ProjectsHobbies\\BookTracker\\CoverImagesTest";

            Initialize();
        }


    }
}