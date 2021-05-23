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
        /// <summary>
        /// Список контактов
        /// </summary>
        private Project _project = new Project();

        public MainForm()
        {
            InitializeComponent();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            var contactForm = new ContactsForm();
            contactForm.ShowDialog();
            if (contactForm.DialogResult == DialogResult.OK)
            {
                var newContact = contactForm.Contact;
                _project.ContactLists.Add(newContact);
                ProjectManager.SaveToFile(_project,ProjectManager.DefaultPath);
                ContactsListBox.Items.Add(newContact.Name);
            }
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
            _project.ContactLists.RemoveAt(selectedIndex);
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                return;
            }
            int selectedIndex = ContactsListBox.SelectedIndex;
            var contact = _project.ContactLists[selectedIndex];
            if (ContactsListBox.Items.Count != _project.ContactLists.Count)
            {
                contact = _viewingListContacts[selectedIndex];
            }

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
            ProjectManager.SaveToFile(_project,ProjectManager.DefaultPath);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            var selectedData = _project.ContactLists[selectedIndex];

            var editContact = new ContactsForm();
            editContact.Contact = selectedData;
            editContact.ShowDialog();
            if (editContact.DialogResult == DialogResult.OK)
            {
                var updatedContact = editContact.Contact;
                ContactsListBox.Items.RemoveAt(selectedIndex);
                _project.ContactLists.RemoveAt(selectedIndex);
                _project.ContactLists.Insert(selectedIndex,updatedContact);
                ContactsListBox.Items.Insert(selectedIndex,updatedContact.Name);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _project = ProjectManager.LoadFile(ProjectManager.DefaultPath);
        }
    }
}
