using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListXamarin
{
    public class ToDoItem
    {
        public string TodoText { get; set; }
        public bool Complete { get; set; }

        public ToDoItem(string todoText, bool complete)
        {
            TodoText = todoText;
            Complete = complete;
        }
    }
}
