using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ToDoListXamarin
{
    public class MainPageViewModel
    {
        public ShoppingListAndItems shoppingList;

        public Command<ShoppingListAndItems> ItemTapped { get; }
        public ObservableCollection<ShoppingListAndItems> ShoppingLists { get; set; }
        public MainPageViewModel()
        {
            ItemTapped = new Command<ShoppingListAndItems>(OnItemSeleceted);
            ShoppingLists = new ObservableCollection<ShoppingListAndItems>();

            ShoppingLists.Add(new ShoppingListAndItems(1, "Todo 1", Convert.ToDateTime("12-01-20")));
            ShoppingLists.Add(new ShoppingListAndItems(2, "Todo 2", Convert.ToDateTime("12-01-20")));
            ShoppingLists.Add(new ShoppingListAndItems(3, "Todo 3", Convert.ToDateTime("12-01-20")));
        }

        async void OnItemSeleceted(ShoppingListAndItems obj)
        {
            if (obj == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}
