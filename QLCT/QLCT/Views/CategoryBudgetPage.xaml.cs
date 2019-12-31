using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QLCT
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategoryBudgetPage : ContentPage
	{
		public CategoryBudgetPage ()
		{
			InitializeComponent ();
		}

        protected override void OnSizeAllocated(double width, double height)
        {
            CategoryColumn.Width = width * 0.6;
            base.OnSizeAllocated(width, height);
        }
    }
}