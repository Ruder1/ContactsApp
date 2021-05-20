using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    public class Project
    {
        private List<Contact> _contactLists;
        /// <summary>
        /// Список контактов запись и чтение
        /// </summary>
        public List<Contact> ContactLists
        {
            get { return _contactLists;}
            set
            {
                _contactLists = value;
            }
        }
        /// <summary>
        /// Добавление конкта в список
        /// </summary>
        /// <param name="contact"></param>
        public void AddContacts(Contact contact)
        {
            _contactLists.Add(contact);
        }

    }
}
