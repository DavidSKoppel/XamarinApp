using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ToDoListXamarin;
using ToDoListXamarin.Models;

namespace ToDoListXamarin.ViewModels
{
    public class ShoppingTodoListViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public ShoppingTodoListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();

            ToDoItems.Add(new ToDoItem("Cheese", false));
        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public ICommand SaveCommand => new Command(SaveListCommand);
        public string NewListTitle { get; set; }
        public DateTime SelectedListDate { get; set; }
        public string NewTodoInputValue { get; set; }
        void AddTodoItem()
        {
            ToDoItems.Add(new ToDoItem(NewTodoInputValue, false));
        }

        void SaveListCommand()
        {
            //ShoppingLists.Add(new ShoppingListAndItems(1, NewListTitle, SelectedListDate));
        }
    }
}
