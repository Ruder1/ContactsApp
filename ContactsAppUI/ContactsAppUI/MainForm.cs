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
using System.IO;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private List<Contact> _contacts = new List<Contact>();
        public MainForm()
        {
            InitializeComponent();

        }

        private void Contact_Click(object sender, EventArgs e)
        {
            //Contact contact1 = ProjectManager.LoadFile();
            //SurnameLabel.Text += contact1.Surname;
            //NameLabel.Text += contact1.Name;
            //BirthLabel.Text += contact1.DateOfBirth.ToShortDateString();
            //EmailLabel.Text += contact1.Email;
            //IdVkLabel.Text += contact1.IdVkontake;
            //PhoneLabel.Text += contact1.PhoneNumber.NumberPhone;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //TODO: Исправить метод загрузгки на метод сохранения
            Contact newContact;
            newContact = ProjectManager.LoadFile(ProjectManager.DefaultPath);
            ContactsListBox.Items.Add(newContact.Name);
            _contacts.Add(newContact);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                return;
            }
            ContactsListBox.Items.RemoveAt(selectedIndex);
            _contacts.RemoveAt(selectedIndex);
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                return;
            }
            int selectedIndex = ContactsListBox.SelectedIndex;
            var contact = _contacts[selectedIndex];
            //if (ContactsListBox.Items.Count != _contacts.Count)
            //{
            //    contact = _viewingListContacts[selectedIndex];
            //}

            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            PhoneTextBox.Text = contact.PhoneNumber.NumberPhone;
            BirthDateTimePicker.Value = contact.DateOfBirth;
            EMailTextBox.Text = contact.Email;
            IdVkTextBox.Text = contact.IdVkontake;
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RemoveContactToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
