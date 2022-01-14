using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using ToDoListXamarin;

namespace ToDoListXamarin
{
    public class ShoppingTodoListViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public ShoppingTodoListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();

            ToDoItems.Add(new ToDoItem(1, "Cheese", false, 1));
        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public ICommand SaveCommand => new Command(SaveListCommand);
        public string NewListTitle { get; set; }
        public DateTime SelectedListDate { get; set; }
        public string NewTodoInputValue { get; set; }
        void AddTodoItem()
        {
            ToDoItems.Add(new ToDoItem(1, NewTodoInputValue, false, 1));
        }

        void SaveListCommand()
        {
            //ShoppingLists.Add(new ShoppingListAndItems(1, NewListTitle, SelectedListDate));
        }
    }
}
