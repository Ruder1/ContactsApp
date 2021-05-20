using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp1;
using System.IO;
using System.Runtime.CompilerServices;

namespace ContactsAppUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Contact contact = new Contact("Pogorelov", "Sam","79516193318",
                new DateTime(2000, 10, 15), "cpc15@mail.ru", "ruder_s");
            ProjectManager.SaveToFile(contact);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
            
           
            
        }
    }
}
