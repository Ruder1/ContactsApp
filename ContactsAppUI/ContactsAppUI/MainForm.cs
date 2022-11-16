using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ContactsApp1;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список контактов
        /// </summary>
        private Project _project = new Project();


        /// <summary>
        /// Контакты у которых день рождения
        /// </summary>
        private List<string> _birthdaySurnames= new List<string>();

        /// <summary>
        /// Список контактов хранит контакты после поиска
        /// </summary>
        private List<Contact> _viewingListContacts = new List<Contact>();


        public MainForm()
        {
            //1
            InitializeComponent();
        }


        /// <summary>
        /// Функция редактирования контакта
        /// </summary>
        private void EditContact()
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                return;
            }

            var selectedData = _project.Contacts[selectedIndex];
            if (ContactsListBox.Items.Count != _project.Contacts.Count)
            {
                selectedData = _viewingListContacts[selectedIndex];
            }

            var editContact = new ContactForm { Contact = selectedData };
            editContact.ShowDialog();
            if (editContact.DialogResult != DialogResult.OK)
            {
                return;
            }

            var updatedContact = editContact.Contact;
            var updatedContactIndex = _project.Contacts.IndexOf(selectedData);
            _project.Contacts.RemoveAt(updatedContactIndex);
            _project.Contacts.Insert(updatedContactIndex, updatedContact);

            ContactsListBox.Items.RemoveAt(selectedIndex);
            ContactsListBox.Items.Insert(selectedIndex, updatedContact.Surname); ;

            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
            UpdateTextBoxes(updatedContactIndex);
            SortProject();
            SortSubstringFindProject();
            updatedContactIndex = _project.Contacts.IndexOf(updatedContact);
            ContactsListBox.SelectedIndex = updatedContactIndex;
            SearchBirthdayContacts();
        }

        /// <summary>
        /// Функция добавления контакта
        /// </summary>
        private void AddContact()
        {
            var contactForm = new ContactForm();
            contactForm.ShowDialog();
            if (contactForm.DialogResult == DialogResult.OK)
            {
                var newContact = contactForm.Contact;
                _project.Contacts.Add(newContact);
                ContactsListBox.Items.Add(newContact.Surname);
            }

            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
            SortProject();
            SortSubstringFindProject();
            SearchBirthdayContacts();
        }

        /// <summary>
        /// Функция удаление контакта
        /// </summary>
        private void RemoveContact()
        {
            var selectedIndex = ContactsListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                return;
            }

            var selectedData = _project.Contacts[selectedIndex];
            if (ContactsListBox.Items.Count != _project.Contacts.Count)
            {
                selectedData = _viewingListContacts[selectedIndex];
            }

            var result = MessageBox.Show("Do you really want to delete a contact: " +
                                         selectedData.Surname + "?",
                "Deleting a сontact", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation);
            if (result != DialogResult.OK)
            {
                return;
            }

            SurnameTextBox.Text = NameTextBox.Text =
                MaskedPhoneNumberTextBox.Text = EMailTextBox.Text = IdVkTextBox.Text = null;
            DateOfBirthTimePicker.Value=DateTime.Today;
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
            SortProject();
            SortSubstringFindProject();
            SearchBirthdayContacts();
        }

        /// <summary>
        /// Метод обновляет все значения в TextBox
        /// </summary>
        /// <param name="index"></param>
        private void UpdateTextBoxes(int index)
        {
            var contact = _project.Contacts[index];
            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            MaskedPhoneNumberTextBox.Text = contact.PhoneNumber.NumberPhone;
            DateOfBirthTimePicker.Value = contact.DateOfBirth;
            EMailTextBox.Text = contact.Email;
            IdVkTextBox.Text = contact.IdVkontake;
        }

        /// <summary>
        /// Функция поиска из списка контактов у которых сегодня день рождения
        /// </summary>
        private void SearchBirthdayContacts()
        {
            _birthdaySurnames = _project.SearchBirthdayContacts();
            if (_birthdaySurnames.Count != 0)
            {
                DateOfBirthPanel.Visible = true;
                string birthdayStringList = string.Join(", ", _birthdaySurnames);
                TodayBirthLabel.Text = "Today they celebrate their birthday \n" + birthdayStringList;
            }

            else
            {
                DateOfBirthPanel.Visible = false;
            }
        }

        /// <summary>
        /// Сортировка списка контактов
        /// </summary>
        private void SortProject()
        {
            _project.Contacts = _project.SortProject();
            FillContactsListBox(_project.Contacts);
        }

        /// <summary>
        /// Сортировка списка контактов после поиска по подстроке
        /// </summary>
        private void SortSubstringFindProject()
        {
            _viewingListContacts.Clear();
            _viewingListContacts = _project.SortProject(FindTextBox.Text);
            ContactsListBox.Items.Clear();
            if (FindTextBox.Text == "")
            {
                SortProject();
                return;
            }
            for (int i = 0; i < _viewingListContacts.Count; i++)
            {
                ContactsListBox.Items.Add(_viewingListContacts[i].Surname);
            }
            FillContactsListBox(_viewingListContacts);
        }

        /// <summary>
        /// Метод заполняет ContactsListBox контактами
        /// </summary>
        private void FillContactsListBox(List<Contact> contact)
        {
            ContactsListBox.Items.Clear();
            for (int i =0;i<contact.Count;i++)
            {
                ContactsListBox.Items.Add(contact[i].Surname);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _project.Contacts.Clear();
            ContactsListBox.Items.Clear();
            _project = ProjectManager.LoadFile(ProjectManager.DefaultPath);
            SortProject();
            SearchBirthdayContacts();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ContactsListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                return;
            }

            var contact = _project.Contacts[selectedIndex];
            if (ContactsListBox.Items.Count != _project.Contacts.Count)
            {
                contact = _viewingListContacts[selectedIndex];
            }

            SurnameTextBox.Text = contact.Surname;
            NameTextBox.Text = contact.Name;
            MaskedPhoneNumberTextBox.Text = contact.PhoneNumber.NumberPhone;
            DateOfBirthTimePicker.Value = contact.DateOfBirth;
            EMailTextBox.Text = contact.Email;
            IdVkTextBox.Text = contact.IdVkontake;
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            SortSubstringFindProject();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }

        private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();

        }

        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void RemoveContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }

        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditContact();
        }

    }
}
