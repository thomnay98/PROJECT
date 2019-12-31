using Xamarin.Forms;

namespace QLCT
{
    public class App : Application
    {
        private static DataService _dataService;

        public static DataService DataService => _dataService ?? (_dataService = new DataService());

        public App()
        {
            MainPage = new MasterDetail();
        }
    }
}
