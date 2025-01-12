namespace CardboardAccounting
{
    partial class Add_Send
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
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.cardboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADataSet1 = new CardboardAccounting.CADataSet1();
            this.maskedTextBox_date = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label_cost = new System.Windows.Forms.Label();
            this.cardboardTableAdapter = new CardboardAccounting.CADataSet1TableAdapters.cardboardTableAdapter();
            this.comboBox_price = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_num
            // 
            this.textBox_num.Location = new System.Drawing.Point(188, 66);
            this.textBox_num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(168, 23);
            this.textBox_num.TabIndex = 0;
            this.textBox_num.TextChanged += new System.EventHandler(this.textBox_num_TextChanged);
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(612, 53);
            this.textBox_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(116, 23);
            this.textBox_type.TabIndex = 1;
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(612, 249);
            this.textBox_cost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(116, 23);
            this.textBox_cost.TabIndex = 2;
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(188, 107);
            this.textBox_count.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(168, 23);
            this.textBox_count.TabIndex = 3;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(612, 96);
            this.textBox_date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(116, 23);
            this.textBox_date.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(122, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Склад:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(88, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тип картона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(13, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цена общая:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(89, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(54, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата отправления:";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.IndianRed;
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(188, 233);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(168, 33);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.DataSource = this.cardboardBindingSource;
            this.comboBox_type.DisplayMember = "name";
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(188, 149);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(168, 23);
            this.comboBox_type.TabIndex = 12;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // cardboardBindingSource
            // 
            this.cardboardBindingSource.DataMember = "cardboard";
            this.cardboardBindingSource.DataSource = this.cADataSet1;
            // 
            // cADataSet1
            // 
            this.cADataSet1.DataSetName = "CADataSet1";
            this.cADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maskedTextBox_date
            // 
            this.maskedTextBox_date.Location = new System.Drawing.Point(612, 219);
            this.maskedTextBox_date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBox_date.Mask = "00/00/0000 90:00";
            this.maskedTextBox_date.Name = "maskedTextBox_date";
            this.maskedTextBox_date.Size = new System.Drawing.Size(116, 23);
            this.maskedTextBox_date.TabIndex = 13;
            this.maskedTextBox_date.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_date.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_date_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(50, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 40);
            this.label6.TabIndex = 14;
            this.label6.Text = "Добавить поступление";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_date.Location = new System.Drawing.Point(188, 191);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(168, 23);
            this.dateTimePicker_date.TabIndex = 15;
            this.dateTimePicker_date.ValueChanged += new System.EventHandler(this.dateTimePicker_date_ValueChanged);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.ForeColor = System.Drawing.Color.Brown;
            this.label_cost.Location = new System.Drawing.Point(101, 291);
            this.label_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(0, 15);
            this.label_cost.TabIndex = 16;
            // 
            // cardboardTableAdapter
            // 
            this.cardboardTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_price
            // 
            this.comboBox_price.DataSource = this.cardboardBindingSource;
            this.comboBox_price.DisplayMember = "price";
            this.comboBox_price.FormattingEnabled = true;
            this.comboBox_price.Location = new System.Drawing.Point(588, 153);
            this.comboBox_price.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_price.Name = "comboBox_price";
            this.comboBox_price.Size = new System.Drawing.Size(140, 23);
            this.comboBox_price.TabIndex = 17;
            // 
            // Add_Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 316);
            this.Controls.Add(this.comboBox_price);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox_date);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.textBox_num);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Add_Send";
            this.Text = "Добавление отправления";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_Send_FormClosing);
            this.Load += new System.EventHandler(this.Add_Send_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label_cost;
        private CADataSet1 cADataSet1;
        private System.Windows.Forms.BindingSource cardboardBindingSource;
        private CADataSet1TableAdapters.cardboardTableAdapter cardboardTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_price;
    }
}