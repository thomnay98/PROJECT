using System;
using Rg.Plugins.Popup.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QLCT.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExpensePage : ContentPage
	{
		public ExpensePage ()
		{
			InitializeComponent ();
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.walletManager.GetTasksAsync();
        }

        async void OnAddItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddExPopupView(true)
            {
                BindingContext = new AddExPopupView
                {
                   _id = Guid.NewGuid().ToString()
                }
            });
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new AddExPopupView
            {
                BindingContext = e.SelectedItem as Wallet
            });
        }
    }
}