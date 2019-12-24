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
	public partial class AddExpensePage : ContentPage
	{
		public AddExpensePage ()
		{
			InitializeComponent ();
		}

        private void AddTypeExpense_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.PushAsync(new AddExPopupView());
        }
    }
}