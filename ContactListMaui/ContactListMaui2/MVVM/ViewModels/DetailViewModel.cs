

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListMaui2.MVVM.Models;
using ContactListMaui2.MVVM.Views;

namespace ContactListMaui2.MVVM.ViewModels;

public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty] //The contact that is shown on the detailpage
    ContactModel contact = new ContactModel();

    [RelayCommand]
    public async Task GoBack()
    {
        await Shell.Current.GoToAsync(".."); //Goes back to mainpage
    }

    [RelayCommand]
    async Task GoToEdit(ContactModel contact) //Goes to editpage and brings the contact
    {
        await Shell.Current.GoToAsync(nameof(EditPage), new Dictionary<string, object>
            {
                {"Contact", Contact }
            });
    }
}
