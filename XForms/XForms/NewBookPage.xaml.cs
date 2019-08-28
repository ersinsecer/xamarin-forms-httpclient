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
	public partial class NewBookPage : ContentPage
	{
        Ssrvices services;
        List<Author> items;
        public NewBookPage ()
		{
			InitializeComponent ();
            services = new Ssrvices();
            GetAuthorList();

        }

        async void GetAuthorList()
        {
            items = await services.GetAuthorListAsync();
            AuthorName.ItemsSource = items.ToList();
        }

        private void btnKaydet_Clicked(object sender, EventArgs e)
        {
            Book book = new Book
            {
                BookTitle = txtBookName.Text,
                Publisher = txtPublisher.Text,
                Price = float.Parse(txtPrice.Text),
                Genre = txtGenre.Text,
                AuthorId = ((Author)AuthorName.SelectedItem).Id
            };

            var sonuc =  services.AddBook(book);           
        }
    }
}