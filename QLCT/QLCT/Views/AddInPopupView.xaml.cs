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
	public partial class AddInPopupView
	{
		public AddInPopupView ()
		{
			InitializeComponent ();
		}

        private void TaskEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TaskEntry.Text))
                AddTypeIn.IsEnabled = true;
            else if (string.IsNullOrEmpty(TaskEntry.Text))
                AddTypeIn.IsEnabled = false;
        }

        private async void AddTypeIn_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.PopAsync();
        }
    }
}