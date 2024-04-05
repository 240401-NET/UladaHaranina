namespace p0;
using System.Text.Json.Serialization;


public class Contact
{      
    [JsonInclude] // enable serialization for the field
    private string name;
    [JsonInclude]
    private string email;
    [JsonInclude]
    private string phoneNumber;


    public Contact() {}

    public Contact(string name, string phonenumber, string email){

        this.name = name;
        this.email = email;
        this.phoneNumber = phonenumber;
 
    }


    public string GetName(){
        return this.name;
    }

    public string getEmail(){
        return this.email;
    }

    public string getPhoneNumber(){
        return this.phoneNumber;
    }


    public void setName(string name){
      this.name = name;
    }

    // No email aalo
    public void setEmail(string email){
        this.email = email;
    }

    public void setPhoneNumber(string phonenumber){
       this.phoneNumber = phonenumber;
    }


    // Override Methods
    public override string ToString()
    {
        return $"Contact name: {this.name}, Phone number:  {this.phoneNumber}, Email: {this.email}";
    }
}