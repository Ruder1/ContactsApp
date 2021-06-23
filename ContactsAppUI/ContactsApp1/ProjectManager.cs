using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ContactsApp1
{

    /// <summary>
    /// Статичный класс для операций с файлами формата .json
    /// </summary>
    public static class ProjectManager
    {

        /// <summary>
        /// Метод для получения расположения файла
        /// </summary>
        public static string DefaultPath
        {
            get
            {
                var appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                var path = appDataFolder + @"\Pogorelov\ContactsApp\contact.json";
                return path;
            }
        }

        /// <summary>
        /// преобразования какого-либо объекта в поток байтов
        /// </summary>
        /// <param name="data">Данные контактов</param>
        /// <param name="filePath">Расположение файла</param>
        public static void SaveToFile(Project data, string filePath)
        {
            var directoryFile = Path.GetDirectoryName(filePath);
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryFile ?? throw new InvalidOperationException());
            if (!Directory.Exists(directoryFile))
            {
                directoryInfo.Create();
            }

            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(streamWriter))
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
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                Project project = null;
                using (StreamReader streamReader = new StreamReader(filePath))
                using (JsonReader reader = new JsonTextReader(streamReader))
                {
                    project = serializer.Deserialize<Project>(reader);
                    if (project.Contacts.Capacity == 0)
                    {
                        project = new Project();
                    }
                }

                return project;
            }
            catch ( Exception exception)
            {
                return new Project();
            }
        }
    }
}
