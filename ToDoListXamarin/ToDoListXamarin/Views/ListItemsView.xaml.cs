﻿using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoListXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListItemsView : ContentPage
    {
        public ListItemsView()
        {
            InitializeComponent();
        }

        private ObservableCollection<ToDoItem> ToDoItems { get; set; }

        private async void OnButton_Clicked(object sender, EventArgs e)
        {
            string uri = "http://10.130.54.140:5000/api/ShoppingListItems";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(uri);
            List<ToDoItem> myList = JsonConvert.DeserializeObject<List<ToDoItem>>(response);
            ToDoItems = new ObservableCollection<ToDoItem>(myList);
            ItemListView.ItemsSource = ToDoItems;
        }


        /*        private readonly HttpClient _client = new HttpClient();
                private const string url = "http://10.130.54.140:5000/api/ShoppingListItems";
                private ObservableCollection<ToDoItem> ToDoItems { get; set; }
                async override protected void OnAppearing()
                {
                    string responsecontent = await _client.GetStringAsync(url);
                    List<ToDoItem> myList = JsonConvert.DeserializeObject<List<ToDoItem>>(responsecontent);
                    ToDoItems = new ObservableCollection<ToDoItem>(myList);
                    ItemListView.ItemsSource = ToDoItems;
                    base.OnAppearing();
                }*/

    }
}