namespace CardboardAccounting
{
    partial class add_blanks
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
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.cardboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADataSet1 = new CardboardAccounting.CADataSet1();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_id = new System.Windows.Forms.ComboBox();
            this.cardboardTableAdapter = new CardboardAccounting.CADataSet1TableAdapters.cardboardTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cardboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.IndianRed;
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(197, 185);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(152, 33);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(197, 67);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(152, 23);
            this.textBox_name.TabIndex = 1;
            // 
            // comboBox_type
            // 
            this.comboBox_type.DataSource = this.cardboardBindingSource;
            this.comboBox_type.DisplayMember = "name";
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(197, 145);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(152, 23);
            this.comboBox_type.TabIndex = 2;
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
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(197, 106);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(152, 23);
            this.textBox_price.TabIndex = 3;
            this.textBox_price.TextChanged += new System.EventHandler(this.textBox_price_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(56, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название заготовки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(108, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цена в руб:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(102, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип картона:";
            // 
            // comboBox_id
            // 
            this.comboBox_id.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cardboardBindingSource, "cb_id", true));
            this.comboBox_id.DataSource = this.cardboardBindingSource;
            this.comboBox_id.DisplayMember = "cb_id";
            this.comboBox_id.FormattingEnabled = true;
            this.comboBox_id.Location = new System.Drawing.Point(412, 39);
            this.comboBox_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox_id.Name = "comboBox_id";
            this.comboBox_id.Size = new System.Drawing.Size(65, 23);
            this.comboBox_id.TabIndex = 7;
            // 
            // cardboardTableAdapter
            // 
            this.cardboardTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(49, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Добавить заготовку";
            // 
            // add_blanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 256);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_add);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "add_blanks";
            this.Text = "add_blanks";
            this.Load += new System.EventHandler(this.add_blanks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_id;
        private CADataSet1 cADataSet1;
        private System.Windows.Forms.BindingSource cardboardBindingSource;
        private CADataSet1TableAdapters.cardboardTableAdapter cardboardTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}