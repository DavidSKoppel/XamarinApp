using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoListXamarin.Models
{
    public class ShoppingList
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }

        public ShoppingList(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
