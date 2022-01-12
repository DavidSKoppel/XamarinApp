using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToDoListXamarin
{
    public class MainPageViewModel
    {
        public ObservableCollection<ShoppingList> ShoppingLists { get; set; }
        public MainPageViewModel()
        {
            ShoppingLists = new ObservableCollection<ShoppingList>();

            ShoppingLists.Add(new ShoppingList("Todo 1", "12-01-20", "Egg"));
            ShoppingLists.Add(new ShoppingList("Todo 2", "13-01-20", "Cheese"));
            ShoppingLists.Add(new ShoppingList("Todo 3", "14-01-20", "Bacon"));
        }
    }
}
