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
namespace CardboardAccounting
{
    public partial class Orders : Form
    {
        DataBase dataBase = new DataBase();
        public Orders()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Orders_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "almostFinal.blanks". При необходимости она может быть перемещена или удалена.
            this.blanksTableAdapter.Fill(this.almostFinal.blanks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "almostFinal.customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.almostFinal.customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnectiom();

            var num = textBox_num.Text;
            var id_customer = comboBox_id_customer.Text;
            var date_get = dateTimePicker_dateOrder.Text;
            var state = comboBox_State.Text;
            var cost = Convert.ToString(label_cost.Text);

            var id_blank = comboBox_id_blank.Text;
            var count = textBox_count.Text;
            var id_cd = comboBox_materials.Text;

            var addQueryHist = $"insert into orders (num, id_customer, date_get, state, cost, id_blank, count) values('{num}','{id_customer}','{date_get}','{state}','{cost}', '{id_blank}', '{count}')";
            var commandHist = new SqlCommand(addQueryHist, dataBase.GetConnection());
            commandHist.ExecuteNonQuery();
           


                var addQuery = $"update locb set count = count - '{count}' where '{id_cd}' =  cd_id";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();



            MessageBox.Show("Заказ успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dataBase.closeConnectiom();
        }

        private void textBox_count_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void label_cost_Click(object sender, EventArgs e)
        {
            label_cost.Text = Convert.ToString(int.Parse(comboBox_price.Text) * int.Parse(textBox_count.Text));
        }

        private void textBox_count_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_count_Leave(object sender, EventArgs e)
        {
            label_cost.Text = Convert.ToString(int.Parse(comboBox_price.Text) * int.Parse(textBox_count.Text));
        }
    }
}
