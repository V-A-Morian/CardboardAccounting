namespace CardboardAccounting
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_createAccount = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.pictureBox_clearTextBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_hideText = new System.Windows.Forms.PictureBox();
            this.pictureBox_showText = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clearTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hideText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showText)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.textBox_username.Location = new System.Drawing.Point(149, 85);
            this.textBox_username.Multiline = true;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(145, 25);
            this.textBox_username.TabIndex = 0;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.textBox_password.Location = new System.Drawing.Point(149, 116);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(145, 25);
            this.textBox_password.TabIndex = 1;
            // 
            // button_createAccount
            // 
            this.button_createAccount.BackColor = System.Drawing.Color.Brown;
            this.button_createAccount.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.button_createAccount.ForeColor = System.Drawing.Color.White;
            this.button_createAccount.Location = new System.Drawing.Point(149, 147);
            this.button_createAccount.Name = "button_createAccount";
            this.button_createAccount.Size = new System.Drawing.Size(145, 30);
            this.button_createAccount.TabIndex = 2;
            this.button_createAccount.Text = "Создать";
            this.button_createAccount.UseVisualStyleBackColor = false;
            this.button_createAccount.Click += new System.EventHandler(this.button_createAccount_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label_username.ForeColor = System.Drawing.Color.Brown;
            this.label_username.Location = new System.Drawing.Point(12, 85);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(131, 16);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Имя пользователя";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label_password.ForeColor = System.Drawing.Color.Brown;
            this.label_password.Location = new System.Drawing.Point(88, 116);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(55, 16);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Пароль";
            // 
            // pictureBox_clearTextBox
            // 
            this.pictureBox_clearTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_clearTextBox.BackgroundImage")));
            this.pictureBox_clearTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_clearTextBox.Location = new System.Drawing.Point(331, 116);
            this.pictureBox_clearTextBox.Name = "pictureBox_clearTextBox";
            this.pictureBox_clearTextBox.Size = new System.Drawing.Size(26, 25);
            this.pictureBox_clearTextBox.TabIndex = 6;
            this.pictureBox_clearTextBox.TabStop = false;
            this.pictureBox_clearTextBox.Click += new System.EventHandler(this.pictureBox_clearTextBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 55);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_hideText
            // 
            this.pictureBox_hideText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_hideText.BackgroundImage")));
            this.pictureBox_hideText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_hideText.Location = new System.Drawing.Point(302, 116);
            this.pictureBox_hideText.Name = "pictureBox_hideText";
            this.pictureBox_hideText.Size = new System.Drawing.Size(23, 25);
            this.pictureBox_hideText.TabIndex = 8;
            this.pictureBox_hideText.TabStop = false;
            this.pictureBox_hideText.Click += new System.EventHandler(this.pictureBox_hideText_Click);
            // 
            // pictureBox_showText
            // 
            this.pictureBox_showText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_showText.BackgroundImage")));
            this.pictureBox_showText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_showText.Location = new System.Drawing.Point(302, 116);
            this.pictureBox_showText.Name = "pictureBox_showText";
            this.pictureBox_showText.Size = new System.Drawing.Size(23, 25);
            this.pictureBox_showText.TabIndex = 9;
            this.pictureBox_showText.TabStop = false;
            this.pictureBox_showText.Click += new System.EventHandler(this.pictureBox_showText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Регистрация";
            // 
            // Register
            // 
            this.AcceptButton = this.button_createAccount;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 203);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_showText);
            this.Controls.Add(this.pictureBox_hideText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox_clearTextBox);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.button_createAccount);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(143, 9);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clearTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hideText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_createAccount;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.PictureBox pictureBox_clearTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_hideText;
        private System.Windows.Forms.PictureBox pictureBox_showText;
        private System.Windows.Forms.Label label1;
    }
}