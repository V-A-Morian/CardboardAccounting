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
    public partial class Customers : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        public Customers()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet4.customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.cADataSet4.customers);

        }

        private void button1_Click(object sender, EventArgs e) //Добавление записи в SQL
        {
            dataBase.openConnectiom();

            var name = textBox_customer.Text;
            var phone = Convert.ToString(maskedTextBox_phone.Text);
            var mail = textBox_mail.Text;



                var addQueryHist = $"insert into customers (name, phone, mail) values('{name}', '{phone}', '{mail}')";
                var commandHist = new SqlCommand(addQueryHist, dataBase.GetConnection());
                commandHist.ExecuteNonQuery();


                MessageBox.Show("Заказчик успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dataBase.closeConnectiom();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_customers.Rows[selectedRow];
                textBox_customer.Text = row.Cells[1].Value.ToString();
                maskedTextBox_phone.Text = row.Cells[2].Value.ToString();

                textBox_mail.Text = row.Cells[3].Value.ToString();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
