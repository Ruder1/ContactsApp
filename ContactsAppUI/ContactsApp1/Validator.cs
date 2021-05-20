using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    public static class Validator
    {
       /// <summary>
       /// Проверка записи строк
       /// </summary>
       /// <param name="value"></param>
        public static void ContactValidator(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Вы ввели пустую строку.");
            }

            if (value.Length > 50)
            {
                throw new ArgumentException("Длина имени, фамилии и e-mail" +
                                            " должно быть меньше 50 символов.");
            }
        }
    }
}

