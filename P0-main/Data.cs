using System.Text.Json;

namespace p0;
class Data
{
    //Handle serialization

    public static void Serialize(List<Contact> phonebook)
    {   
        try{
            string file = "phonebook.json";
            // Create a new JSON serializer
            string jsonString = JsonSerializer.Serialize(phonebook);
            File.WriteAllText(file, jsonString);
        }
        catch(Exception e){
            Console.WriteLine("Something went wrong");

        }


    }

    public static void Deserialize(ref List<Contact> phonebook){


        try{
            string file = "phonebook.json";
            string jsonString = File.ReadAllText(file);
            phonebook = JsonSerializer.Deserialize<List<Contact>>(jsonString);
        }

        catch(IOException e){
            Console.WriteLine("First execution.");
        }
        
    }
}