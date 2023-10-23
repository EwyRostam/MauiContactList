using ContactListMaui2.MVVM.ViewModels;

namespace ContactListMaui2.MVVM.Views;

public partial class AddPage : ContentPage
{
	public AddPage(AddViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}