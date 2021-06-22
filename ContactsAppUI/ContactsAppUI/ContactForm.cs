using System;
using System.Drawing;
using System.Windows.Forms;
using ContactsApp1;

namespace ContactsAppUI
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Создает поле контакт
        /// </summary>
        private Contact _contact = new Contact();

        /// <summary>
        /// Цвет не правильного ввода значений
        /// </summary>
        private readonly Color _incorrectBackColor = Color.LightSalmon;

        /// <summary>
        /// Цвет правильного ввода значений
        /// </summary>
        private readonly Color _correctBackColor = Color.White;

        /// <summary>
        /// Занесение полей контакта введеных пользователем
        /// </summary>
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = (Contact)value.Clone();

                if (_contact == null) return;
                SurnameTextBox.Text = _contact.Surname;
                NameTextBox.Text = _contact.Name;
                PhoneNumberTextBox.Text = _contact.PhoneNumber.NumberPhone;
                DateOfBirthTimePicker.Value = _contact.DateOfBirth;
                EmailTextBox.Text = _contact.Email;
                IDVkTextBox.Text = _contact.IdVkontake;
            }
        }

        public ContactForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //Убирает из поля PhoneNumber лишние символы - Конвертирует из 7(999)999-9999 в 79999999999
            var numberPhone = PhoneNumberTextBox.Text.Replace("(", "").
                Replace(")", "").
                Replace("-", "").Replace(" ","");
            try
            {
                Contact.Surname = SurnameTextBox.Text;
                Contact.Name = NameTextBox.Text;
                Contact.PhoneNumber.NumberPhone = numberPhone;
                Contact.DateOfBirth = DateOfBirthTimePicker.Value;
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
                    "Error",
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
                SurnameTextBox.BackColor = _correctBackColor;
            }

            catch (ArgumentException exception)
            {
                SurnameTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Name = NameTextBox.Text;
                NameTextBox.BackColor = _correctBackColor;
            }

            catch (ArgumentException exception)
            {
                NameTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            { 
                Contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = _correctBackColor;
            }

            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = _incorrectBackColor;
            }
        }

        private void IDVkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.IdVkontake = IDVkTextBox.Text;
                IDVkTextBox.BackColor = _correctBackColor;
            }

            catch (ArgumentException exception)
            {

                IDVkTextBox.BackColor = _incorrectBackColor;

            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
