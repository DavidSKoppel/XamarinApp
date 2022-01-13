using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToDoListXamarin
{
    public class MainPageViewModel
    {
        public ObservableCollection<ShoppingListAndItems> ShoppingLists { get; set; }
        public MainPageViewModel()
        {
            ShoppingLists = new ObservableCollection<ShoppingListAndItems>();

            ShoppingLists.Add(new ShoppingListAndItems(1, "Todo 1", Convert.ToDateTime("12-01-20")));
            ShoppingLists.Add(new ShoppingListAndItems(2, "Todo 2", Convert.ToDateTime("12-01-20")));
            ShoppingLists.Add(new ShoppingListAndItems(3, "Todo 3", Convert.ToDateTime("12-01-20")));
        }
    }
}
