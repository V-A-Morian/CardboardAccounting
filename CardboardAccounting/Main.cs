using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CardboardAccounting
{
    public partial class Receipts_journal : Form
    {
        DataBase database = new DataBase();


        public Receipts_journal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet2.send_history". При необходимости она может быть перемещена или удалена.
            this.send_historyTableAdapter.Fill(this.cADataSet2.send_history);


        }

        private void аааToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials m = new Materials();
            m.Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blanks blanks = new blanks();
            blanks.Show();
        }

        private void button_delivery_Click(object sender, EventArgs e)
        {
            Main2 sc = new Main2();

            sc.Show();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
         
          
        }

        private void остаткиToolStripMenuItem_Click(object sender, EventArgs e)
        {

                Process.Start(@"D:\Desktop\Отчёт по общему количеству чего то.xlsx");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void dataGridView_dispatchHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
