using ContactListMaui2.MVVM.Models;
using ContactListMaui2.MVVM.ViewModels;

namespace ContactListMaui2.MVVM.Views;

[QueryProperty(nameof(Contact), "Contact")]
public partial class EditPage : ContentPage
{

    private ContactModel contact;

    public ContactModel Contact
    {
        get => contact;
        set
        {
            contact = value;
            OnPropertyChanged();
            if (BindingContext is EditViewModel viewModel)
            {
                viewModel.Contact = contact;
            }
        }

    }
    public EditPage(EditViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}