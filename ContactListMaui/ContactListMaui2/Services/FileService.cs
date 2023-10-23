

using ContactListMaui2.MVVM.Models;

namespace ContactListMaui2.Services;

public class FileService
{
   
    private static readonly string filePath = @"C:\Users\ewyro\Nackademin\ContactListMaui2\ContactList.json";

    public static void SaveToFile(string contentAsJson)  //Will convert list to json-format and save down to file
    {
        if (!File.Exists(filePath)) 
        {
            File.Create(filePath).Close();
        }
        using StreamWriter sw = new StreamWriter(filePath);
        sw.WriteLine(contentAsJson);
    }

    public static String ReadFromFile() //Will read the content of the file and convert from json-format to code
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
        
            using StreamReader sr = new StreamReader(filePath);
            return sr.ReadToEnd();
    }
    
}