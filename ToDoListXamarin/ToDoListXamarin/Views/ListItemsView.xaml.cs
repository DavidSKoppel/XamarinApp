using ToDoListXamarin.ViewModels;
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
            BindingContext = new ListItemViewModel();
        }


                private readonly HttpClient _client = new HttpClient();
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