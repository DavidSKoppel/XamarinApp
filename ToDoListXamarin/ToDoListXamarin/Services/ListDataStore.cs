using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ToDoListXamarin.Models;

namespace ToDoListXamarin.Services
{
    public class ListDataStore : IDataStore<ShoppingListAndItems>
    {
        public List<ShoppingListAndItems> lists { get; set; }
        
        public ListDataStore() 
        {
            lists = new List<ShoppingListAndItems>();
            ShowShoppingList();
        }

        public async void ShowShoppingList()
            {
            string uri = "http://10.130.54.140:5000/api/ShoppingLists";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(uri);
            lists = JsonConvert.DeserializeObject<List<ShoppingListAndItems>>(response);
        }

        public async Task<bool> AddItemAsync(ShoppingListAndItems item)
        {
            lists.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = lists.Where((ShoppingListAndItems arg) => arg.Id == id).FirstOrDefault();
            lists.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ShoppingListAndItems> GetItemAsync(int id)
        {
            return await Task.FromResult(lists.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ShoppingListAndItems>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(lists);
        }

        public async Task<bool> UpdateItemAsync(ShoppingListAndItems item)
        {
            var oldItem = lists.Where((ShoppingListAndItems arg) => arg.Id == item.Id).FirstOrDefault();
            lists.Remove(oldItem);
            lists.Add(item);

            return await Task.FromResult(true);
        }
    }
}
