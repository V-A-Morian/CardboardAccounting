namespace CardboardAccounting
{
    partial class Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_num = new System.Windows.Forms.TextBox();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almostFinal = new CardboardAccounting.AlmostFinal();
            this.comboBox_State = new System.Windows.Forms.ComboBox();
            this.caDataSet1 = new CardboardAccounting.CADataSet();
            this.dateTimePicker_dateOrder = new System.Windows.Forms.DateTimePicker();
            this.customersTableAdapter = new CardboardAccounting.AlmostFinalTableAdapters.customersTableAdapter();
            this.comboBox_id_customer = new System.Windows.Forms.ComboBox();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_id_blank = new System.Windows.Forms.ComboBox();
            this.blanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almostFinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox_blank = new System.Windows.Forms.ComboBox();
            this.blanksTableAdapter = new CardboardAccounting.AlmostFinalTableAdapters.blanksTableAdapter();
            this.comboBox_materials = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_price = new System.Windows.Forms.ComboBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label_cost = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almostFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almostFinalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить заказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер договора:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(58, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заказчик:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(44, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата заказа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата исполнения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(35, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Статус заказа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(81, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Цена:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Дата отгрузки";
            // 
            // textBox_num
            // 
            this.textBox_num.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_num.Location = new System.Drawing.Point(133, 82);
            this.textBox_num.Name = "textBox_num";
            this.textBox_num.Size = new System.Drawing.Size(63, 23);
            this.textBox_num.TabIndex = 8;
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.DataSource = this.customersBindingSource;
            this.comboBox_customer.DisplayMember = "name";
            this.comboBox_customer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(133, 122);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(100, 23);
            this.comboBox_customer.TabIndex = 11;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.almostFinal;
            // 
            // almostFinal
            // 
            this.almostFinal.DataSetName = "AlmostFinal";
            this.almostFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox_State
            // 
            this.comboBox_State.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox_State.FormattingEnabled = true;
            this.comboBox_State.Items.AddRange(new object[] {
            "Принят"});
            this.comboBox_State.Location = new System.Drawing.Point(133, 204);
            this.comboBox_State.Name = "comboBox_State";
            this.comboBox_State.Size = new System.Drawing.Size(63, 23);
            this.comboBox_State.TabIndex = 12;
            // 
            // caDataSet1
            // 
            this.caDataSet1.DataSetName = "CADataSet";
            this.caDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker_dateOrder
            // 
            this.dateTimePicker_dateOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_dateOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dateOrder.Location = new System.Drawing.Point(133, 164);
            this.dateTimePicker_dateOrder.Name = "dateTimePicker_dateOrder";
            this.dateTimePicker_dateOrder.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker_dateOrder.TabIndex = 13;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_id_customer
            // 
            this.comboBox_id_customer.DataSource = this.customersBindingSource;
            this.comboBox_id_customer.DisplayMember = "id";
            this.comboBox_id_customer.FormattingEnabled = true;
            this.comboBox_id_customer.Location = new System.Drawing.Point(680, 49);
            this.comboBox_id_customer.Name = "comboBox_id_customer";
            this.comboBox_id_customer.Size = new System.Drawing.Size(121, 21);
            this.comboBox_id_customer.TabIndex = 14;
            this.comboBox_id_customer.ValueMember = "name";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.IndianRed;
            this.button_add.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(176, 278);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(184, 33);
            this.button_add.TabIndex = 15;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_id_blank
            // 
            this.comboBox_id_blank.DataSource = this.blanksBindingSource;
            this.comboBox_id_blank.DisplayMember = "id";
            this.comboBox_id_blank.FormattingEnabled = true;
            this.comboBox_id_blank.Location = new System.Drawing.Point(680, 142);
            this.comboBox_id_blank.Name = "comboBox_id_blank";
            this.comboBox_id_blank.Size = new System.Drawing.Size(121, 21);
            this.comboBox_id_blank.TabIndex = 16;
            this.comboBox_id_blank.ValueMember = "name";
            // 
            // blanksBindingSource
            // 
            this.blanksBindingSource.DataMember = "blanks";
            this.blanksBindingSource.DataSource = this.almostFinalBindingSource;
            // 
            // almostFinalBindingSource
            // 
            this.almostFinalBindingSource.DataSource = this.almostFinal;
            this.almostFinalBindingSource.Position = 0;
            // 
            // comboBox_blank
            // 
            this.comboBox_blank.DataSource = this.blanksBindingSource;
            this.comboBox_blank.DisplayMember = "name";
            this.comboBox_blank.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox_blank.FormattingEnabled = true;
            this.comboBox_blank.Location = new System.Drawing.Point(398, 82);
            this.comboBox_blank.Name = "comboBox_blank";
            this.comboBox_blank.Size = new System.Drawing.Size(121, 23);
            this.comboBox_blank.TabIndex = 17;
            // 
            // blanksTableAdapter
            // 
            this.blanksTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_materials
            // 
            this.comboBox_materials.DataSource = this.blanksBindingSource;
            this.comboBox_materials.DisplayMember = "id_cb";
            this.comboBox_materials.FormattingEnabled = true;
            this.comboBox_materials.Location = new System.Drawing.Point(680, 194);
            this.comboBox_materials.Name = "comboBox_materials";
            this.comboBox_materials.Size = new System.Drawing.Size(121, 21);
            this.comboBox_materials.TabIndex = 18;
            this.comboBox_materials.ValueMember = "name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(320, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Заготовка:";
            // 
            // comboBox_price
            // 
            this.comboBox_price.DataSource = this.blanksBindingSource;
            this.comboBox_price.DisplayMember = "price";
            this.comboBox_price.FormattingEnabled = true;
            this.comboBox_price.Location = new System.Drawing.Point(680, 167);
            this.comboBox_price.Name = "comboBox_price";
            this.comboBox_price.Size = new System.Drawing.Size(121, 21);
            this.comboBox_price.TabIndex = 20;
            this.comboBox_price.ValueMember = "name";
            // 
            // textBox_count
            // 
            this.textBox_count.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_count.Location = new System.Drawing.Point(398, 122);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(86, 23);
            this.textBox_count.TabIndex = 21;
            this.textBox_count.TextChanged += new System.EventHandler(this.textBox_count_TextChanged);
            this.textBox_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_count_KeyPress);
            this.textBox_count.Leave += new System.EventHandler(this.textBox_count_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(310, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Количество:";
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label_cost.Location = new System.Drawing.Point(140, 238);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(0, 15);
            this.label_cost.TabIndex = 23;
            this.label_cost.Click += new System.EventHandler(this.label_cost_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 164);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 23);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(398, 204);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(105, 23);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Brown;
            this.label11.Location = new System.Drawing.Point(280, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Дата исполнения:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Brown;
            this.label12.Location = new System.Drawing.Point(298, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Дата отгрузки:";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 340);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.comboBox_price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox_materials);
            this.Controls.Add(this.comboBox_blank);
            this.Controls.Add(this.comboBox_id_blank);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.comboBox_id_customer);
            this.Controls.Add(this.dateTimePicker_dateOrder);
            this.Controls.Add(this.comboBox_State);
            this.Controls.Add(this.comboBox_customer);
            this.Controls.Add(this.textBox_num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almostFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almostFinalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_num;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.ComboBox comboBox_State;
        private CADataSet caDataSet1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateOrder;
        private AlmostFinal almostFinal;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private AlmostFinalTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_id_customer;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_id_blank;
        private System.Windows.Forms.ComboBox comboBox_blank;
        private System.Windows.Forms.BindingSource almostFinalBindingSource;
        private System.Windows.Forms.BindingSource blanksBindingSource;
        private AlmostFinalTableAdapters.blanksTableAdapter blanksTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_materials;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_price;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}