using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    public class Project
    {
        /// <summary>
        /// Создает поле которое зранит список контактов
        /// </summary>
        public List<Contact> ContactLists { get; set; } = new List<Contact>();

        public List<string> SearchBirthdayContacts()
        {
            var birthdayContacts = new List<string>();
                foreach(var contact in ContactLists)
                {
                    if (contact.DateOfBirth.Month == DateTime.Today.Month &&
                        contact.DateOfBirth.Day == DateTime.Today.Day)
                    {
                        birthdayContacts.Add(contact.Name);
                    }
                }

                return birthdayContacts;
        }
    }
}
