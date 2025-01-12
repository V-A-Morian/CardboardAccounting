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
using System.Diagnostics;


namespace CardboardAccounting
{
    public partial class Add_Send : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Send()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            
            dataBase.openConnectiom();

            var num = textBox_num.Text;
            var type = comboBox_type.Text;
            
            int cost;
            var count = textBox_count.Text;
            var date = dateTimePicker_date.Text;

            if (int.TryParse(label_cost.Text, out cost))
            {
             
                var addQuery = $"update locb Set price = price + '{cost}', count = count + '{count}', date = '{date}', wh_num = '{num}' where cd_name = '{type}'";
             var command = new SqlCommand(addQuery, dataBase.GetConnection());
             command.ExecuteNonQuery();
                
                
                var addQueryHist = $"insert into send_history(wh_num, cd_name, price, count, date) values('{num}', '{type}', '{cost}', '{count}', '{date}')";
             var commandHist = new SqlCommand(addQueryHist, dataBase.GetConnection());
             commandHist.ExecuteNonQuery();               

             MessageBox.Show("Пополнение зафиксировано", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            else { MessageBox.Show("Цена должна иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            

            dataBase.closeConnectiom();
        }

        private void Add_Send_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet1.cardboard". При необходимости она может быть перемещена или удалена.
            this.cardboardTableAdapter.Fill(this.cADataSet1.cardboard);

            dateTimePicker_date.MaxDate = DateTime.Now;
            textBox_num.Text = "Адрес склада";
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_cost.Text = Convert.ToString(int.Parse(comboBox_price.Text) * int.Parse(textBox_count.Text));
        }

        private void maskedTextBox_date_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker_date_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_date.MaxDate = DateTime.Today;
        }

        private void Add_Send_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox_count.Clear();
        }

        private void textBox_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

