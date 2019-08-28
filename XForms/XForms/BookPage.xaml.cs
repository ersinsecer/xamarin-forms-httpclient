using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XForms.Models;
using XForms.Services;

namespace XForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookPage : ContentPage
	{
        Ssrvices services;
        List<Book> items;
        public BookPage ()
		{
			InitializeComponent ();
            services = new Ssrvices();
            RefreshData();
        }

        async void RefreshData()
        {
            items = await services.GetBookListAsync();
            lwBookList.ItemsSource = items.ToList();
            lwBookList.IsRefreshing = false;
        }

        private async void MenuItem1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewBookPage());
        }
    }
}