using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoListXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAddItem(object sender, System.EventArgs e)
        {

            await Shell.Current.GoToAsync(nameof(CreateShoppingList));
            //Application.Current.MainPage = new NavigationPage(new ListCreate());
        }
    }
}
