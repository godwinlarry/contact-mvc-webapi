using ContactsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApi.Repository
{
    public class ContactRepository:IContactRepository
    {
        static List<Contact> ContactList = new List<Contact>();
        public void Add(Contact item)
        {

        }

        public Contact Find(string key)
        {
            return ContactList
                .Where(item => item.MobilePhone.Equals(key))
                .SingleOrDefault();
        }

        public IEnumerable<Contact> GetAll()
        {
            return ContactList;
        }

        public void Remove(string Id)
        {
            var itemToRemove = ContactList.SingleOrDefault(item => item.MobilePhone == Id);
            if(itemToRemove != null)
            {
                ContactList.Remove(itemToRemove);
            }
        }

        public void Update(Contact item)
        {
            var itemToUpdate = ContactList.SingleOrDefault(r => r.MobilePhone == item.MobilePhone);
            if (itemToUpdate != null)
            {
                itemToUpdate.FirstName = item.FirstName;
                itemToUpdate.LastName = item.LastName;
                itemToUpdate.IsFamilyMember = item.IsFamilyMember;
                itemToUpdate.Company = item.Company;
                itemToUpdate.JobTitle = item.JobTitle;
                itemToUpdate.Email = item.Email;
                itemToUpdate.MobilePhone = item.MobilePhone;
                itemToUpdate.DateOfBirth = item.DateOfBirth;
                itemToUpdate.AnniversaryDate = item.AnniversaryDate;
            }
        }
    }
}
