using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QLCT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail
    {
        public MasterDetail()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.macOS)
                MasterBehavior = MasterBehavior.Split;
            else
            {
                navigationPage.BarBackgroundColor = Color.FromHex("#3F539F");
                navigationPage.BarTextColor = Color.White;
            }
        }

        public static implicit operator MasterPage(MasterDetail v)
        {
            throw new NotImplementedException();
        }
    }
}