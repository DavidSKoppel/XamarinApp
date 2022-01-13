using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoListXamarin.ViewModels
{
    public class ListItemViewModel
    {
/*        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        private readonly HttpClient _client = new HttpClient();
        private const string url = "http://10.130.54.140:5000/api/ShoppingListItems";

        public ListItemViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();
            ToDoItems.Add(new ToDoItem("todo 1", false));
            ToDoItems.Add(new ToDoItem("todo 2", false));
            ToDoItems.Add(new ToDoItem("todo 3", false));
        }

        public async void OnAppearing()
        {
            string responsecontent = await _client.GetStringAsync(url);
            List<ToDoItem> myList = JsonConvert.DeserializeObject<List<ToDoItem>>(responsecontent);
            ToDoItems = new ObservableCollection<ToDoItem>(myList);
            ItemListView.ItemSource = ToDoItems;
            base.OnAppearing();
        }*/

    }
}
