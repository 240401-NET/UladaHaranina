using p0;

public interface IValidator
{
    string validateName(string name, List<Contact> contactList);
    string valideEmail(string email);
    string validatePhone(string phonenumber);
}