﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw new ArgumentException("Вы ввели пустую строку.");
            }
            //TODO: Исправить общий вывод сделать только для 1
            if (value.Length > 50)
            {
                throw new ArgumentException("Длина выделенного красным текста должна быть меньше 50 символов.");
            }
        }
    }
}

