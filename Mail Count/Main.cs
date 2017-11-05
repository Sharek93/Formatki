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
    public partial class Main : Form
    {
        Edit edit_form;
        Info_form info_form = new Info_form();
        Xls_save xls_save = new Xls_save();
        Backup backup = new Backup();
        Config config = new Config();
        Load_blanks_file load_blanks_file = new Load_blanks_file();

        private Load_blanks_file.Blanks[] blanks_file;

        int counter;

        bool saved = false;
        bool show_blanks = true;
        bool blank_edit = false, blank_add = false;
        bool timer_warnings = true;
        bool blank_copy_confim = false;

        string save_directory = string.Empty;
        string blanks_directory = string.Empty;

        string[] config_data = new string[10];

        public Main()
        {
            InitializeComponent();
            UserStripStatusLabel.Text = Environment.UserName;
            DataStripStatusLabel.TextAlign = ContentAlignment.MiddleRight;

            Copy_status_label.Text = string.Empty;

            config_data = config.Config_restore();
            Config_apply();

            blanks_file = load_blanks_file.load_blanks(blanks_directory);
            if (blanks_file != null)
            {
                foreach (var blank in blanks_file)
                {
                    Blanks_title_ComboBox.Items.Add(blank.title);
                }
            }
                        
            save_dir_ToolStripMenuItem.Text = save_directory;
            blanks_dir_ToolStripMenuItem.Text = blanks_directory;            


            Blanks_title_textBox.Location = Blanks_title_ComboBox.Location;
            Blanks_text_textBox.Location = Blanks_text_Label.Location;
            Blanks_text_textBox.Size = Blanks_text_Label.Size;
            Blanks_title_textBox.Visible = false;
            Blanks_text_textBox.Visible = false;
            Blanks_edit_Button.Enabled = false;

            Controls_resize();
        }

        private void Config_apply()
        {
            save_directory = config_data[0];
            blanks_directory = config_data[1];
            bool.TryParse(config_data[2], out show_blanks);
            bool.TryParse(config_data[3], out timer_warnings);

            if (show_blanks)
            {
                Width = 1000;
                BlanksPanel.Width = 600;
                Show_blanks_Button.Text = "<<";
                show_formants_ToolStripMenuItem.Text = "Pokaż formatki - tak";
                Blanks_status_Label.Visible = true;
            }
            else
            {
                Width = 400;
                BlanksPanel.Width = 30;
                Show_blanks_Button.Text = ">>";
                show_formants_ToolStripMenuItem.Text = "Pokaż formatki - nie";
                Blanks_status_Label.Visible = false;
            }

            if (timer_warnings)
            {
                powiadomienieOKwarantannieWłToolStripMenuItem.Text = "Powiadomienia o kwarantannie - wł";
            }
            else
            {
                powiadomienieOKwarantannieWłToolStripMenuItem.Text = "Powiadomienia o kwarantannie - wył";
            }
        }                  

        private void Config_set()
        {
            config_data[0] = save_directory;
            config_data[1] = blanks_directory;
            config_data[2] = show_blanks.ToString();
            config_data[3] = timer_warnings.ToString();
        }

        private void Controls_resize()
        {
            MainPanel.Width = Width - BlanksPanel.Size.Width;
            Count_label.Location = new Point((MainPanel.Width / 10) * 5 - Count_label.Size.Width / 2, (MainPanel.Height / 10) * 3 - Count_label.Size.Height / 2);
            Last_Cick_Label.Location = new Point((MainPanel.Width / 10) * 5 - Last_Cick_Label.Size.Width / 2, (MainPanel.Height / 10) * 8 - Last_Cick_Label.Size.Height / 2);
            AddButton.Size = new Size(MainPanel.Width / 2, MainPanel.Height / 4);
            AddButton.Location = new Point((MainPanel.Width / 10) * 5 - AddButton.Size.Width / 2, (MainPanel.Height / 10) * 6 - AddButton.Size.Height / 2);

            Blanks_status_Label.Location = new Point(BlanksPanel.Width/2 - Blanks_status_Label.Width/2, 20);

            Blanks_text_Label.Height = BlanksPanel.Height - 150;
            Blanks_text_textBox.Height = BlanksPanel.Height - 150;
            Blanks_edit_Button.Location = new Point(BlanksPanel.Width - 180, BlanksPanel.Height - 40);
            Blank_Add_button.Location = new Point(BlanksPanel.Width - 310, BlanksPanel.Height - 40);

            Copy_status_label.Location = new Point(BlanksPanel.Width - 570, BlanksPanel.Height - 35);
        }

        private void Date_Time_timer_Tick(object sender, EventArgs e)
        {
            if (blank_copy_confim)
            {                
                blank_copy_confim = false;
            }
            else
            {
                Copy_status_label.Text = string.Empty;
            }
            if (timer_warnings)
            {
                DataStripStatusLabel.Text = DateTime.Now.ToString();
                if (DateTime.Now.Hour % 2 == 0 && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
                {
                    MessageBox.Show(new Form { TopMost = true }, "Zwolnij Kwarantannę");
                }
            }          
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Controls_resize();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            counter++;
            Count_label.Text = counter.ToString();
            Count_label.Location = new Point((MainPanel.Width / 10) * 5 - Count_label.Size.Width / 2, (MainPanel.Height / 10) * 3 - Count_label.Size.Height / 2);

            Last_Cick_Label.Text = string.Format("Ostatnie kliknięcie o: {0:00}:{1:00}:{2:00}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second); 
            Last_Cick_Label.Location = new Point((MainPanel.Width / 10) * 5 - Last_Cick_Label.Size.Width / 2, (MainPanel.Height / 10) * 8 - Last_Cick_Label.Size.Height / 2);

            backup.backup(Environment.UserName, counter.ToString());

            Save_status_toolStripStatusLabel.Text = "Nie zapisano";
            saved = false;
        }

        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Config_set();
            config.Config_save(config_data);
            if (xls_save.Save(counter, Environment.UserName, save_directory))
            {               
                Save_status_toolStripStatusLabel.Text = "Zapisano";
                saved = true;
            }
            else
            {
                MessageBox.Show("Zapis nieudany, możliwe że wskazany plik zapisu nie istnieje!");
            }
            backup.backup(Environment.UserName, counter.ToString());
        }
        private void EdytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_form = new Edit(counter.ToString());
            edit_form.ShowDialog();
            bool bol = Int32.TryParse(edit_form.Count,out counter);
            saved = false;
            Count_label.Text = counter.ToString();
            Count_label.Location = new Point((MainPanel.Width / 10) * 5 - Count_label.Size.Width / 2, (MainPanel.Height / 10) * 3 - Count_label.Size.Height / 2);
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();  
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config_set();
            config.Config_save(config_data);
            if (!saved)
            {
                var result = MessageBox.Show("Nie Zapisałeś! Czy chcesz zapisać przed wyjściem?", "Potwierdzenie", MessageBoxButtons.YesNoCancel);                
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (result == DialogResult.Yes)
                {
                    if (!xls_save.Save(counter, Environment.UserName, save_directory))
                    {
                        MessageBox.Show("Zapis nieudany, możliwe że wskazany plik zapisu nie istnieje!");
                        e.Cancel = true;
                    }
                    backup.backup(Environment.UserName, counter.ToString());
                }         
            }
        }

        private void lokalizacjaZapisuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory_FileDialog.InitialDirectory = Environment.CurrentDirectory;
            Directory_FileDialog.FileName = null;
            Directory_FileDialog.Filter = "*XLS|*.xls|*XLSX|*.xlsx";
            Directory_FileDialog.ShowDialog();
            save_directory = Directory_FileDialog.FileName.ToString();
            save_dir_ToolStripMenuItem.Text = save_directory;
        }

        private void lokalizacjaFormatekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Directory_FileDialog.InitialDirectory = Environment.CurrentDirectory;
            Directory_FileDialog.FileName = null;
            Directory_FileDialog.Filter = "Tekst|*.txt";
            Directory_FileDialog.ShowDialog();
            blanks_directory = Directory_FileDialog.FileName.ToString();
            blanks_dir_ToolStripMenuItem.Text = blanks_directory;
            reload_blanks();
        }

        private void pokażFormatkiWłToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (show_blanks)
            {
                Width -= 600;
                BlanksPanel.Width = 30;                
                Show_blanks_Button.Text = ">>";
                show_blanks = false;
                show_formants_ToolStripMenuItem.Text = "Pokaż formatki - nie";
                Blanks_status_Label.Visible = false;
            }
            else
            {
                Width += 600;
                BlanksPanel.Width = 600;
                Show_blanks_Button.Text = "<<";
                show_blanks = true;
                show_formants_ToolStripMenuItem.Text = "Pokaż formatki - tak";
                Blanks_status_Label.Visible = true;
            }
            Controls_resize();
        }

        private void Show_Fromants_Button_Click(object sender, EventArgs e)
        {
            if (show_blanks)
            {
                Width -= 600;
                BlanksPanel.Width = 30;
                Show_blanks_Button.Text = ">>";
                show_blanks = false;
                show_formants_ToolStripMenuItem.Text = "Pokaż formatki - nie";
                Blanks_status_Label.Visible = false;
            }
            else
            {
                Width += 600;
                BlanksPanel.Width = 600;
                Show_blanks_Button.Text = "<<";
                show_blanks = true;
                show_formants_ToolStripMenuItem.Text = "Pokaż formatki - tak";
                Blanks_status_Label.Visible = true;
            }
            Controls_resize();
        }

        private void Blanks_title_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Blanks_text_Label.Text = blanks_file[Blanks_title_ComboBox.SelectedIndex].text.Replace(@"\n",Environment.NewLine);
            Blanks_edit_Button.Enabled = true;
        }

        private void Blanks_edit_Button_Click(object sender, EventArgs e)
        {
            if (blank_edit)
            {
                if (Blanks_title_textBox.TextLength > 0 && Blanks_text_textBox.TextLength > 0) 
                {
                    blank_edit = false;
                    blank_add = false;
                    Blanks_status_Label.Text = "Formatki";
                    Blanks_status_Label.Location = new Point(BlanksPanel.Width / 2 - Blanks_status_Label.Width / 2, 20);
                    Blanks_text_textBox.Visible = false;
                    Blanks_text_Label.Visible = true;
                    Blanks_title_textBox.Visible = false;
                    Blanks_title_ComboBox.Visible = true;
                    Blanks_edit_Button.Text = "Edytuj formatkę";
                    Blank_Add_button.Text = "Dodaj formatkę";
                    load_blanks_file.blank_edit(blanks_directory, Blanks_title_textBox.Text, Blanks_text_textBox.Text.Replace(Environment.NewLine,@"\n"), Blanks_title_ComboBox.SelectedIndex);
                    MessageBox.Show("Edycja zakończona");
                    reload_blanks();
                    Blanks_title_ComboBox.Text = Blanks_title_textBox.Text;
                    Blanks_text_Label.Text = Blanks_text_textBox.Text;
                }
                else
                {
                    MessageBox.Show("Pola nie mogą być puste");
                }               
            }
            else if (!blank_add)
            {
                blank_edit = true;
                Blanks_status_Label.Text = "Edytuj istniejącą formatkę";
                Blanks_status_Label.Location = new Point(BlanksPanel.Width / 2 - Blanks_status_Label.Width / 2, 20);
                Blanks_title_textBox.Text = Blanks_title_ComboBox.Text;
                Blanks_text_textBox.Text = Blanks_text_Label.Text;
                Blanks_text_textBox.Visible = true;
                Blanks_text_Label.Visible = false;
                Blanks_title_textBox.Visible = true;
                Blanks_title_ComboBox.Visible = false;
                Blanks_edit_Button.Text = "Zapisz";
                Blank_Add_button.Text = "Odrzuć";
            }

            if (blank_add)
            {
                if (Blanks_title_textBox.TextLength > 0 && Blanks_text_textBox.TextLength > 0)
                {
                    blank_edit = false;
                    blank_add = false;                    
                    Blanks_status_Label.Text = "Formatki";
                    Blanks_status_Label.Location = new Point(BlanksPanel.Width / 2 - Blanks_status_Label.Width / 2, 20);
                    Blanks_text_textBox.Visible = false;
                    Blanks_text_Label.Visible = true;
                    Blanks_title_textBox.Visible = false;
                    Blanks_title_ComboBox.Visible = true;
                    Blanks_edit_Button.Text = "Edytuj formatkę";
                    Blank_Add_button.Text = "Dodaj formatkę";
                    load_blanks_file.blank_add(blanks_directory, Blanks_title_textBox.Text, Blanks_text_textBox.Text.Replace(Environment.NewLine, @"\n"));
                    MessageBox.Show("Nowa formatka została dodana");
                    reload_blanks();
                }
                else
                {
                    MessageBox.Show("Pola nie mogą być puste");
                }                    
            }
        }

        private void reload_blanks()
        {
            Blanks_title_ComboBox.Items.Clear();
            blanks_file = load_blanks_file.load_blanks(blanks_directory);
            if (blanks_file != null)
            {
                foreach (var blank in blanks_file)
                {
                    Blanks_title_ComboBox.Items.Add(blank.title);
                }
            }        
        }

        private void Blank_Add_button_Click(object sender, EventArgs e)
        {
            if (blank_add)
            {
                blank_edit = false;
                blank_add = false;
                Blanks_edit_Button.Enabled = false;
                Blanks_title_ComboBox.Text = string.Empty;
                Blanks_text_Label.Text = string.Empty;
                Blanks_status_Label.Text = "Formatki";
                Blanks_status_Label.Location = new Point(BlanksPanel.Width / 2 - Blanks_status_Label.Width / 2, 20);
                Blanks_text_textBox.Visible = false;
                Blanks_text_Label.Visible = true;
                Blanks_title_textBox.Visible = false;
                Blanks_title_ComboBox.Visible = true;
                Blanks_edit_Button.Text = "Edytuj formatkę";
                Blank_Add_button.Text = "Dodaj formatkę";
            }
            else if (!blank_edit)
            {
                blank_add = true;
                Blanks_edit_Button.Enabled = true;
                Blanks_text_textBox.Text = string.Empty;
                Blanks_title_textBox.Text = string.Empty;
                Blanks_status_Label.Text = "Dodaj nową formatkę";
                Blanks_status_Label.Location = new Point(BlanksPanel.Width / 2 - Blanks_status_Label.Width / 2, 20);
                Blanks_text_textBox.Visible = true;
                Blanks_text_Label.Visible = false;
                Blanks_title_textBox.Visible = true;
                Blanks_title_ComboBox.Visible = false;
                Blanks_edit_Button.Text = "Dodaj";
                Blank_Add_button.Text = "Odrzuć";
            }

            if (blank_edit)
            {
                blank_edit = false;
                blank_add = false;                
                Blanks_status_Label.Text = "Formatki";
                Blanks_status_Label.Location = new Point(BlanksPanel.Width / 2 - Blanks_status_Label.Width / 2, 20);
                Blanks_text_textBox.Visible = false;
                Blanks_text_Label.Visible = true;
                Blanks_title_textBox.Visible = false;
                Blanks_title_ComboBox.Visible = true;
                Blanks_edit_Button.Text = "Edytuj formatkę";
                Blank_Add_button.Text = "Dodaj formatkę";
            }
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info_form.ShowDialog();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            Blanks_title_ComboBox.Focus();
        }

        private void powiadomienieOKwarantannieWłToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer_warnings)
            {               
                powiadomienieOKwarantannieWłToolStripMenuItem.Text = "Powiadomienia o kwarantannie - wył";
            }
            else
            {
                powiadomienieOKwarantannieWłToolStripMenuItem.Text = "Powiadomienia o kwarantannie - wł";
            }
            timer_warnings = !timer_warnings;
        }

        private void Blanks_title_ComboBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Clipboard.SetText(Blanks_text_Label.Text);
                blank_copy_confim = true;
                Copy_status_label.Text = "Tekst skopiowany";
            }
        }
        private void Blanks_text_Label_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(Blanks_text_Label.Text);
            blank_copy_confim = true;
            Copy_status_label.Text = "Tekst skopiowany";
        }
    }
}
