namespace CardboardAccounting
{
    partial class Add_Dispatch
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
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.blanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADataSet2 = new CardboardAccounting.CADataSet2();
            this.cardboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label_cost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_name_blank = new System.Windows.Forms.ComboBox();
            this.blanksTableAdapter = new CardboardAccounting.CADataSet2TableAdapters.blanksTableAdapter();
            this.cardboardTableAdapter = new CardboardAccounting.CADataSet2TableAdapters.cardboardTableAdapter();
            this.cardboardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cADataSet3 = new CardboardAccounting.CADataSet3();
            this.locbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.almostFinal = new CardboardAccounting.AlmostFinal();
            this.locbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locbTableAdapter = new CardboardAccounting.CADataSet2TableAdapters.locbTableAdapter();
            this.cardboardTableAdapter1 = new CardboardAccounting.CADataSet3TableAdapters.cardboardTableAdapter();
            this.locbTableAdapter1 = new CardboardAccounting.AlmostFinalTableAdapters.locbTableAdapter();
            this.cADataSet4 = new CardboardAccounting.CADataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_order = new System.Windows.Forms.ComboBox();
            this.comboBox_state = new System.Windows.Forms.ComboBox();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new CardboardAccounting.CADataSet4TableAdapters.ordersTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cADataSet5 = new CardboardAccounting.CADataSet5();
            this.blanksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.blanksTableAdapter1 = new CardboardAccounting.CADataSet5TableAdapters.blanksTableAdapter();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new CardboardAccounting.CADataSet5TableAdapters.ordersTableAdapter();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.blanksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.blanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardboardBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almostFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanksBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_type
            // 
            this.comboBox_type.Cursor = System.Windows.Forms.Cursors.No;
            this.comboBox_type.DataSource = this.blanksBindingSource2;
            this.comboBox_type.DisplayMember = "id";
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(345, 169);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(39, 23);
            this.comboBox_type.TabIndex = 2;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            this.comboBox_type.SelectionChangeCommitted += new System.EventHandler(this.comboBox_type_SelectionChangeCommitted);
            this.comboBox_type.SelectedValueChanged += new System.EventHandler(this.comboBox_type_SelectedValueChanged);
            // 
            // blanksBindingSource
            // 
            this.blanksBindingSource.DataMember = "blanks";
            this.blanksBindingSource.DataSource = this.cADataSet2;
            // 
            // cADataSet2
            // 
            this.cADataSet2.DataSetName = "CADataSet2";
            this.cADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardboardBindingSource
            // 
            this.cardboardBindingSource.DataMember = "cardboard";
            this.cardboardBindingSource.DataSource = this.cADataSet2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(65, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(8, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Дата отгрузки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(8, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Сумма отправления в руб.:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(135, 264);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(61, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 40);
            this.label7.TabIndex = 13;
            this.label7.Text = "Добавить отгрузку";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_date.Location = new System.Drawing.Point(103, 211);
            this.dateTimePicker_date.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(121, 23);
            this.dateTimePicker_date.TabIndex = 15;
            this.dateTimePicker_date.ValueChanged += new System.EventHandler(this.dateTimePicker_date_ValueChanged);
            // 
            // label_cost
            // 
            this.label_cost.AutoSize = true;
            this.label_cost.Location = new System.Drawing.Point(179, 603);
            this.label_cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cost.Name = "label_cost";
            this.label_cost.Size = new System.Drawing.Size(0, 15);
            this.label_cost.TabIndex = 16;
            this.label_cost.Click += new System.EventHandler(this.label_cost_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(75, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Заготовка:";
            // 
            // comboBox_name_blank
            // 
            this.comboBox_name_blank.DataSource = this.blanksBindingSource1;
            this.comboBox_name_blank.DisplayMember = "name";
            this.comboBox_name_blank.FormattingEnabled = true;
            this.comboBox_name_blank.Location = new System.Drawing.Point(149, 169);
            this.comboBox_name_blank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_name_blank.Name = "comboBox_name_blank";
            this.comboBox_name_blank.Size = new System.Drawing.Size(188, 23);
            this.comboBox_name_blank.TabIndex = 18;
            this.comboBox_name_blank.ValueMember = "id";
            // 
            // blanksTableAdapter
            // 
            this.blanksTableAdapter.ClearBeforeFill = true;
            // 
            // cardboardTableAdapter
            // 
            this.cardboardTableAdapter.ClearBeforeFill = true;
            // 
            // cardboardBindingSource1
            // 
            this.cardboardBindingSource1.DataMember = "cardboard";
            this.cardboardBindingSource1.DataSource = this.cADataSet3;
            // 
            // cADataSet3
            // 
            this.cADataSet3.DataSetName = "CADataSet3";
            this.cADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locbBindingSource1
            // 
            this.locbBindingSource1.DataMember = "locb";
            this.locbBindingSource1.DataSource = this.almostFinal;
            // 
            // almostFinal
            // 
            this.almostFinal.DataSetName = "AlmostFinal";
            this.almostFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locbBindingSource
            // 
            this.locbBindingSource.DataMember = "locb";
            this.locbBindingSource.DataSource = this.cADataSet2;
            // 
            // locbTableAdapter
            // 
            this.locbTableAdapter.ClearBeforeFill = true;
            // 
            // cardboardTableAdapter1
            // 
            this.cardboardTableAdapter1.ClearBeforeFill = true;
            // 
            // locbTableAdapter1
            // 
            this.locbTableAdapter1.ClearBeforeFill = true;
            // 
            // cADataSet4
            // 
            this.cADataSet4.DataSetName = "CADataSet4";
            this.cADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Заказ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Статус заказа:";
            // 
            // comboBox_order
            // 
            this.comboBox_order.DataSource = this.ordersBindingSource;
            this.comboBox_order.DisplayMember = "num";
            this.comboBox_order.FormattingEnabled = true;
            this.comboBox_order.Location = new System.Drawing.Point(149, 81);
            this.comboBox_order.Name = "comboBox_order";
            this.comboBox_order.Size = new System.Drawing.Size(121, 23);
            this.comboBox_order.TabIndex = 21;
            // 
            // comboBox_state
            // 
            this.comboBox_state.FormattingEnabled = true;
            this.comboBox_state.Items.AddRange(new object[] {
            "Отгружен"});
            this.comboBox_state.Location = new System.Drawing.Point(149, 111);
            this.comboBox_state.Name = "comboBox_state";
            this.comboBox_state.Size = new System.Drawing.Size(121, 23);
            this.comboBox_state.TabIndex = 22;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.cADataSet4;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ordersBindingSource;
            this.comboBox1.DisplayMember = "count";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.ValueMember = "num";
            // 
            // cADataSet5
            // 
            this.cADataSet5.DataSetName = "CADataSet5";
            this.cADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blanksBindingSource1
            // 
            this.blanksBindingSource1.DataMember = "blanks";
            this.blanksBindingSource1.DataSource = this.cADataSet5;
            // 
            // blanksTableAdapter1
            // 
            this.blanksTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "orders";
            this.ordersBindingSource1.DataSource = this.cADataSet5;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "orders";
            this.ordersBindingSource2.DataSource = this.cADataSet5;
            // 
            // blanksBindingSource2
            // 
            this.blanksBindingSource2.DataMember = "blanks";
            this.blanksBindingSource2.DataSource = this.cADataSet5;
            // 
            // Add_Dispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 627);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox_state);
            this.Controls.Add(this.comboBox_order);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_name_blank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_cost);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_type);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Add_Dispatch";
            this.Text = "Dispatch";
            this.Load += new System.EventHandler(this.Dispatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardboardBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almostFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blanksBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label_cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_name_blank;
        private CADataSet2 cADataSet2;
        private System.Windows.Forms.BindingSource blanksBindingSource;
        private CADataSet2TableAdapters.blanksTableAdapter blanksTableAdapter;
        private System.Windows.Forms.BindingSource cardboardBindingSource;
        private CADataSet2TableAdapters.cardboardTableAdapter cardboardTableAdapter;
        private System.Windows.Forms.BindingSource locbBindingSource;
        private CADataSet2TableAdapters.locbTableAdapter locbTableAdapter;
        private CADataSet3 cADataSet3;
        private System.Windows.Forms.BindingSource cardboardBindingSource1;
        private CADataSet3TableAdapters.cardboardTableAdapter cardboardTableAdapter1;
        private AlmostFinal almostFinal;
        private System.Windows.Forms.BindingSource locbBindingSource1;
        private AlmostFinalTableAdapters.locbTableAdapter locbTableAdapter1;
        private CADataSet4 cADataSet4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_order;
        private System.Windows.Forms.ComboBox comboBox_state;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private CADataSet4TableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private CADataSet5 cADataSet5;
        private System.Windows.Forms.BindingSource blanksBindingSource1;
        private CADataSet5TableAdapters.blanksTableAdapter blanksTableAdapter1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private CADataSet5TableAdapters.ordersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private System.Windows.Forms.BindingSource blanksBindingSource2;
    }
}