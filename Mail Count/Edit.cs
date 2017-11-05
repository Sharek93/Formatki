using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Count
{
    public partial class Edit : Form
    {
        string count;

        public Edit(string count)
        {
            InitializeComponent();
            label1.Location = new Point((Width / 10) * 5 - label1.Size.Width / 2, (Height / 10) * 1 - label1.Size.Height / 2);
            textBox1.Location = new Point((Width / 10) * 5 - textBox1.Size.Width / 2, (Height / 10) * 3 - textBox1.Size.Height / 2);
            Save_button.Size = new Size(Width / 2, Height / 4);
            Save_button.Location = new Point((Width / 10) * 5 - Save_button.Size.Width / 2, (Height / 10) * 6 - Save_button.Size.Height / 2);
            textBox1.Text = count;
            textBox1.Focus();
        }
        public string Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            count = textBox1.Text;
            Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                count = textBox1.Text;
                Close();
            }
        }
    }
}
