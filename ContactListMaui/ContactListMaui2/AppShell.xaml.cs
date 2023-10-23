using ContactListMaui2.MVVM.Views;

namespace ContactListMaui2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
            Routing.RegisterRoute(nameof(AddPage), typeof(AddPage));
            Routing.RegisterRoute(nameof(EditPage), typeof(EditPage));
        }
    }
}