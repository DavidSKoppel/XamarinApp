using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListXamarin
{
    public class ShoppingList
    {
        public string Title { get; set; }
        public string ShoppingDate { get; set; }
        public string ShoppingItems { get; set; }

        public ShoppingList(string title, string shoppingDate, string shoppingItems)
        {
            Title = title;
            ShoppingDate = shoppingDate;
            ShoppingItems = shoppingItems;
        }
    }
}
