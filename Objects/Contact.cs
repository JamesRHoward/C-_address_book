using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _email;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    public Contact (string name, string phoneNumber, string email)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _email = email;
      _id = _instances.Count;
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
    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }
    public void SetPhoneNumber(string newPhoneNumber)
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
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}
