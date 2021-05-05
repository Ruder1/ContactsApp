using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp1
{
    public class PhoneNumber
    {
        private string _phoneNumber;

        public string NumberPhone
        {
            get { return _phoneNumber; }
            set
            {
                Validator.ValidtationPhoneNumber(value);
                    _phoneNumber = value;
            }
        }
    }
}
