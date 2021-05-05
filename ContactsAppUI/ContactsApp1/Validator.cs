using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    /// <summary>
    /// Реазилуются проверки значений переменных на вход
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Метод для проверки введеных значений в PhoneNumber
        /// </summary>
        /// <param name="numberPhone"> Вводимый номер телефона </param>
        public static void ValidtationPhoneNumber(string numberPhone)
        {
            foreach (var value in numberPhone)
            {
                if (!char.IsDigit(value))
                {
                    throw new ArgumentException("Номер должен состоять из цифр");
                }
            }

            int count = 0;
            foreach (var value in numberPhone)
            {
                count++;
            }

            if (count > 11 || count < 11)
            {
                throw new ArgumentException("Номер телефона должен быть ровно из 11 цифр");
            }

            if (numberPhone[0] != '7')
            {
                throw new ArgumentException("Номер телефона должен начинаться с 7");
            }
        }

        public static void ValidationName(string name)
        {

        }
    }
}
