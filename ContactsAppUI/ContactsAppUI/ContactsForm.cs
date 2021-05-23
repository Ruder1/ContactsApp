using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp1;

namespace ContactsAppUI
{
    public partial class ContactsForm : Form
    {
        private Contact _contact = new Contact();

        private readonly Color _incorrectInputColor = Color.LightSalmon;

        private readonly Color _correctInputColor = Color.White;
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = (Contact)value.Clone();

                if (_contact != null)
                {

                    SurnameTextBox.Text = _contact.Surname;
                    NameTextBox.Text = _contact.Name;
                    PhoneNumberTextBox.Text = _contact.PhoneNumber.NumberPhone;
                    BirthDateTimePicker.Value = _contact.DateOfBirth;
                    EmailTextBox.Text = _contact.Email;
                    IDVkTextBox.Text = _contact.IdVkontake;
                }
            }
        }
        public ContactsForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                Contact.Surname = SurnameTextBox.Text;
                Contact.Name = NameTextBox.Text;
                Contact.PhoneNumber.NumberPhone = PhoneNumberTextBox.Text;
                Contact.DateOfBirth = BirthDateTimePicker.Value;
                Contact.Email = EmailTextBox.Text;
                Contact.IdVkontake = IDVkTextBox.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException exception)
            {
                DialogResult result = MessageBox.Show
                (
                    exception.Message,
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Surname = SurnameTextBox.Text;
                SurnameTextBox.BackColor = _correctInputColor;
            }
            catch (ArgumentException exception)
            {
                SurnameTextBox.BackColor = _incorrectInputColor;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Name = NameTextBox.Text;
                NameTextBox.BackColor = _correctInputColor;
            }
            catch (ArgumentException exception)
            {
                NameTextBox.BackColor = _incorrectInputColor;
            }
        }

        private void BirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.DateOfBirth = BirthDateTimePicker.Value;
                BirthDateTimePicker.BackColor = _correctInputColor;
            }
            catch (ArgumentException exception)
            {
                BirthDateTimePicker.BackColor = _incorrectInputColor;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = _correctInputColor;
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = _incorrectInputColor;
            }
        }

        private void IDVkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Email = EmailTextBox.Text;
                IDVkTextBox.BackColor = _correctInputColor;
            }
            catch (ArgumentException exception)
            {

                IDVkTextBox.BackColor = _incorrectInputColor;

            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.PhoneNumber.NumberPhone = EmailTextBox.Text;
                PhoneNumberTextBox.BackColor = _correctInputColor;
            }
            catch (ArgumentException exception)
            {

                PhoneNumberTextBox.BackColor = _incorrectInputColor;

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
