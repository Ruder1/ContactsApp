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
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
            Contact contact1 = ProjectManager.LoadFile();

            label1.Text = contact1.PhoneNumber.NumberPhone;
        }
    }
}
