using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoListXamarin
{
    public class ShoppingTodoListViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public ShoppingTodoListViewModel()
        {
            ToDoItems = new ObservableCollection<ToDoItem>();

            ToDoItems.Add(new ToDoItem("todo 1", false));
            ToDoItems.Add(new ToDoItem("todo 2", false));
            ToDoItems.Add(new ToDoItem("todo 3", false));
        }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public string NewTodoInputValue { get; set; }

        void AddTodoItem()
        {
            ToDoItems.Add(new ToDoItem(NewTodoInputValue, false));
        }
    }
}
