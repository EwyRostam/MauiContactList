

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ContactListMaui2.MVVM.Models;
using ContactListMaui2.MVVM.Views;
using ContactListMaui2.Services;
using System.Collections.ObjectModel;

namespace ContactListMaui2.MVVM.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly ContactService _contactService;

    [ObservableProperty]
    ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>(); //A list that we can see in the graphical interface


    public MainViewModel(ContactService contactService) //Activated from ContactsUpdated.Invoke. Gets contactlist and adds changes.
    {
        _contactService = contactService;
        GetContacts();

        ContactService.ContactsUpdated += GetContacts;
    }

    private void GetContacts()  //Gets contacts from list and adds them to the observable collection.
    {
        try
        {
            Contacts.Clear();


            if (_contactService.GetContactsFromList() != null!)
            {
                foreach (ContactModel contact in _contactService.GetContactsFromList())
                {
                    Contacts.Add(contact);
                }
            }
            
        } catch { }
       
            
    }

    [RelayCommand]
    public void Remove(ContactModel contact)
    {

       _contactService.RemoveContactFromList(contact);

     
    }



    [RelayCommand]
    async Task Detail(ContactModel contact) //Goes to deatilpage and brings the contact connected to the relaycommand.
    {
        await Shell.Current.GoToAsync(nameof(DetailPage), new Dictionary<string, object>
            {
                {"Contact", contact }
            });
    }

       

        [RelayCommand]
    async Task GoToAdd() //Goes to addpage
    {
        await Shell.Current.GoToAsync(nameof(AddPage));
    }
}


   
    
    
    
    
    
    
    
    
    
    
    
    