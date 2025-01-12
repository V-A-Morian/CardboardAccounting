namespace CardboardAccounting
{
    partial class Receipts_journal
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
            this.button_delivery = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.button_locb = new System.Windows.Forms.Button();
            this.dataGridView_send = new System.Windows.Forms.DataGridView();
            this.invidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sendhistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cADataSet2 = new CardboardAccounting.CADataSet2();
            this.send_historyTableAdapter = new CardboardAccounting.CADataSet2TableAdapters.send_historyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendhistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delivery
            // 
            this.button_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_delivery.Location = new System.Drawing.Point(172, 592);
            this.button_delivery.Name = "button_delivery";
            this.button_delivery.Size = new System.Drawing.Size(154, 50);
            this.button_delivery.TabIndex = 1;
            this.button_delivery.Text = "Добавить поставку или отправление\r\n";
            this.button_delivery.UseVisualStyleBackColor = true;
            this.button_delivery.Click += new System.EventHandler(this.button_delivery_Click);
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_send.Location = new System.Drawing.Point(12, 592);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(154, 45);
            this.button_send.TabIndex = 2;
            this.button_send.Text = "ЗП";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_locb
            // 
            this.button_locb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_locb.Location = new System.Drawing.Point(12, 685);
            this.button_locb.Name = "button_locb";
            this.button_locb.Size = new System.Drawing.Size(127, 48);
            this.button_locb.TabIndex = 3;
            this.button_locb.Text = "Текущие остатки";
            this.button_locb.UseVisualStyleBackColor = true;
            // 
            // dataGridView_send
            // 
            this.dataGridView_send.AllowUserToAddRows = false;
            this.dataGridView_send.AllowUserToDeleteRows = false;
            this.dataGridView_send.AutoGenerateColumns = false;
            this.dataGridView_send.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_send.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_send.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invidDataGridViewTextBoxColumn,
            this.cdnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView_send.DataSource = this.sendhistoryBindingSource;
            this.dataGridView_send.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_send.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_send.Name = "dataGridView_send";
            this.dataGridView_send.ReadOnly = true;
            this.dataGridView_send.Size = new System.Drawing.Size(486, 377);
            this.dataGridView_send.TabIndex = 4;
            // 
            // invidDataGridViewTextBoxColumn
            // 
            this.invidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.invidDataGridViewTextBoxColumn.DataPropertyName = "inv_id";
            this.invidDataGridViewTextBoxColumn.HeaderText = "id";
            this.invidDataGridViewTextBoxColumn.Name = "invidDataGridViewTextBoxColumn";
            this.invidDataGridViewTextBoxColumn.ReadOnly = true;
            this.invidDataGridViewTextBoxColumn.Width = 42;
            // 
            // cdnameDataGridViewTextBoxColumn
            // 
            this.cdnameDataGridViewTextBoxColumn.DataPropertyName = "cd_name";
            this.cdnameDataGridViewTextBoxColumn.HeaderText = "Марка картона";
            this.cdnameDataGridViewTextBoxColumn.Name = "cdnameDataGridViewTextBoxColumn";
            this.cdnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена в руб.";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sendhistoryBindingSource
            // 
            this.sendhistoryBindingSource.DataMember = "send_history";
            this.sendhistoryBindingSource.DataSource = this.cADataSet2;
            // 
            // cADataSet2
            // 
            this.cADataSet2.DataSetName = "CADataSet2";
            this.cADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // send_historyTableAdapter
            // 
            this.send_historyTableAdapter.ClearBeforeFill = true;
            // 
            // Receipts_journal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 377);
            this.Controls.Add(this.dataGridView_send);
            this.Controls.Add(this.button_locb);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_delivery);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Name = "Receipts_journal";
            this.Text = "Receipts journal";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendhistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_delivery;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_locb;
        private System.Windows.Forms.DataGridView dataGridView_send;
        private CADataSet2 cADataSet2;
        private System.Windows.Forms.BindingSource sendhistoryBindingSource;
        private CADataSet2TableAdapters.send_historyTableAdapter send_historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}