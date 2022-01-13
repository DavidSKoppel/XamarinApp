using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToDoListXamarin
{
    class ShoppingListAndItems
    {
        public string Title { get; set; }
        public string ShoppingDate { get; set; }
        public ObservableCollection<ToDoItem> ShoppingItems { get; set; }

        public ShoppingListAndItems(string title, string shoppingDate, ObservableCollection<ToDoItem> shoppingItems)
        {
            Title = title;
            ShoppingDate = shoppingDate;
            ShoppingItems = shoppingItems;
        }
    }
}
