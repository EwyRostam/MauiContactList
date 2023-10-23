

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListMaui2.MVVM.Models;
using ContactListMaui2.Services;

namespace ContactListMaui2.MVVM.ViewModels;

public partial class EditViewModel : ObservableObject
{

    [ObservableProperty]
    ContactModel contact = new ContactModel(); //The contact from detailpage

    [RelayCommand]
    public async Task Save() //Updates list with new properties of the contact and goes back to mainpage
    {
        ContactService.UpdateContact();

        await Shell.Current.GoToAsync("../..");
    }


    [RelayCommand]
    public async Task GoBack() //Goes back to mainpage
    {
        await Shell.Current.GoToAsync(".."); 
    }
}
