namespace Mail_Count
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UserStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Save_status_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SpringStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Date_Time_timer = new System.Windows.Forms.Timer(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokalizacjaZapisuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_dir_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lokalizacjaFormatekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blanks_dir_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.show_formants_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.powiadomienieOKwarantannieWłToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Count_label = new System.Windows.Forms.Label();
            this.Last_Cick_Label = new System.Windows.Forms.Label();
            this.Directory_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BlanksPanel = new System.Windows.Forms.Panel();
            this.Blanks_status_Label = new System.Windows.Forms.Label();
            this.Blanks_text_textBox = new System.Windows.Forms.TextBox();
            this.Blanks_title_textBox = new System.Windows.Forms.TextBox();
            this.Blank_Add_button = new System.Windows.Forms.Button();
            this.Show_blanks_Button = new System.Windows.Forms.Button();
            this.Blanks_edit_Button = new System.Windows.Forms.Button();
            this.Blanks_title_ComboBox = new System.Windows.Forms.ComboBox();
            this.Blanks_text_Label = new System.Windows.Forms.Label();
            this.Copy_status_label = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.BlanksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserStripStatusLabel,
            this.Save_status_toolStripStatusLabel,
            this.SpringStatusLabel,
            this.DataStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 290);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UserStripStatusLabel
            // 
            this.UserStripStatusLabel.Name = "UserStripStatusLabel";
            this.UserStripStatusLabel.Size = new System.Drawing.Size(114, 17);
            this.UserStripStatusLabel.Text = "UserStripStatusLabel";
            // 
            // Save_status_toolStripStatusLabel
            // 
            this.Save_status_toolStripStatusLabel.Name = "Save_status_toolStripStatusLabel";
            this.Save_status_toolStripStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.Save_status_toolStripStatusLabel.Text = "Save_status";
            // 
            // SpringStatusLabel
            // 
            this.SpringStatusLabel.Name = "SpringStatusLabel";
            this.SpringStatusLabel.Size = new System.Drawing.Size(673, 17);
            this.SpringStatusLabel.Spring = true;
            // 
            // DataStripStatusLabel
            // 
            this.DataStripStatusLabel.Name = "DataStripStatusLabel";
            this.DataStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DataStripStatusLabel.Size = new System.Drawing.Size(115, 17);
            this.DataStripStatusLabel.Text = "DataStripStatusLabel";
            // 
            // Date_Time_timer
            // 
            this.Date_Time_timer.Enabled = true;
            this.Date_Time_timer.Interval = 1000;
            this.Date_Time_timer.Tick += new System.EventHandler(this.Date_Time_timer_Tick);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(101, 123);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(178, 96);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opcjeToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EdytujToolStripMenuItem,
            this.zapiszToolStripMenuItem1,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // EdytujToolStripMenuItem
            // 
            this.EdytujToolStripMenuItem.Name = "EdytujToolStripMenuItem";
            this.EdytujToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.EdytujToolStripMenuItem.Text = "Edytuj";
            this.EdytujToolStripMenuItem.Click += new System.EventHandler(this.EdytujToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem1
            // 
            this.zapiszToolStripMenuItem1.Name = "zapiszToolStripMenuItem1";
            this.zapiszToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem1.Size = new System.Drawing.Size(160, 22);
            this.zapiszToolStripMenuItem1.Text = "Zapisz";
            this.zapiszToolStripMenuItem1.Click += new System.EventHandler(this.zapiszToolStripMenuItem1_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lokalizacjaZapisuToolStripMenuItem,
            this.save_dir_ToolStripMenuItem,
            this.toolStripSeparator1,
            this.lokalizacjaFormatekToolStripMenuItem,
            this.blanks_dir_ToolStripMenuItem,
            this.toolStripSeparator2,
            this.show_formants_ToolStripMenuItem,
            this.toolStripSeparator3,
            this.powiadomienieOKwarantannieWłToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // lokalizacjaZapisuToolStripMenuItem
            // 
            this.lokalizacjaZapisuToolStripMenuItem.Name = "lokalizacjaZapisuToolStripMenuItem";
            this.lokalizacjaZapisuToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.lokalizacjaZapisuToolStripMenuItem.Text = "Lokalizacja zapisu licznika";
            this.lokalizacjaZapisuToolStripMenuItem.Click += new System.EventHandler(this.lokalizacjaZapisuToolStripMenuItem_Click);
            // 
            // save_dir_ToolStripMenuItem
            // 
            this.save_dir_ToolStripMenuItem.Enabled = false;
            this.save_dir_ToolStripMenuItem.Name = "save_dir_ToolStripMenuItem";
            this.save_dir_ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.save_dir_ToolStripMenuItem.Text = "dir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // lokalizacjaFormatekToolStripMenuItem
            // 
            this.lokalizacjaFormatekToolStripMenuItem.Name = "lokalizacjaFormatekToolStripMenuItem";
            this.lokalizacjaFormatekToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.lokalizacjaFormatekToolStripMenuItem.Text = "Lokalizacja Formatek";
            this.lokalizacjaFormatekToolStripMenuItem.Click += new System.EventHandler(this.lokalizacjaFormatekToolStripMenuItem_Click);
            // 
            // blanks_dir_ToolStripMenuItem
            // 
            this.blanks_dir_ToolStripMenuItem.Enabled = false;
            this.blanks_dir_ToolStripMenuItem.Name = "blanks_dir_ToolStripMenuItem";
            this.blanks_dir_ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.blanks_dir_ToolStripMenuItem.Text = "dir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // show_formants_ToolStripMenuItem
            // 
            this.show_formants_ToolStripMenuItem.Name = "show_formants_ToolStripMenuItem";
            this.show_formants_ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.show_formants_ToolStripMenuItem.Text = "Pokaż formatki - wł";
            this.show_formants_ToolStripMenuItem.Click += new System.EventHandler(this.pokażFormatkiWłToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // powiadomienieOKwarantannieWłToolStripMenuItem
            // 
            this.powiadomienieOKwarantannieWłToolStripMenuItem.Name = "powiadomienieOKwarantannieWłToolStripMenuItem";
            this.powiadomienieOKwarantannieWłToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.powiadomienieOKwarantannieWłToolStripMenuItem.Text = "Powiadomienia o kwarantannie - wł";
            this.powiadomienieOKwarantannieWłToolStripMenuItem.Click += new System.EventHandler(this.powiadomienieOKwarantannieWłToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // Count_label
            // 
            this.Count_label.AutoSize = true;
            this.Count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Count_label.Location = new System.Drawing.Point(160, 19);
            this.Count_label.Name = "Count_label";
            this.Count_label.Size = new System.Drawing.Size(69, 73);
            this.Count_label.TabIndex = 3;
            this.Count_label.Text = "0";
            // 
            // Last_Cick_Label
            // 
            this.Last_Cick_Label.AutoSize = true;
            this.Last_Cick_Label.Location = new System.Drawing.Point(120, 236);
            this.Last_Cick_Label.Name = "Last_Cick_Label";
            this.Last_Cick_Label.Size = new System.Drawing.Size(0, 13);
            this.Last_Cick_Label.TabIndex = 4;
            // 
            // Directory_FileDialog
            // 
            this.Directory_FileDialog.FileName = "openFileDialog1";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainPanel.Controls.Add(this.AddButton);
            this.MainPanel.Controls.Add(this.Last_Cick_Label);
            this.MainPanel.Controls.Add(this.Count_label);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 24);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(384, 266);
            this.MainPanel.TabIndex = 5;
            // 
            // BlanksPanel
            // 
            this.BlanksPanel.Controls.Add(this.Copy_status_label);
            this.BlanksPanel.Controls.Add(this.Blanks_status_Label);
            this.BlanksPanel.Controls.Add(this.Blanks_text_textBox);
            this.BlanksPanel.Controls.Add(this.Blanks_title_textBox);
            this.BlanksPanel.Controls.Add(this.Blank_Add_button);
            this.BlanksPanel.Controls.Add(this.Show_blanks_Button);
            this.BlanksPanel.Controls.Add(this.Blanks_edit_Button);
            this.BlanksPanel.Controls.Add(this.Blanks_title_ComboBox);
            this.BlanksPanel.Controls.Add(this.Blanks_text_Label);
            this.BlanksPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.BlanksPanel.Location = new System.Drawing.Point(384, 24);
            this.BlanksPanel.Margin = new System.Windows.Forms.Padding(10);
            this.BlanksPanel.Name = "BlanksPanel";
            this.BlanksPanel.Size = new System.Drawing.Size(600, 266);
            this.BlanksPanel.TabIndex = 5;
            // 
            // Blanks_status_Label
            // 
            this.Blanks_status_Label.AutoSize = true;
            this.Blanks_status_Label.Location = new System.Drawing.Point(268, 19);
            this.Blanks_status_Label.Name = "Blanks_status_Label";
            this.Blanks_status_Label.Size = new System.Drawing.Size(47, 13);
            this.Blanks_status_Label.TabIndex = 7;
            this.Blanks_status_Label.Text = "Formatki";
            // 
            // Blanks_text_textBox
            // 
            this.Blanks_text_textBox.Location = new System.Drawing.Point(30, 60);
            this.Blanks_text_textBox.Multiline = true;
            this.Blanks_text_textBox.Name = "Blanks_text_textBox";
            this.Blanks_text_textBox.Size = new System.Drawing.Size(521, 20);
            this.Blanks_text_textBox.TabIndex = 6;
            // 
            // Blanks_title_textBox
            // 
            this.Blanks_title_textBox.Location = new System.Drawing.Point(30, 19);
            this.Blanks_title_textBox.Name = "Blanks_title_textBox";
            this.Blanks_title_textBox.Size = new System.Drawing.Size(521, 20);
            this.Blanks_title_textBox.TabIndex = 5;
            // 
            // Blank_Add_button
            // 
            this.Blank_Add_button.Location = new System.Drawing.Point(293, 230);
            this.Blank_Add_button.Name = "Blank_Add_button";
            this.Blank_Add_button.Size = new System.Drawing.Size(126, 23);
            this.Blank_Add_button.TabIndex = 4;
            this.Blank_Add_button.Text = "Dodaj formatkę";
            this.Blank_Add_button.UseVisualStyleBackColor = true;
            this.Blank_Add_button.Click += new System.EventHandler(this.Blank_Add_button_Click);
            // 
            // Show_blanks_Button
            // 
            this.Show_blanks_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Show_blanks_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Show_blanks_Button.Location = new System.Drawing.Point(570, 0);
            this.Show_blanks_Button.Name = "Show_blanks_Button";
            this.Show_blanks_Button.Size = new System.Drawing.Size(30, 266);
            this.Show_blanks_Button.TabIndex = 3;
            this.Show_blanks_Button.Text = "<<";
            this.Show_blanks_Button.UseVisualStyleBackColor = true;
            this.Show_blanks_Button.Click += new System.EventHandler(this.Show_Fromants_Button_Click);
            // 
            // Blanks_edit_Button
            // 
            this.Blanks_edit_Button.Location = new System.Drawing.Point(425, 230);
            this.Blanks_edit_Button.Name = "Blanks_edit_Button";
            this.Blanks_edit_Button.Size = new System.Drawing.Size(126, 23);
            this.Blanks_edit_Button.TabIndex = 2;
            this.Blanks_edit_Button.Text = "Edytuj fromatkę";
            this.Blanks_edit_Button.UseVisualStyleBackColor = true;
            this.Blanks_edit_Button.Click += new System.EventHandler(this.Blanks_edit_Button_Click);
            // 
            // Blanks_title_ComboBox
            // 
            this.Blanks_title_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Blanks_title_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Blanks_title_ComboBox.FormattingEnabled = true;
            this.Blanks_title_ComboBox.Location = new System.Drawing.Point(30, 40);
            this.Blanks_title_ComboBox.Margin = new System.Windows.Forms.Padding(20);
            this.Blanks_title_ComboBox.Name = "Blanks_title_ComboBox";
            this.Blanks_title_ComboBox.Size = new System.Drawing.Size(521, 21);
            this.Blanks_title_ComboBox.TabIndex = 1;
            this.Blanks_title_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Blanks_title_ComboBox_SelectedIndexChanged);
            this.Blanks_title_ComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Blanks_title_ComboBox_KeyUp);
            // 
            // Blanks_text_Label
            // 
            this.Blanks_text_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Blanks_text_Label.Location = new System.Drawing.Point(30, 80);
            this.Blanks_text_Label.Margin = new System.Windows.Forms.Padding(0);
            this.Blanks_text_Label.Name = "Blanks_text_Label";
            this.Blanks_text_Label.Size = new System.Drawing.Size(521, 125);
            this.Blanks_text_Label.TabIndex = 0;
            this.Blanks_text_Label.Text = "blanks_text_Label";
            this.Blanks_text_Label.DoubleClick += new System.EventHandler(this.Blanks_text_Label_DoubleClick);
            // 
            // Copy_status_label
            // 
            this.Copy_status_label.AutoSize = true;
            this.Copy_status_label.Location = new System.Drawing.Point(27, 235);
            this.Copy_status_label.Name = "Copy_status_label";
            this.Copy_status_label.Size = new System.Drawing.Size(93, 13);
            this.Copy_status_label.TabIndex = 8;
            this.Copy_status_label.Text = "Copy_status_label";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 312);
            this.Controls.Add(this.BlanksPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.BlanksPanel.ResumeLayout(false);
            this.BlanksPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UserStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DataStripStatusLabel;
        private System.Windows.Forms.Timer Date_Time_timer;
        private System.Windows.Forms.ToolStripStatusLabel SpringStatusLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Label Count_label;
        private System.Windows.Forms.Label Last_Cick_Label;
        private System.Windows.Forms.ToolStripStatusLabel Save_status_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokalizacjaZapisuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save_dir_ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog Directory_FileDialog;
        private System.Windows.Forms.ToolStripMenuItem lokalizacjaFormatekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blanks_dir_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem show_formants_ToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BlanksPanel;
        private System.Windows.Forms.Label Blanks_text_Label;
        private System.Windows.Forms.ComboBox Blanks_title_ComboBox;
        private System.Windows.Forms.Button Blanks_edit_Button;
        private System.Windows.Forms.Button Show_blanks_Button;
        private System.Windows.Forms.Button Blank_Add_button;
        private System.Windows.Forms.TextBox Blanks_text_textBox;
        private System.Windows.Forms.TextBox Blanks_title_textBox;
        private System.Windows.Forms.Label Blanks_status_Label;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem powiadomienieOKwarantannieWłToolStripMenuItem;
        private System.Windows.Forms.Label Copy_status_label;
    }
}

