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
        return View["index.cshtml"];
      };
      Get["/contact"] = _ => {
        var allContacts = Contact.GetAll();
        return View["index.cshtml", allContacts];
      };
      Get["/contact/new"] = _ => {
        return View["contact_form.cshtml"];
      };
      Post["/contact"] = _ => {
        var newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone"], Request.Form["contact-email"]);
        var newContact = Contact.GetAll();
        return View["new_contact.cshtml", newContact];
      };
    }
  }
}
