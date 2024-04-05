using System.Diagnostics;

namespace p0;

public class Controller{
    
 //Handles the logic of the application
public static void AddNewUser(List<Contact> contactList){
    Console.WriteLine("Creating a new contact...");
    Contact  newContact = Menu.getContactInformation(contactList);
    // Add the contact to the phonebook
    contactList.Add(newContact);
    Console.WriteLine($"Contact {newContact.GetName()} contact was added!");

    }


// Add logic what to remove
public static void RemoveExistingUser(List<Contact> contactList){
    Console.WriteLine("Type the name of the contact you want to delete");
   string contactName =  Menu.GetUsernameInput();
   bool found = false;
    foreach(Contact contact in contactList){
        if(contact.GetName().Equals(contactName)){
            found = true;
            contactList.Remove(contact);
            Console.WriteLine($"Contact {contactName} removed!");
            break;
        }
    }
    if(!found){
        Console.WriteLine($"Contact with name {contactName} does not exist.");
    }


}
// Add logic what to edit

public static void EditContact(List<Contact> contactList){
    //ask what user want to edit
    Console.WriteLine("Type contact name you want to edit");
   string contactName =  Menu.GetUsernameInput();
    bool found = false;
   foreach(Contact contact in contactList){

        if(contact.GetName().Equals(contactName)){
            found = true;
            Console.WriteLine("Follow the promt to change contact information");

            Contact editedContact = Menu.getContactInformation(contactList);
            contact.setName(editedContact.GetName());
            contact.setPhoneNumber(editedContact.getPhoneNumber());
            contact.setEmail(editedContact.getEmail());

            Console.WriteLine($"Old contact {contactName} was edited.");
 
            break;
        }
    }
    if(!found){
        
        Console.WriteLine($"Contact with name {contactName} does not exist.");

    }

    
}


public static void DisplayAllContacts(List<Contact> phonebook){
    Console.WriteLine("Your contact list:\n");
    if (phonebook.Count == 0){
        Console.WriteLine("There are no contacts in the phonebook");
        return;
    }
    foreach(Contact contact in phonebook){
        Console.WriteLine(contact.ToString());
    }
}

}