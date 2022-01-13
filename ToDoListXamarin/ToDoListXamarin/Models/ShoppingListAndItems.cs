using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToDoListXamarin
{
    public class ShoppingListAndItems
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ShoppingDate { get; set; }
        public ObservableCollection<ToDoItem> ShoppingItems { get; set; }

        public ShoppingListAndItems(int id, string title, DateTime shoppingDate)
        {
            Id = id;
            Title = title;
            ShoppingDate = shoppingDate;
        }
    }
}
