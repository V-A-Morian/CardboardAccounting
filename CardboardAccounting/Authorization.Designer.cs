namespace CardboardAccounting
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.login_button = new System.Windows.Forms.Button();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.nameForm_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.createUser_linkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearTextBox_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox_hideText = new System.Windows.Forms.PictureBox();
            this.pictureBox_showText = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearTextBox_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hideText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showText)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Brown;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.login_button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(148, 139);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(145, 30);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Войти";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.username_textBox.Location = new System.Drawing.Point(148, 77);
            this.username_textBox.Multiline = true;
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(145, 25);
            this.username_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.password_textBox.Location = new System.Drawing.Point(148, 108);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(145, 25);
            this.password_textBox.TabIndex = 2;
            // 
            // nameForm_label
            // 
            this.nameForm_label.AutoSize = true;
            this.nameForm_label.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameForm_label.ForeColor = System.Drawing.Color.Brown;
            this.nameForm_label.Location = new System.Drawing.Point(97, 9);
            this.nameForm_label.Name = "nameForm_label";
            this.nameForm_label.Size = new System.Drawing.Size(233, 35);
            this.nameForm_label.TabIndex = 3;
            this.nameForm_label.Text = "Авторизация";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username_label.ForeColor = System.Drawing.Color.Brown;
            this.username_label.Location = new System.Drawing.Point(11, 78);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(131, 16);
            this.username_label.TabIndex = 4;
            this.username_label.Text = "Имя пользователя";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.ForeColor = System.Drawing.Color.Brown;
            this.Password_label.Location = new System.Drawing.Point(87, 108);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(55, 16);
            this.Password_label.TabIndex = 5;
            this.Password_label.Text = "Пароль";
            // 
            // createUser_linkLabel
            // 
            this.createUser_linkLabel.AutoSize = true;
            this.createUser_linkLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createUser_linkLabel.ForeColor = System.Drawing.Color.Coral;
            this.createUser_linkLabel.LinkColor = System.Drawing.Color.DarkRed;
            this.createUser_linkLabel.Location = new System.Drawing.Point(164, 172);
            this.createUser_linkLabel.Name = "createUser_linkLabel";
            this.createUser_linkLabel.Size = new System.Drawing.Size(107, 13);
            this.createUser_linkLabel.TabIndex = 6;
            this.createUser_linkLabel.TabStop = true;
            this.createUser_linkLabel.Text = "Создать аккаунт";
            this.createUser_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createUser_linkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // clearTextBox_pictureBox
            // 
            this.clearTextBox_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearTextBox_pictureBox.BackgroundImage")));
            this.clearTextBox_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearTextBox_pictureBox.Location = new System.Drawing.Point(330, 108);
            this.clearTextBox_pictureBox.Name = "clearTextBox_pictureBox";
            this.clearTextBox_pictureBox.Size = new System.Drawing.Size(25, 25);
            this.clearTextBox_pictureBox.TabIndex = 8;
            this.clearTextBox_pictureBox.TabStop = false;
            this.clearTextBox_pictureBox.Click += new System.EventHandler(this.clearTextBox_pictureBox_Click);
            // 
            // pictureBox_hideText
            // 
            this.pictureBox_hideText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_hideText.BackgroundImage")));
            this.pictureBox_hideText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_hideText.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_hideText.Image")));
            this.pictureBox_hideText.Location = new System.Drawing.Point(299, 108);
            this.pictureBox_hideText.Name = "pictureBox_hideText";
            this.pictureBox_hideText.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_hideText.TabIndex = 9;
            this.pictureBox_hideText.TabStop = false;
            this.pictureBox_hideText.Click += new System.EventHandler(this.pictureBox_hideText_Click);
            // 
            // pictureBox_showText
            // 
            this.pictureBox_showText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_showText.BackgroundImage")));
            this.pictureBox_showText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_showText.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_showText.Image")));
            this.pictureBox_showText.Location = new System.Drawing.Point(299, 108);
            this.pictureBox_showText.Name = "pictureBox_showText";
            this.pictureBox_showText.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_showText.TabIndex = 10;
            this.pictureBox_showText.TabStop = false;
            this.pictureBox_showText.Click += new System.EventHandler(this.pictureBox_showText_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 203);
            this.Controls.Add(this.pictureBox_showText);
            this.Controls.Add(this.pictureBox_hideText);
            this.Controls.Add(this.clearTextBox_pictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.createUser_linkLabel);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.nameForm_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.login_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearTextBox_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hideText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_showText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label nameForm_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.LinkLabel createUser_linkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox clearTextBox_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox_hideText;
        private System.Windows.Forms.PictureBox pictureBox_showText;
    }
}