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
        /// Создает поле которое хранит список контактов
        /// </summary>
        public List<Contact> ContactLists { get; set; } = new List<Contact>();

        /// <summary>
        /// Поиск контактов у которых сегодня день рождения
        /// </summary>
        /// <returns>Возвращает список фамилий</returns>
        public List<string> SearchBirthdayContacts()
        {
            var birthdayContacts = new List<string>();
                foreach(var contact in ContactLists)
                {
                    if (contact.DateOfBirth.Month == DateTime.Today.Month &&
                        contact.DateOfBirth.Day == DateTime.Today.Day)
                    {
                        birthdayContacts.Add(contact.Surname);
                    }
                }

                return birthdayContacts;
        }

        /// <summary>
        /// Метод выполняет сортировку списка контактов по фамилии
        /// </summary>
        /// <param name="contacts">Список контактов</param>
        /// <returns></returns>
        public List<Contact> SortProject()
        {
            List<Contact> sortedContacts = new List<Contact>();
            var result = ContactLists.OrderBy(contact => contact.Surname);
            foreach (var contact in result)
            {
                sortedContacts.Add(contact);
            }

            return sortedContacts;
        }

        /// <summary>
        /// Метод выполняет сортировку списка контактов по подстроке, сортировка по фамилии и по имени.
        /// </summary>
        /// <param name="substring">Подстрока для сортировки</param>
        /// <param name="contacts">Список контактов</param>
        /// <returns></returns>
        public List<Contact> SortProject(string substring)
        {
            List<Contact> sortedContacts = new List<Contact>();
            var result = from contact in ContactLists
                where contact.Surname.Contains(substring) || contact.Name.Contains(substring)
                orderby contact.Surname, contact.Name
                select contact;
            foreach (var contact in result)
            {
                sortedContacts.Add(contact);
            }

            return sortedContacts;
        }
    }
}
