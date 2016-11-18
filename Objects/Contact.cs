using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class contact
  {
    private string _name;
    private int _phoneNumber;
    private string _email;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact(string name, int phoneNumber, string email)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _email = email;
      _id = instances.Count;
      _instances.Add(this);
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(int newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }
    public string GetEmail()
    {
      return _email;
    }
    public void SetEmail(string newEmail)
    {
      _email = newEmail;
    }
    public int GetId()
    {
      return _id;
    }
  }
}
