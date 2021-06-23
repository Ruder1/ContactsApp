using System;
using ContactsApp1;
using NUnit.Framework;

namespace ContactApp.UnitTests
{
    [TestFixture]
    class PhoneNumberTest
    {

        [TestCase("fgsdgshdf", "If the phone number contains something other than" +
                                 " digits, an exception should be thrown",
            TestName = "Assigning a string with characters as a phone number")]
        [TestCase("711111111110", "If the phone number does not contain exactly" +
                                  " 11 digits there should be an exception",
            TestName = "Assigning a string with the wrong number of digits as a phone number")]
        [TestCase("80000000000", "If the first digit of the phone number is not 7 there " +
                                 "should be an exception",
            TestName = "Assigning a string with an incorrect first digit as a phone number")]
        public void TestPhoneNumberSet_ArgumentException(string wrongPhoneNumber, string message)
        {
            // SetUp
            var phoneNumber = new PhoneNumber();

            //Assert
            Assert.Throws<ArgumentException>(
                () => { phoneNumber.NumberPhone = wrongPhoneNumber; },
                message);
        }

        [TestCase(TestName = "Assigning the correct phone number")]
        public void PhoneNumber_CorrectValue_SetSameValue()
        {
            //SetUp
            var number = new PhoneNumber();
            var expected = "79516193318";
            number.NumberPhone = expected;

            //Testing
            var actual = number.NumberPhone;

            //Assert
            Assert.AreEqual(expected, actual, "The values are the same");
        }
    }
}
