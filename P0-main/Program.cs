using System.Net.Http.Headers;

namespace p0;

class Program
{
    static void Main(string[] args)
    {   
        Validator validator = new();
        Menu menu = new Menu(validator);
        //Run the program
        menu.Greeting();

        //Create a new instance of the phonebook
        List<Contact> phonebook = new();
        Data.Deserialize(ref phonebook);

        //phonebook.Add(new Contact("Katherine", "919-123-4567", "kathy345@gmail.com"));
        menu.displayPhoneBookCreation();

        int selection = menu.getUserOption();

        while(selection != 9){

                switch(selection){
            case 1:
                Controller.AddNewUser(phonebook);
                break;
            case 2:
                Controller.EditContact(phonebook);
                break;
             case 3:
                Controller.RemoveExistingUser(phonebook);
                break;
             case 4:
                Controller.DisplayAllContacts(phonebook);
                break;
            default:
                Console.WriteLine("Invalid number");
                break;
        }
        menu.displayMenu();
        selection = menu.getUserOption();
        
    }
    Data.Serialize(phonebook);
    Console.WriteLine("Exiting the program..");


}}
