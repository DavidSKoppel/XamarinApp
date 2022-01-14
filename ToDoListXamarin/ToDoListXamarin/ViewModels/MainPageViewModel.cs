using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using ToDoListXamarin.Services;
using ShoppingList.Services;
using System.Threading.Tasks;

namespace ToDoListXamarin
{
    public class MainPageViewModel
    {
        public IDataStore<ShoppingListAndItems> DataStore => DependencyService.Get<IDataStore<ShoppingListAndItems>>();

        public ShoppingListAndItems selectedList;
        public bool IsBusy { get; set; }

        public ObservableCollection<ShoppingListAndItems> Lists { get;  }
        public Command LoadListsCommand { get; }
        public Command<ShoppingListAndItems> ItemTapped { get; }
        
        public MainPageViewModel()
        {
            Lists = new ObservableCollection<ShoppingListAndItems>();
            LoadListsCommand = new Command(async () => await LoadShoppingListsCommand());

            ItemTapped = new Command<ShoppingListAndItems>(OnItemSelected);
        }

        async Task LoadShoppingListsCommand()
        {
            IsBusy = true;

            Lists.Clear();
            var lists = await DataStore.GetItemsAsync(true);
            foreach (var list in lists)
            {
                Lists.Add(list);
            }
            IsBusy = false;
        }

        async void OnItemSelected(ShoppingListAndItems obj)
        {
            if (obj == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            //await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.ItemId)}={item.Id}");
        }
    }
}
