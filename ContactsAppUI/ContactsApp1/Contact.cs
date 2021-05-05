using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    public class Contact:PhoneNumber
    {
        private string _surename;
        private string _name;
        private string _email;
        private PhoneNumber _phoneNumber;
        private string _idVkontakte;
        private DateTime _birthDate;

        public string Surename
        {
            get { return _surename; }

            set
            {
                Validator.ContactValidator(value);
                value = char.ToUpper(value[0]) + value.Substring(1);
                _surename = value;
            }
        }

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

        public DateTime DateOfBirth
        {
            get
            {
                return _birthDate;
            }

            set
            {
                var date1 = new DateTime(1900, 01, 01);
                if (value > DateTime.Today || value < date1)
                {
                    throw new ArgumentException(
                        $"Дата рождения не должна быть раньше 01.01.1900 и позже " +
                        $"сегодня: -{DateTime.Today}");
                }

                _birthDate = value;
            }
        }

        public string Email
        {
            get { return _email; }

            set
            {
                Validator.ContactValidator(value);
                _email = value;
            }
        }

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

        public Contact(string surename, string name, string phoneNumber,
            DateTime dateOfBirth, string email, string idVkontake)
        {
            Surename = surename;
            Name = name;
            NumberPhone = phoneNumber;
            DateOfBirth = dateOfBirth;
            Email = email;
            IdVkontake = idVkontake;
        }
    }
}
