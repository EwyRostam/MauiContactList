

using ContactListMaui2.MVVM.Models;
using Newtonsoft.Json;

namespace ContactListMaui2.Services;

public class ContactService
{
    private static List<ContactModel> _contactList = new List<ContactModel>();
    public static event Action ContactsUpdated; //Sends notification that something has happend


    public static void AddContactToList(ContactModel contact) //Will add contact to list and call the function to save down list to file.
    {
        try
        {   
            var content = FileService.ReadFromFile();
            if (content != string.Empty) //If there is something on the list, get it first to not overwrite old list when saving down new one.
            _contactList = JsonConvert.DeserializeObject<List<ContactModel>>(content)!; 

            if (contact != null)
            {

                _contactList.Add(contact);

                FileService.SaveToFile(JsonConvert.SerializeObject(_contactList));
                ContactsUpdated.Invoke(); //Call function to notify that list has been updated
            }

        }
        catch { }
        
    }

    public List<ContactModel> GetContactsFromList()  //Will get list from file, convert and return list
    {
        var content = FileService.ReadFromFile();

        if (content != string.Empty)
        {
            _contactList = JsonConvert.DeserializeObject<List<ContactModel>>(content)!;
            if (_contactList != null!)
                return _contactList;
            else return null!;
        }

        else
        {
            return null!;
        }

    }

    public void RemoveContactFromList(ContactModel contact)  //Will delete contact from list and call function to save down changed list to file.
    {
        try
        {

            _contactList.Remove(contact);

            FileService.SaveToFile(JsonConvert.SerializeObject(_contactList));
            ContactsUpdated.Invoke();
        }
        catch { }
       
    }

    public static void UpdateContact() //Saves down updated list to file
    {
        FileService.SaveToFile(JsonConvert.SerializeObject(_contactList));
        ContactsUpdated.Invoke();

    }

}



