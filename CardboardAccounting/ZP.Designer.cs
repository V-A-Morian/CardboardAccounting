namespace CardboardAccounting
{
    partial class ZP
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
            this.dataGridView_zp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_zp
            // 
            this.dataGridView_zp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_zp.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_zp.Name = "dataGridView_zp";
            this.dataGridView_zp.Size = new System.Drawing.Size(641, 254);
            this.dataGridView_zp.TabIndex = 0;
            this.dataGridView_zp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_zp_CellContentClick);
            // 
            // ZP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 781);
            this.Controls.Add(this.dataGridView_zp);
            this.Name = "ZP";
            this.Text = "LeftoversCardboard";
            this.Load += new System.EventHandler(this.LeftoversCardboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_zp;
    }
}