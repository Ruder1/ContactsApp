using System;
using NUnit.Framework;
using System.IO;
using System.Reflection;
using ContactsApp1;


namespace ContactsApp.UnitTests
{
    [TestFixture]
    class ProjectManagerTest
    {
        /// <summary>
        /// Путь к директории с тестовыми файлами
        /// </summary>
        private static string _currentPath =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));

        /// <summary>
        /// Поле хранит путь на корректный файл для тестов
        /// </summary>
        private static string _correctProjectFilename = _currentPath + @"TestData\correctcontactsdata.json";

        /// <summary>
        /// Поле хранит путь на поврежденный файл
        /// </summary>
        private static string _uncorrectProjectFilename = _currentPath + @"TestData\uncorrectcontactsdata.json";

        /// <summary>
        /// Поле хранит путь на файл для теста сериализации
        /// </summary>
        private static string _outputSaveFilename = _currentPath + @"OutData\filefromserialize.json";

        /// <summary>
        /// Метод заполняет project двумя контактами
        /// </summary>
        /// <param name="project">Пустой project</param>
        /// <returns>project с двумя контактами</returns>
        public Project FillTwoContact(Project project)
        {
            var contact = new Contact("Petrov", "Ivan", "71234567899",
                new DateTime(2010, 02, 02), "mail@mail.ru", "id999999");
            project.ContactLists.Add(contact);
            contact = new Contact("Smirnov", "Vlad", "79876543211",
                new DateTime(2000, 12, 12), "gmail@gmail.com", "id444444");
            project.ContactLists.Add(contact);
            return project;
        }


        [TestCase(TestName = "Positive test deserialize")] 
        public void ProjectManager_LoadCorrectionData_FileSavedCorrectly()
        {
            //SetUp
            var expectedProject = new Project();
            expectedProject = FillTwoContact(expectedProject);

            //Testing
            var actualProject = ProjectManager.LoadFile(_correctProjectFilename);

            //Assert
            Assert.AreEqual(expectedProject.ContactLists.Count, actualProject.ContactLists.Count);
            Assert.Multiple(() =>
            {
                for (int i = 0; i < expectedProject.ContactLists.Count; i++)
                {
                    var expected = expectedProject.ContactLists[i];
                    var actual = actualProject.ContactLists[i];

                    Assert.AreEqual(expected, actual);
                }

            });
        }

        [TestCase(TestName = "Negative test deserialize, uncorreсt file ")]
        public void ProjectManager_LoadUncorrectFIle_RetursEmptyFile()
        {
            //SetUp
            var excpectedProject = new Project();

            //Testing
            var actualProject = ProjectManager.LoadFile(_uncorrectProjectFilename);

            //Assert
            Assert.AreEqual(excpectedProject.ContactLists.Count, actualProject.ContactLists.Count);

        }

        [TestCase(TestName = "Negative test deserialize, non-existent file ")]
        public void ProjectManager_LoadNonExistentFIle_RetursEmptyFile()
        {
            var expectedProject = new Project();

            var location = Assembly.GetExecutingAssembly().Location;
            var folder = Path.GetDirectoryName(location);

            //Testing
            var actualProject = ProjectManager.LoadFile($@"{folder}\TestData\nonexistent.json");

            //Assert
            Assert.AreEqual(expectedProject.ContactLists.Count, actualProject.ContactLists.Count);

        }

        [TestCase(TestName = "Positive test serialize")]
        public void ProjectManager_SaveCorrectionData_FileLoadedCorrectly()
        {
            //SetUp
            var expectedProject = new Project();
            expectedProject = FillTwoContact(expectedProject);

            //Testing
            ProjectManager.SaveToFile(expectedProject, _outputSaveFilename);

            //Assert
            var actual = File.ReadAllText(_outputSaveFilename);
            var expected = File.ReadAllText(_correctProjectFilename);
            Assert.AreEqual(expected, actual);

        }
    }
}
