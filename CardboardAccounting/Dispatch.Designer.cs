namespace CardboardAccounting
{
    partial class Dispatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dispatchhistoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cADataSet3 = new CardboardAccounting.CADataSet3();
            this.cADataSet2 = new CardboardAccounting.CADataSet2();
            this.dispatchhistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dispatch_historyTableAdapter = new CardboardAccounting.CADataSet2TableAdapters.dispatch_historyTableAdapter();
            this.dispatchhistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dispatch_historyTableAdapter1 = new CardboardAccounting.CADataSet3TableAdapters.dispatch_historyTableAdapter();
            this.cADataSet6 = new CardboardAccounting.CADataSet6();
            this.cADataSet6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dispatchhistoryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dispatch_historyTableAdapter2 = new CardboardAccounting.CADataSet6TableAdapters.dispatch_historyTableAdapter();
            this.numorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateshipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchhistoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchhistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchhistoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchhistoryBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numorderDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.datedidDataGridViewTextBoxColumn,
            this.dateshipmentDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dispatchhistoryBindingSource3;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dispatchhistoryBindingSource2
            // 
            this.dispatchhistoryBindingSource2.DataMember = "dispatch_history";
            this.dispatchhistoryBindingSource2.DataSource = this.cADataSet3;
            // 
            // cADataSet3
            // 
            this.cADataSet3.DataSetName = "CADataSet3";
            this.cADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cADataSet2
            // 
            this.cADataSet2.DataSetName = "CADataSet2";
            this.cADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dispatchhistoryBindingSource
            // 
            this.dispatchhistoryBindingSource.DataMember = "dispatch_history";
            this.dispatchhistoryBindingSource.DataSource = this.cADataSet2;
            // 
            // dispatch_historyTableAdapter
            // 
            this.dispatch_historyTableAdapter.ClearBeforeFill = true;
            // 
            // dispatchhistoryBindingSource1
            // 
            this.dispatchhistoryBindingSource1.DataMember = "dispatch_history";
            this.dispatchhistoryBindingSource1.DataSource = this.cADataSet2;
            // 
            // dispatch_historyTableAdapter1
            // 
            this.dispatch_historyTableAdapter1.ClearBeforeFill = true;
            // 
            // cADataSet6
            // 
            this.cADataSet6.DataSetName = "CADataSet6";
            this.cADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cADataSet6BindingSource
            // 
            this.cADataSet6BindingSource.DataSource = this.cADataSet6;
            this.cADataSet6BindingSource.Position = 0;
            // 
            // dispatchhistoryBindingSource3
            // 
            this.dispatchhistoryBindingSource3.DataMember = "dispatch_history";
            this.dispatchhistoryBindingSource3.DataSource = this.cADataSet6BindingSource;
            // 
            // dispatch_historyTableAdapter2
            // 
            this.dispatch_historyTableAdapter2.ClearBeforeFill = true;
            // 
            // numorderDataGridViewTextBoxColumn
            // 
            this.numorderDataGridViewTextBoxColumn.DataPropertyName = "num_order";
            this.numorderDataGridViewTextBoxColumn.HeaderText = "Номер договора";
            this.numorderDataGridViewTextBoxColumn.Name = "numorderDataGridViewTextBoxColumn";
            this.numorderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datedidDataGridViewTextBoxColumn
            // 
            this.datedidDataGridViewTextBoxColumn.DataPropertyName = "date_did";
            this.datedidDataGridViewTextBoxColumn.HeaderText = "Дата исполнения";
            this.datedidDataGridViewTextBoxColumn.Name = "datedidDataGridViewTextBoxColumn";
            this.datedidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateshipmentDataGridViewTextBoxColumn
            // 
            this.dateshipmentDataGridViewTextBoxColumn.DataPropertyName = "date_shipment";
            this.dateshipmentDataGridViewTextBoxColumn.HeaderText = "Дата отгрузки";
            this.dateshipmentDataGridViewTextBoxColumn.Name = "dateshipmentDataGridViewTextBoxColumn";
            this.dateshipmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Заготовка";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Количество (шт.)";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена (руб.)";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Dispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 403);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Dispatch";
            this.Text = "Dispatch journal";
            this.Load += new System.EventHandler(this.Dispatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchhistoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchhistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchhistoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cADataSet6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispatchhistoryBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CADataSet2 cADataSet2;
        private System.Windows.Forms.BindingSource dispatchhistoryBindingSource;
        private CADataSet2TableAdapters.dispatch_historyTableAdapter dispatch_historyTableAdapter;
        private System.Windows.Forms.BindingSource dispatchhistoryBindingSource1;
        private CADataSet3 cADataSet3;
        private System.Windows.Forms.BindingSource dispatchhistoryBindingSource2;
        private CADataSet3TableAdapters.dispatch_historyTableAdapter dispatch_historyTableAdapter1;
        private System.Windows.Forms.BindingSource cADataSet6BindingSource;
        private CADataSet6 cADataSet6;
        private System.Windows.Forms.BindingSource dispatchhistoryBindingSource3;
        private CADataSet6TableAdapters.dispatch_historyTableAdapter dispatch_historyTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateshipmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}