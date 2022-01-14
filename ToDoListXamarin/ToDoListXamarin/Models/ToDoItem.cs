using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListXamarin
{
    public class ToDoItem
    {
        [JsonProperty("id")]
        public int ToDoId { get; set; }
        [JsonProperty("shoppinglistid")]
        public int ShoppingListId { get; set; }
        [JsonProperty("title")]
        public string TodoText { get; set; }
        [JsonProperty("complete")]
        public bool Complete { get; set; }

        public ToDoItem(int toDoId, string todoText, bool complete, int shoppingListId)
        {
            ToDoId = toDoId;
            TodoText = todoText;
            Complete = complete;
            ShoppingListId = shoppingListId;
        }
    }
}
