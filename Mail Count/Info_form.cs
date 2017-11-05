using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Count
{
    public partial class Info_form : Form
    {
        public Info_form()
        {
            InitializeComponent();
            if (File.Exists(Environment.CurrentDirectory + @"/changelog.txt"))
            {
                File.SetAttributes(Environment.CurrentDirectory + @"/changelog.txt", FileAttributes.ReadOnly);
            }
            if (File.Exists(Environment.CurrentDirectory + @"/help.txt"))
            {
                File.SetAttributes(Environment.CurrentDirectory + @"/help.txt", FileAttributes.ReadOnly);
                textBox.Text = File.ReadAllText(Environment.CurrentDirectory + @"/help.txt", Encoding.Default);
            }
            else
            {
                textBox.Text = "Nie znaleziono pliku pomocy!";
            }
            
        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Help_button_Click(object sender, EventArgs e)
        {
            Text = "Pomoc";
            if (File.Exists(Environment.CurrentDirectory + @"/help.txt"))
            {
                textBox.Text = File.ReadAllText(Environment.CurrentDirectory + @"/help.txt", Encoding.Default);
            }
            else
            {
                textBox.Text = "Nie znaleziono pliku pomocy!";
            }
        }

        private void Change_log_button_Click(object sender, EventArgs e)
        {
            Text = "Historia wersji";
            if (File.Exists(Environment.CurrentDirectory + @"/changelog.txt"))
            {
                textBox.Text = File.ReadAllText(Environment.CurrentDirectory + @"/changelog.txt", Encoding.Default);
            }
            else
            {
                textBox.Text = "Nie znaleziono pliku historii wersji!";
            }            
        }
    }
}
