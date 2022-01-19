using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListXamarin.Models
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

        public ToDoItem(string todoText, bool complete, int shoppingListId)
        {
            TodoText = todoText;
            Complete = complete;
            ShoppingListId = shoppingListId;
        }
    }
}
