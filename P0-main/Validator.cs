public class Validator
{
    public static string validateName(string name){
        if(name.Equals("") || name.Equals(null)){
            return "Name can't be blank!";
        }
        else{
            return "";
        }
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