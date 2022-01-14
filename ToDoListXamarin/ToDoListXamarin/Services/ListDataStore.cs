﻿using ShoppingList.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListXamarin.Services
{
    public class ListDataStore : IDataStore<ShoppingListAndItems>
    {
        public List<ShoppingListAndItems> lists;
        
        public ListDataStore() 
        {
            lists = new List<ShoppingListAndItems>();
            
            lists.Add(new ShoppingListAndItems(1, "Todo 1", Convert.ToDateTime("11-01-20")));
            lists.Add(new ShoppingListAndItems(2, "Todo 2", Convert.ToDateTime("12-01-20")));
            lists.Add(new ShoppingListAndItems(3, "Todo 3", Convert.ToDateTime("13-01-20")));
            lists.Add(new ShoppingListAndItems(4, "Todo 4", Convert.ToDateTime("14-01-20")));
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
