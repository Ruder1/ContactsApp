using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    /// <summary>
    /// Класс для создания списка контактов
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Создает поле которое зранит список контактов
        /// </summary>
        public List<Contact> ContactLists { get; set; } = new List<Contact>();

        /// <summary>
        /// Поиск контактов у которых сегодня день рождение
        /// </summary>
        /// <returns>Возвращает список имен контактов</returns>
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
