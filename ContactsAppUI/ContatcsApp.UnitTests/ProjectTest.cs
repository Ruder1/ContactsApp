using System;
using ContactsApp1;
using NUnit.Framework;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    class ProjectTest
    {
        [TestCase(TestName = "Project getter positive test")]
        public void Project_CorrectValue_ReturnsSameValue()
        {
            //SetUp
            var expectedSurname = "Pushkin";
            var expectedName = "Ilya";
            var expectedNumber = "79425143487";
            var expectedBirthday = new DateTime(2000, 12, 01);
            var expectedEmail = "fakemail@mail.com";
            var expectedIdVkontakte = "id5468721";
            var contact = new Contact(expectedSurname, expectedName,
                expectedNumber, expectedBirthday, expectedEmail, expectedIdVkontakte);
            var contacts = new Project();

            //Testing
            contacts.ContactLists.Add(contact);
            var actualSurname = contacts.ContactLists[0].Surname;
            var actualName = contacts.ContactLists[0].Name;
            var actualNumber = contacts.ContactLists[0].PhoneNumber.NumberPhone;
            var actualBirthday = contacts.ContactLists[0].DateOfBirth;
            var actualEmail = contacts.ContactLists[0].Email;
            var actualIdVkontakte = contacts.ContactLists[0].IdVkontake;

            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedSurname, actualSurname, "The surnames do not match");
                Assert.AreEqual(expectedName, actualName, "The names do not match");
                Assert.AreEqual(expectedNumber, actualNumber, "The numbers do not match");
                Assert.AreEqual(expectedBirthday, actualBirthday, "The birthdays do not match");
                Assert.AreEqual(expectedEmail, actualEmail, "The emails do not match");
                Assert.AreEqual(expectedIdVkontakte, actualIdVkontakte, "The IdVkontake do not match");
            });
        }
    }
}
