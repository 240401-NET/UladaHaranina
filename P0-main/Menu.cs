using System.Runtime.InteropServices;

namespace p0;

/**
Class handles the console interaction with the user.
**/
public class Menu
{
    private readonly IValidator _validator;

    public Menu(IValidator validator) {
        _validator = validator;
    }
    //Disaplay the menu
    public void Greeting(){
        Console.WriteLine("Welcome to the Phonebook!");
    }

    public void displayPhoneBookCreation(){

        Console.WriteLine("Creating a new phonebook...it might take a few seconds");
        Thread.Sleep(1000);
        Console.WriteLine("Almost there...");
        Thread.Sleep(2000);
        Console.WriteLine("Done!");
        Thread.Sleep(1000);


        Console.WriteLine("Your new phone book has been created!");
        Thread.Sleep(1000);
        displayMenu();
    }

    public void displayMenu(){

        Console.WriteLine("\nSelect one of the following options:");
        Console.WriteLine("1. Add a new contact.");
        Console.WriteLine("2. Edit a contact.");
        Console.WriteLine("3. Remove existing contact.");
        Console.WriteLine("4. Display All Contacts");
        Console.WriteLine("9. Press 9 to exit"); 

    }


    // Get user input for a contact that supposed to be deleted or edited
    public string GetUsernameInput(){

        string contactName = Console.ReadLine();
        if(contactName.Equals("") || contactName == null){
            Console.WriteLine("Contact name can't be blank!");
            return GetUsernameInput();
        } 
        return contactName;

    }

    //Read user input and return it as a integer for selection menu
    public int getUserOption(){
        string userInput = Console.ReadLine();

        try{
            return Convert.ToInt32(userInput);
        }
        catch(Exception e){
            Console.WriteLine("Please enter a valid number.");
            return -1;
        }
       
    }

    //Get user information for a contact
    public Contact getContactInformation(List<Contact> contactList){
    
        // Get input from the user

    Console.WriteLine("Type name of the contact: ");
    string name = Console.ReadLine();
    while(!_validator.validateName(name, contactList).Equals("")){

        Console.WriteLine(_validator.validateName(name, contactList));      
        Console.WriteLine("Type name of the contact: ");
        name = Console.ReadLine();
    }

    Console.WriteLine("Type email of the contact: ");
    string email = Console.ReadLine();
        while(!_validator.valideEmail(email).Equals("")){
        Console.WriteLine(_validator.valideEmail(email));
        Console.WriteLine("Type email of the contact: ");
        email = Console.ReadLine();
    }
    
    Console.WriteLine("Type phone number of the contact: ");
    string phone_number = Console.ReadLine();
     while(!_validator.validatePhone(phone_number).Equals("")){
        Console.WriteLine(_validator.validatePhone(phone_number));
        Console.WriteLine("Type phone number of the contact: ");
        phone_number = Console.ReadLine();
    }
    Contact  newContact = new Contact(name, phone_number, email);

    return newContact;

    }

}