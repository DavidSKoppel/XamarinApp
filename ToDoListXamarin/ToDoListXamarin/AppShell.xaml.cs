using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListXamarin;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoListXamarin
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ListCreate), typeof(ListCreate));
            //Routing.RegisterRoute(nameof(ViewList), typeof(ViewList));
        }
    }
}