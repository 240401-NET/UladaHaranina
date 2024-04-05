using p0;

public class Validator : IValidator
{
    public string validateName(string name, List<Contact> contactList){
        if(name.Equals("") || name.Equals(null)){
            return "Name can't be blank!";
        }
        foreach(Contact contact in contactList){
            if(contact.GetName().Equals(name)){
                return "Name already exists!";
            }
        }
            return "";
    }

    public string valideEmail(string email){
          if(!email.Contains("@") || email.Equals("")){
            return "Invalid email";
        }
            return "";
    }

    public string validatePhone(string phonenumber){
        if(phonenumber.Equals("") || phonenumber.Length < 10){
         return "Invalid phone number";
        }
        return "";
    }

}