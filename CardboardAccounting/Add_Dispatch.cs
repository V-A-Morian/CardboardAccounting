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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CardboardAccounting
{
    public partial class Add_Dispatch : Form

    {
        DataBase dataBase = new DataBase();
        public Add_Dispatch()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            
   
            

        }

        private void Dispatch_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet5.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter1.Fill(this.cADataSet5.orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet5.blanks". При необходимости она может быть перемещена или удалена.
            this.blanksTableAdapter1.Fill(this.cADataSet5.blanks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet4.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.cADataSet4.orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet4.orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.cADataSet4.orders);


            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
            dateTimePicker_date.MaxDate = DateTime.Now;

        }

        private void textBox_count_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox_count_KeyPress(object sender, KeyPressEventArgs e)
        
            {
                if (Char.IsDigit(e.KeyChar))
                {
                }
                else
                {
                    e.Handled = true;
                }
            }

        private void dateTimePicker_date_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_date.MaxDate = DateTime.Now;
        }

        private void comboBox_type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboBox_type_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void textBox_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_cost_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_price_blank_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
