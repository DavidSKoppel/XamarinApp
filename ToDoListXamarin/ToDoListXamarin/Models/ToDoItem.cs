using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListXamarin.Models
{
    public class ToDoItem
    {
        public int ToDoId { get; set; }
        public int ShoppingListId { get; set; }
        public string TodoText { get; set; }
        public bool Complete { get; set; }

        public ToDoItem(string todoText, bool complete)
        {
            TodoText = todoText;
            Complete = complete;
        }
    }
}
