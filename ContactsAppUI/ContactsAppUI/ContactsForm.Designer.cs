
namespace ContactsAppUI
{
    partial class ContactsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.IdVkLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.BirthLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.IDVkTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.PhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(16, 171);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneLabel.TabIndex = 13;
            this.PhoneLabel.Text = "Phone Number:";
            // 
            // IdVkLabel
            // 
            this.IdVkLabel.AutoSize = true;
            this.IdVkLabel.Location = new System.Drawing.Point(51, 145);
            this.IdVkLabel.Name = "IdVkLabel";
            this.IdVkLabel.Size = new System.Drawing.Size(46, 13);
            this.IdVkLabel.TabIndex = 12;
            this.IdVkLabel.Text = "Vk.com:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(59, 119);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(38, 13);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "E-mail:";
            // 
            // BirthLabel
            // 
            this.BirthLabel.AutoSize = true;
            this.BirthLabel.Location = new System.Drawing.Point(45, 93);
            this.BirthLabel.Name = "BirthLabel";
            this.BirthLabel.Size = new System.Drawing.Size(52, 13);
            this.BirthLabel.TabIndex = 10;
            this.BirthLabel.Text = "Birthdate:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(59, 67);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name:";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(45, 41);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 8;
            this.SurnameLabel.Text = "Surname:";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(103, 38);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(282, 20);
            this.SurnameTextBox.TabIndex = 14;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(103, 64);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(282, 20);
            this.NameTextBox.TabIndex = 15;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(103, 116);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(282, 20);
            this.EmailTextBox.TabIndex = 17;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // IDVkTextBox
            // 
            this.IDVkTextBox.Location = new System.Drawing.Point(103, 142);
            this.IDVkTextBox.Name = "IDVkTextBox";
            this.IDVkTextBox.Size = new System.Drawing.Size(282, 20);
            this.IDVkTextBox.TabIndex = 18;
            this.IDVkTextBox.TextChanged += new System.EventHandler(this.IDVkTextBox_TextChanged);
            // 
            // BirthDateTimePicker
            // 
            this.BirthDateTimePicker.Location = new System.Drawing.Point(103, 90);
            this.BirthDateTimePicker.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.BirthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDateTimePicker.Name = "BirthDateTimePicker";
            this.BirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthDateTimePicker.TabIndex = 20;
            this.BirthDateTimePicker.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.BirthDateTimePicker.ValueChanged += new System.EventHandler(this.BirthDateTimePicker_ValueChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(310, 203);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(229, 203);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 22;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(103, 168);
            this.PhoneNumberTextBox.Mask = "7(000)000-0000";
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(282, 20);
            this.PhoneNumberTextBox.TabIndex = 23;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 258);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BirthDateTimePicker);
            this.Controls.Add(this.IDVkTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.IdVkLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.BirthLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContatsAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label IdVkLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label BirthLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox IDVkTextBox;
        private System.Windows.Forms.DateTimePicker BirthDateTimePicker;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.MaskedTextBox PhoneNumberTextBox;
    }
}