using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardboardAccounting
{
    public partial class Dispatch : Form
    {
        public Dispatch()
        {
            InitializeComponent();
        }

        private void Dispatch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet6.dispatch_history". При необходимости она может быть перемещена или удалена.
            this.dispatch_historyTableAdapter2.Fill(this.cADataSet6.dispatch_history);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet3.dispatch_history". При необходимости она может быть перемещена или удалена.
         
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet2.dispatch_history". При необходимости она может быть перемещена или удалена.


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
