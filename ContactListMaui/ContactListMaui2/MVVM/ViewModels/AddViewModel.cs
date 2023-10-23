

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListMaui2.MVVM.Models;
using ContactListMaui2.Services;


namespace ContactListMaui2.MVVM.ViewModels;

public partial class AddViewModel : ObservableObject //Compatible with graphical interface. Raises notification when updated
{

    [ObservableProperty] //Observable copy of data from list. Will update when real data is updated.
    private string firstName;

    [ObservableProperty]
    private string lastName;

    [ObservableProperty]
    private string email;

    [ObservableProperty]
    private string phoneNumber;

    [ObservableProperty]
    private string street;

    [ObservableProperty]
    private string city;

    [ObservableProperty]
    private string postalCode;


    [RelayCommand]
    public async Task Save()
    {

        var contact = new ContactModel() //Sets the properties to the ObservableProperties, saves down to list and goes back to mainpage.
        {
            FirstName = FirstName,
            LastName = LastName,
            Email = Email, 
            PhoneNumber = PhoneNumber,
            Street = Street,
            City = City,
            PostalCode = PostalCode

        };

        ContactService.AddContactToList(contact);

        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    public async Task GoBack() //Goes back to mainpage
    {
        await Shell.Current.GoToAsync("..");
    }
}
