using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
namespace Nutricion
{
    public partial class App : Application
    {
        public static Repository IMCrepository { get; set; }
        public App(Repository repository)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AppShell());
            
           AppCenter.Start("android=26be5785-baf1-4b08-970c-0befaa8e43ce;" +
                  "uwp=26be5785-baf1-4b08-970c-0befaa8e43ce;" +
                  "ios={Your iOS App secret here};" +
                  "macos={Your macOS App secret here};",
                  typeof(Analytics), typeof(Crashes));
            IMCrepository = repository;
        }
    }
}