using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoListXamarin
{
    public class ToDoListViewModel
    {
        public ObservableCollection<ToDoItem> ToDoItems { get; set; }
        public ToDoListViewModel()
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
