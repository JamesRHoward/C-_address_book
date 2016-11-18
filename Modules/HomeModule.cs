using Nancy;
using AddressBook.Objects;
using System.Collections.Generic;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["/contact"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contact"] = _ => {
        Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone"], Request.Form["contact-email"]);
        return View["contact_created.cshtml", newContact];
      };
      Get["/contact/{id}"] = parameters => {
        Contact myContact = Contact.Find(parameters.id);
        return View["contact.cshtml", myContact];
      };
      Post["/contacts/cleared"] = _ => {
        Contact.ClearAll();
        return View["contacts_cleared.cshtml"];
      };
    }
  }
}
