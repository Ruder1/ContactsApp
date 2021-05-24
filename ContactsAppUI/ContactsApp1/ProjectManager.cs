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


        public static string DefaultPath
        {
            get
            {
                var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var path = appDataFolder + @"\ContactsApp\contact.json";
                return path;
            }
        }
        /// <summary>
        /// преобразования какого-либо объекта в поток байтов
        /// </summary>
        /// <param name="data">Данные контактов</param>
        /// <param name="filePath">Расположение файла</param>
        public static void SaveToFile(Project data,string filePath)
        {
            var directoryFile = Path.GetDirectoryName(filePath);
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryFile);
            if (!Directory.Exists(directoryFile))
            {
                directoryInfo.Create();
            }
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter streamwWriter = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(streamwWriter))
            {
                serializer.Serialize(writer, data);
            }
        }
        /// <summary>
        /// Получение из потока байтов ранее сохраненный файл
        /// </summary>
        /// <param name="filePath">Расположение файла</param>
        /// <returns> Возвращает переменную содеражащую данные Contact</returns>
        public static Project LoadFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                var emptyContact = new Project();
                return emptyContact;
            }
            Project contact = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader streamReader = new StreamReader(filePath))
            using (JsonReader reader = new JsonTextReader(streamReader))
            {
                contact = (Project)serializer.Deserialize<Project>(reader);

            }

            return contact;
        }
        
    }
}
