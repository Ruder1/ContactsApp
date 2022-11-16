using System;

namespace ContactsApp1
{

    /// <summary>
    /// Класс для проверки значений типа string
    /// </summary>
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
                throw new ArgumentException("You entered an empty string.");
            }

            if (value.Length > 50)
            {
                throw new ArgumentException("The length of the text highlighted in red must be less than 50 characters.");
            }
        }
    }
}

