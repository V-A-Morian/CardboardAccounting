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

    public partial class add_blanks : Form
    {
        DataBase database = new DataBase();
        public add_blanks()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void add_blanks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet1.cardboard". При необходимости она может быть перемещена или удалена.
            this.cardboardTableAdapter.Fill(this.cADataSet1.cardboard);

        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            database.openConnectiom();

            var name = textBox_name.Text;
            var id = Convert.ToString(comboBox_id.Text);

            int price;

            if (int.TryParse(textBox_price.Text, out price))
            {

                var addQueryHist = $"insert into blanks (name, price, id_cb) values('{name}', '{price}', '{id}')";
                var commandHist = new SqlCommand(addQueryHist, database.GetConnection());
                commandHist.ExecuteNonQuery();

                MessageBox.Show("Заготовка добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else { MessageBox.Show("Цена должна иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            database.closeConnectiom();
        }
    }
}
