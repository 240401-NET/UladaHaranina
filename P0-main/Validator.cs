using p0;

public class Validator
{
    public static string validateName(string name, List<Contact> contactList){
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

    public static string valideEmail(string email){
          if(!email.Contains("@") || email.Equals("")){
            return "Invalid email";
        }
            return "";
    }

    public static string validatePhone(string phonenumber){
        if(phonenumber.Equals("") || phonenumber.Length < 10){
         return "Invalid phone number";
        }
        return "";
    }

}