using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QLCT.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IncomePage : ContentPage
	{
		public IncomePage ()
		{
			InitializeComponent ();
		}

        private void CmdAddIncome_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new AddInPopupView());
        }
    }
}