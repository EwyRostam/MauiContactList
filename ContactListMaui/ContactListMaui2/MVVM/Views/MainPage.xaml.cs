using ContactListMaui2.MVVM.ViewModels;

namespace ContactListMaui2
{
    public partial class MainPage : ContentPage
    {


        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }


    }
}