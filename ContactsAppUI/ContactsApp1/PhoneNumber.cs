using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    /// <summary>
    /// Класс создания номера телефона
    /// </summary>
    public class PhoneNumber
    {

        /// <summary>
        /// Поле номер телефона
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Чтение и запись номера телефона
        /// </summary>
        public string NumberPhone
        {
            get { return _phoneNumber; }

            set
            {

                foreach (var var in value)
                {

                    if (!char.IsDigit(var))
                    {
                        throw new ArgumentException("The string must contain only numbers");
                    }
                }

                if (value.Length != 11)
                {
                    throw new ArgumentException("The number must consist of exactly 11 digits");
                }

                if (value[0] != '7')
                {
                    throw new ArgumentException("The country code must be 7");
                }
                _phoneNumber = value;
            }
        }

    }
}
