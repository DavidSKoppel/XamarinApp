using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ToDoListXamarin;
using ToDoListXamarin.Models;
using System.Threading.Tasks;

namespace ToDoListXamarin.ViewModels
{
    public class CreateListViewModel : BaseViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public CreateListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();
            ToDoItems.Add(new ToDoItem(1, "Cheese", false, 1));

            SaveCommand = new Command(SaveListCommandAsync);
        }

        public Command SaveCommand { get; }
        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewListTitle { get; set; }
        public DateTime SelectedListDate { get; set; }
        public string NewTodoInputValue { get; set; }
        void AddTodoItem()
        {
            ToDoItems.Add(new ToDoItem(1, NewTodoInputValue, false, 1));
        }

        public async void SaveListCommandAsync()
        {
            List<ShoppingListAndItems> templist = new List<ShoppingListAndItems>(await DataStore.GetItemsAsync());
            int newId = 0;
            foreach(var numlist in templist) 
            {
                if (numlist.Id > newId)
                    newId = numlist.Id;
            }
            ShoppingListAndItems list = new ShoppingListAndItems()
            {
                Id = newId + 1,
                Title = NewListTitle,
                ShoppingDate = SelectedListDate,
            };
            await DataStore.AddItemAsync(list);

            await Shell.Current.GoToAsync("..");
            //ShoppingLists.Add(new ShoppingListAndItems(1, NewListTitle, SelectedListDate));
        }
    }
}
