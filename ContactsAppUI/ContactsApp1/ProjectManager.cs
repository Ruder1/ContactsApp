using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ContactsApp1
{
    public static class ProjectManager
    {
        
        private const string FilePath = @"C:\Users\Ruder\Documents\Contacts app\ContactsApp.json";
        /// <summary>
        /// преобразования какого-либо объекта в поток байтов
        /// </summary>
        /// <param name="data">Данные контактов</param>
        /// <param name="filename">Имя файла</param>
        public static void SaveToFile(Contact data)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter streamwWriter = new StreamWriter(FilePath))
            using (JsonWriter writer = new JsonTextWriter(streamwWriter))
            {
                serializer.Serialize(writer, data);
            }
        }
        /// <summary>
        /// Получение из потока байтов ранее сохраненный файл
        /// </summary>
        /// <param name="filename"></param>
        /// <returns> Возвращает переменную содеражащую данные Contact</returns>
        public static Contact LoadFile()
        {
            Contact contact = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader streamReader = new StreamReader(FilePath))
            using (JsonReader reader = new JsonTextReader(streamReader))
            {
                contact = (Contact)serializer.Deserialize<Contact>(reader);

            }

            return contact;
        }
        
    }
}
