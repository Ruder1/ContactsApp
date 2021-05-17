using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    public class PhoneNumber
    {
        private static long _phoneNumber;
        /// <summary>
        /// Присваивает номер телефона
        /// </summary>
        public static long Number
        {
            get { return _phoneNumber; }

            set
            {

                if ((value >= 70000000000 && value <= 79999999999))
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Номер должен содержать 11 цифр, первая цифра должна быть 7");
                }
            }
        }

    }
}
