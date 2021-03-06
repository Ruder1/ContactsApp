using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    /// <summary>
    /// Класс создания контакта
    /// </summary>

    public class Contact : ICloneable
    {

        /// <summary>
        /// Поле фамилии
        /// </summary>
        private string _surname;

        /// <summary>
        /// Поле имени
        /// </summary>
        private string _name;

        /// <summary>
        /// Поле электроной почты
        /// </summary>
        private string _email;

        /// <summary>
        /// Поле индетефикатор вконтакте
        /// </summary>
        private string _idVkontakte;

        /// <summary>
        /// Поле дня рождения
        /// </summary>
        private DateTime _dateOfBirth;

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

                return _dateOfBirth;

            }

            set
            {
                var date1 = new DateTime(1900, 01, 01);

                if (value > DateTime.Today || value <= date1)
                {
                    throw new ArgumentException(
                        $"Дата рождения не должна быть раньше 01.01.1900 и позже " +
                        $"сегодня: -{DateTime.Today}");
                }

                _dateOfBirth = value;
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

        /// <param name="surname">Фамилия</param>
        /// <param name="name">Имя</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="dateOfBirth">Дата рождения</param>
        /// <param name="email">Эл Почта</param>
        /// <param name="idVkontake">ID Вконтакте</param>
        public Contact(string surname, string name, string phoneNumber,
            DateTime dateOfBirth, string email, string idVkontakte)

        {
            Surname = surname;
            Name = name;
            PhoneNumber.NumberPhone= phoneNumber;

            DateOfBirth = dateOfBirth;
            Email = email;
            IdVkontake = idVkontakte;
        }
        /// <summary>
        /// Чтение и запись номера телефона
        /// </summary>

        public PhoneNumber PhoneNumber = new PhoneNumber();

        public Contact()
        {
        }

        /// <summary>
        /// Клонирование объекта контакт
        /// </summary>
        /// <returns></returns>

        public object Clone()
        {
            return new Contact(Surname, Name, PhoneNumber.NumberPhone, DateOfBirth, Email, IdVkontake);
        }
    }
}
