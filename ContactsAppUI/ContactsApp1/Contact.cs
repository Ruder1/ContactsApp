using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    public class Contact:PhoneNumber
    {
        private string _surname;
        private string _name;
        private string _email;
        private PhoneNumber _phoneNumber;
        private string _idVkontakte;
        private DateTime _birthDate;
            /// <summary>
            /// Чтение и запись Фамилии
            /// </summary>
        public string Surname
        {
            get { return _surname; }

            set
            {
                Validator.ContactValidator(value);
                value = char.ToUpper(value[0]) + value.Substring(1);
                _surname = value;
            }
        }
            /// <summary>
            /// Чтение и запись Имени
            /// </summary>
        public string Name
        {
            get { return _name; }

            set
            {
                Validator.ContactValidator(value);
                value = char.ToUpper(value[0]) + value.Substring(1);
                _name = value;
            }
        }
        /// <summary>
        ///  Чтение и запись Дня рождения
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _birthDate;
            }

            set
            {
                var date1 = new DateTime(1900, 01, 01);
                if (value > DateTime.Now || value < date1)
                {
                    throw new ArgumentException(
                        $"Дата рождения не должна быть раньше 01.01.1900 и позже " +
                        $"сегодня: -{DateTime.Now}");
                }

                _birthDate = value;
            }
        }

        /// <summary>
        /// Чтение и запись Email
        /// </summary>
        public string Email
        {
            get { return _email; }

            set
            {
                Validator.ContactValidator(value);
                _email = value;
            }
        }
        /// <summary>
        /// Чтение и запись IdVk
        /// </summary>
        public string IdVkontake
        {
            get { return _idVkontakte; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Вы ввели пустую строку.");
                }

                if (value.Length > 15)
                {
                    throw new ArgumentException("Длина id  должна быть меньше 15 символов.");
                }

                _idVkontakte = value;
            }
        }
        /// <summary>
        /// Конуструктор для класса Contact
        /// </summary>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="email"></param>
        /// <param name="idVkontake"></param>
        public Contact(string surname, string name, string phoneNumber,
            DateTime dateOfBirth, string email, string idVkontake)
        {
            Surname = surname;
            Name = name;
            NumberPhone = phoneNumber;
            DateOfBirth = dateOfBirth;
            Email = email;
            IdVkontake = idVkontake;
        }
    }
}
