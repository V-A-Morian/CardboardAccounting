namespace CardboardAccounting
{
    partial class Materials
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
            this.dataGridView_materials = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.textBox_cost = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_change = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_materials)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_materials
            // 
            this.dataGridView_materials.AllowUserToAddRows = false;
            this.dataGridView_materials.AllowUserToDeleteRows = false;
            this.dataGridView_materials.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_materials.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_materials.Location = new System.Drawing.Point(13, 12);
            this.dataGridView_materials.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView_materials.Name = "dataGridView_materials";
            this.dataGridView_materials.ReadOnly = true;
            this.dataGridView_materials.Size = new System.Drawing.Size(336, 150);
            this.dataGridView_materials.TabIndex = 0;
            this.dataGridView_materials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_materials_CellClick);
            this.dataGridView_materials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_materials_CellContentClick);
            this.dataGridView_materials.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_materials_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(100, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(30, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Марка картона:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(14, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Цена за шт. в руб:";
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(132, 209);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(100, 23);
            this.textBox_type.TabIndex = 4;
            // 
            // textBox_cost
            // 
            this.textBox_cost.Location = new System.Drawing.Point(132, 242);
            this.textBox_cost.Name = "textBox_cost";
            this.textBox_cost.Size = new System.Drawing.Size(100, 23);
            this.textBox_cost.TabIndex = 5;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label_id.Location = new System.Drawing.Point(127, 180);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 15);
            this.label_id.TabIndex = 6;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.IndianRed;
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(356, 90);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(120, 33);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.IndianRed;
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(356, 129);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(120, 33);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_change
            // 
            this.button_change.BackColor = System.Drawing.Color.IndianRed;
            this.button_change.ForeColor = System.Drawing.Color.White;
            this.button_change.Location = new System.Drawing.Point(356, 12);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(120, 33);
            this.button_change.TabIndex = 9;
            this.button_change.Text = "Изменить";
            this.button_change.UseVisualStyleBackColor = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.IndianRed;
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(356, 51);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(120, 33);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click_1);
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 282);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_cost);
            this.Controls.Add(this.textBox_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_materials);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Materials";
            this.Text = "Materials";
            this.Load += new System.EventHandler(this.Materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_materials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_materials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.TextBox textBox_cost;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_add;
    }
}