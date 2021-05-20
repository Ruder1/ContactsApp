using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    public class PhoneNumber
    {
        /// <summary>
        /// Присваивает номер телефона
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Присваивает номер телефона
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
                        throw new ArgumentException("Строка должна содержать только цифры");
                    }
                }

                if (value.Length != 11)
                {
                    throw new ArgumentException("Номер должен состоять ровно из 11 цифр");
                }

                if (value[0] != '7')
                {
                    throw new ArgumentException("Код страны должен равнятся 7");
                }
                _phoneNumber = value;
            }
        }

    }
}
