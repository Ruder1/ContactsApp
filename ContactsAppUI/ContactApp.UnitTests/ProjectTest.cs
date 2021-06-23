using System;
using ContactsApp1;
using NUnit.Framework;

namespace ContactApp.UnitTests
{
    [TestFixture]
    class ProjectTest
    {

        [TestCase(TestName = "Project getter positive test")]
        public void Project_CorrectValue_ReturnsSameValue()
        {
            //SetUp
            var expectedBirthday = new DateTime(2000, 12, 01);
            var contact = new Contact("Pushkin","Ilya", "79425143487",
                expectedBirthday, "fakemail","idvk");
                var expectedContacts = new Project();

            //Testing
            expectedContacts.Contacts.Add(contact);
            var actualContact = (Contact)contact.Clone();
            var actualContacts = new Project();
            actualContacts.Contacts.Add(actualContact);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedContacts.Contacts.Count, actualContacts.Contacts.Count,
                    "Counts of contacts do not match");
                Assert.AreEqual(expectedContacts.Contacts,actualContacts.Contacts,"Contacts is null");
               
            });
        }
    }
}
