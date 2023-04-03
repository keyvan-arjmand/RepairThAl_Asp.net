using DAL.Model;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Services
{
    public class Contact_Services
    {
        public void Insert(Contact contact)
        {
            DB db = new DB();
            db.contacts.Add(new Contact
            {
                ContactBody = contact.ContactBody,
                ContactNumber = contact.ContactNumber,
                ContactSubject = contact.ContactSubject,
                Name_Family = contact.Name_Family,
                Send_Date = Helpers.TimeUtility.ToJalali(DateTime.Now)
            });
            db.SaveChanges();
        }
        public void Update(Contact contact)
        {
            DB db = new DB();
            db.contacts.Update(contact);
            db.SaveChanges();
        }
        public void Delete(Contact contact)
        {
            DB db = new DB();
            db.contacts.Remove(contact);
            db.SaveChanges();
        }
        public List<Contact> GetContacts()
        {
            DB db = new DB();
            return db.contacts.ToList();
        }
        public Contact Get(int id)
        {
            DB db = new DB();
            return db.contacts.Find(id);
        }
        public int GetCount()
        {
            DB db = new DB();
            return db.contacts.Count();
        }

    }
}
