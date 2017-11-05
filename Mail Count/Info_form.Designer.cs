namespace Mail_Count
{
    partial class Info_form
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
            this.Return_button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Help_button = new System.Windows.Forms.Button();
            this.Change_log_button = new System.Windows.Forms.Button();
            this.Upper_buttons_Panel = new System.Windows.Forms.Panel();
            this.Textbox_Panel = new System.Windows.Forms.Panel();
            this.Upper_buttons_Panel.SuspendLayout();
            this.Textbox_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Return_button
            // 
            this.Return_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Return_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Return_button.Location = new System.Drawing.Point(0, 376);
            this.Return_button.Name = "Return_button";
            this.Return_button.Size = new System.Drawing.Size(334, 35);
            this.Return_button.TabIndex = 1;
            this.Return_button.Text = "OK";
            this.Return_button.UseVisualStyleBackColor = true;
            this.Return_button.Click += new System.EventHandler(this.Return_button_Click);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(334, 346);
            this.textBox.TabIndex = 2;
            // 
            // Help_button
            // 
            this.Help_button.Dock = System.Windows.Forms.DockStyle.Left;
            this.Help_button.Location = new System.Drawing.Point(0, 0);
            this.Help_button.Name = "Help_button";
            this.Help_button.Size = new System.Drawing.Size(165, 30);
            this.Help_button.TabIndex = 3;
            this.Help_button.Text = "Pomoc";
            this.Help_button.UseVisualStyleBackColor = true;
            this.Help_button.Click += new System.EventHandler(this.Help_button_Click);
            // 
            // Change_log_button
            // 
            this.Change_log_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Change_log_button.Location = new System.Drawing.Point(169, 0);
            this.Change_log_button.Name = "Change_log_button";
            this.Change_log_button.Size = new System.Drawing.Size(165, 30);
            this.Change_log_button.TabIndex = 4;
            this.Change_log_button.Text = "Historia wersji";
            this.Change_log_button.UseVisualStyleBackColor = true;
            this.Change_log_button.Click += new System.EventHandler(this.Change_log_button_Click);
            // 
            // Upper_buttons_Panel
            // 
            this.Upper_buttons_Panel.Controls.Add(this.Change_log_button);
            this.Upper_buttons_Panel.Controls.Add(this.Help_button);
            this.Upper_buttons_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Upper_buttons_Panel.Location = new System.Drawing.Point(0, 0);
            this.Upper_buttons_Panel.Name = "Upper_buttons_Panel";
            this.Upper_buttons_Panel.Size = new System.Drawing.Size(334, 30);
            this.Upper_buttons_Panel.TabIndex = 5;
            // 
            // Textbox_Panel
            // 
            this.Textbox_Panel.Controls.Add(this.textBox);
            this.Textbox_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox_Panel.Location = new System.Drawing.Point(0, 30);
            this.Textbox_Panel.Name = "Textbox_Panel";
            this.Textbox_Panel.Size = new System.Drawing.Size(334, 346);
            this.Textbox_Panel.TabIndex = 6;
            // 
            // Info_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.Textbox_Panel);
            this.Controls.Add(this.Upper_buttons_Panel);
            this.Controls.Add(this.Return_button);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 100);
            this.Name = "Info_form";
            this.Text = "Pomoc";
            this.Upper_buttons_Panel.ResumeLayout(false);
            this.Textbox_Panel.ResumeLayout(false);
            this.Textbox_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Return_button;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Help_button;
        private System.Windows.Forms.Button Change_log_button;
        private System.Windows.Forms.Panel Upper_buttons_Panel;
        private System.Windows.Forms.Panel Textbox_Panel;
    }
}