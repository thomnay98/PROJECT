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
	public partial class AddExPopupView
	{
        bool isNewWallet;
        internal string _id;

        public AddExPopupView (bool isNew = false)
		{
			InitializeComponent ();
            isNewWallet = isNew;
		}
        private void TaskEntry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TaskEntry.Text))
                AddTypeEx.IsEnabled = true;
            else if (string.IsNullOrEmpty(TaskEntry.Text))
                AddTypeEx.IsEnabled = false;
        }

        private async void AddTypeEx_Clicked(object sender, EventArgs e)
        {
            var todoItem = (Wallet)BindingContext;
            await App.walletManager.SaveTaskAsync(todoItem, isNewWallet);
            await Navigation.PopAsync();
        }
    }
}