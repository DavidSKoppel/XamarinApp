using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ToDoListXamarin.Models;
using Xamarin.Forms;

namespace ToDoListXamarin
{
    public class MainPageViewModel
    {
        public List<ShoppingList> ShoppingList { get; set; } = new List<ShoppingList>();

        public Command<ShoppingListAndItems> ItemTapped { get; }
        public ObservableCollection<ShoppingList> ShoppingListItems { get; set; } = new ObservableCollection<ShoppingList>();

        /*        public ObservableCollection<ShoppingListAndItems> ShoppingLists { get; set; }
        */
        public MainPageViewModel()
        {
            ShowShoppingList();
            
/*            ItemTapped = new Command<ShoppingListAndItems>(OnItemSeleceted);
*//*            ShoppingLists = new ObservableCollection<ShoppingListAndItems>();
            
            ShoppingLists.Add(new ShoppingListAndItems(1, "Todo 1", Convert.ToDateTime("12-01-20")));
            ShoppingLists.Add(new ShoppingListAndItems(2, "Todo 2", Convert.ToDateTime("12-01-20")));
            ShoppingLists.Add(new ShoppingListAndItems(3, "Todo 3", Convert.ToDateTime("12-01-20")));*/
        }

/*        async void OnItemSeleceted(ShoppingListAndItems obj)
        {
            if (obj == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }*/

        

        public async void ShowShoppingList()
        {
            string uri = "http://10.130.54.140:5000/api/ShoppingLists";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(uri);
            List<ShoppingList> myList = JsonConvert.DeserializeObject<List<ShoppingList>>(response);
            foreach (ShoppingList v in myList)
            {
                ShoppingListItems.Add(new ShoppingList(v.Id, v.Title));
            }
        }
    }
}
