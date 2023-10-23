using ContactListMaui2.MVVM.Models;
using ContactListMaui2.MVVM.ViewModels;

namespace ContactListMaui2.MVVM.Views;

[QueryProperty(nameof(Contact), "Contact")]
public partial class DetailPage : ContentPage


{
    private ContactModel contact;

    public ContactModel Contact
    {
        get => contact;
        set
        {
            contact = value;
            OnPropertyChanged();
        if (BindingContext is DetailViewModel viewModel)
            {
                viewModel.Contact = contact;
            }
        }
       
    }
    public DetailPage(DetailViewModel viewModel)
    {
        InitializeComponent();
        viewModel.Contact = contact;
        BindingContext = viewModel;
    }
}

 


