using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using ToDoListXamarin.Models;
using ToDoListXamarin.Services;

namespace ToDoListXamarin.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ShoppingListAndItems selectedList;

        public ObservableCollection<ShoppingListAndItems> Lists { get; }
        public Command LoadListsCommand { get; }
        public Command<ShoppingListAndItems> ItemTapped { get; }
        
        public MainPageViewModel()
        {
            Title = "Main";
            Lists = new ObservableCollection<ShoppingListAndItems>();
            LoadListsCommand = new Command(async () => await LoadShoppingListsCommand());

            ItemTapped = new Command<ShoppingListAndItems>(OnItemSelected);
        }

        async Task LoadShoppingListsCommand()
        {
            IsBusy = true;
            try
            {
                Lists.Clear();
                var lists = await DataStore.GetItemsAsync(true);
                foreach (var list in lists)
                {
                    Lists.Add(list);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public ShoppingListAndItems SelectedItem
        {
            get => selectedList;
            set
            {
                SetProperty(ref selectedList, value);
                OnItemSelected(value);
            }
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
