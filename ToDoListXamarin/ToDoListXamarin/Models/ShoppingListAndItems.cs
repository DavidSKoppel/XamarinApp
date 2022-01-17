using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ToDoListXamarin.Models
{
    public class ShoppingListAndItems
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ShoppingDate { get; set; }
        public ObservableCollection<ToDoItem> ShoppingItems { get; set; }

        public ShoppingListAndItems()
        {
        }
    }
}
