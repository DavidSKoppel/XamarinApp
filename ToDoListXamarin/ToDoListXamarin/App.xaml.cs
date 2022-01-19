﻿using System;
using ToDoListXamarin.Services;
using ToDoListXamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoListXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<ListDataStore>();
            //MainPage = new ListItemsView();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
