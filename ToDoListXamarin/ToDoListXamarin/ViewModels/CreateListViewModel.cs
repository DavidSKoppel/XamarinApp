using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ToDoListXamarin;
using ToDoListXamarin.Models;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Ubiety.Dns.Core;

namespace ToDoListXamarin.ViewModels
{
    public class CreateListViewModel : BaseViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public CreateListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();
            ToDoItems.Add(new ToDoItem("Cheese", false, 1));

            SaveCommand = new Command(SaveListCommandAsync);
            AddTodoCommand = new Command(AddTodoItem);
        }

        public Command SaveCommand { get; }
        public Command AddTodoCommand { get; }
        public string NewListTitle { get; set; }
        public DateTime SelectedListDate { get; }
        public string NewTodoInputValue { get; set; }
        public void AddTodoItem()
        {
            ToDoItems.Add(new ToDoItem(NewTodoInputValue, false, 1));
        }

        public async void SaveListCommandAsync()
        {
/*            List<ShoppingListAndItems> templist = new List<ShoppingListAndItems>(await DataStore.GetItemsAsync());
            int newId = 0;
            foreach(var numlist in templist) 
            {
                if (numlist.Id > newId)
                    newId = numlist.Id;
            }*/
            ShoppingListAndItems list = new ShoppingListAndItems()
            {
                Title = NewListTitle,
                ShoppingDate = SelectedListDate,
                //ShoppingItems = ToDoItems
            };

            string url = "http://10.130.54.140:5000/api/ShoppingLists";
            HttpClient client = new HttpClient();
            string jsonData = JsonConvert.SerializeObject(list);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);
            string result = await response.Content.ReadAsStringAsync();
            Response responseData = JsonConvert.DeserializeObject<Response>(result);
            await Task.Delay(2000);
            await DataStore.AddItemAsync(list);

            await Shell.Current.GoToAsync("..");
        }
    }
}
