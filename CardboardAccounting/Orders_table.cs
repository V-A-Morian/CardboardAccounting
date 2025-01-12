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
using System.Reflection;
using System.Windows.Forms.VisualStyles;

namespace CardboardAccounting
{
    public partial class Orders_table : Form
    {

        DataBase database = new DataBase();
        int selectedRow;

        public Orders_table()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns() //Добавление колонок в datagridview
        {
            dataGridView_orders.Columns.Add("inv_id", "id");
            dataGridView_orders.Columns.Add("num", "Номер договора");
            dataGridView_orders.Columns.Add("id_customer", "id Заказчикa");
            dataGridView_orders.Columns.Add("customer", "Заказчик");
            dataGridView_orders.Columns.Add("date_get", "Дата получения");
            dataGridView_orders.Columns.Add("date_did", "Дата исполнения");
            dataGridView_orders.Columns.Add("state", "Статус заказа");

            dataGridView_orders.Columns.Add("date_shipment", "Дата отгрузки");
            dataGridView_orders.Columns.Add("id_blank", "id_ Тип заготовки");
            dataGridView_orders.Columns.Add("blank", "Тип заготовки");
            dataGridView_orders.Columns.Add("count", "Количество");
            dataGridView_orders.Columns.Add("cost", "Цена в руб.");
            dataGridView_orders.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record) // Присваиваю каждой строчке колонки свой 
        {
            dgw.Rows.Add
                
                (record.GetInt32(0), //dogovor
                record.GetInt32(1),

                record.GetInt32(2), //id zakaz
                record.GetString(3), 

                record.GetDateTime(4), //даты получения и исполнения
                record.GetDateTime(5), 

                record.GetString(6), //статус
                record.GetDateTime(7), // дата отгрузки
                record.GetInt32(8), //айди заготовки
                record.GetString(9), //тип заготовки
                record.GetInt32(10), //количество
                record.GetDecimal(11), //цена
                RowState.ModifiedNew
                );
        }





        private void RefreshDataGrid(DataGridView dgw) //Заполнение datagrid'а данными
        {
            dgw.Rows.Clear();

            string querystring = $"select O.id, O.num, O.id_customer, C.name, O.date_get, O.date_did, O.state, O.date_shipment, O.id_blank, B.name, O.count, O.cost from orders as O, customers as C, blanks as B where B.id = O.id_blank and C.id = O.id_customer";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnectiom();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }



        private void Orders_table_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_orders);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }

        private void dataGridView_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_orders.Rows[selectedRow];
                textBox_num.Text = row.Cells[1].Value.ToString();
                textBox_customer.Text = row.Cells[3].Value.ToString();
                dateTimePicker_date_get.Text = row.Cells[4].Value.ToString();
                dateTimePicker_date_did.Text = row.Cells[5].Value.ToString();
                comboBox_state.Text = row.Cells[6].Value.ToString();
                dateTimePicker_date_shipment.Text = row.Cells[7].Value.ToString();
                textBox_id_blank.Text = row.Cells[8].Value.ToString();
                textBox_type.Text = row.Cells[9].Value.ToString();
                textBox_count.Text = row.Cells[10].Value.ToString();
                textBox_cost.Text = row.Cells[11].Value.ToString();

            }
        }

        private void DeleteRow() //метод удаления строки
        {
            int index = dataGridView_orders.CurrentCell.RowIndex;

            dataGridView_orders.Rows[index].Visible = false;
            if (dataGridView_orders.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView_orders.Rows[index].Cells[12].Value = RowState.Deleted;
                return;
            }
            dataGridView_orders.Rows[index].Cells[12].Value = RowState.Deleted;
        }





        private void Update()          //ошибка большая
        {
            database.openConnectiom();

            for (int index = 0; index < dataGridView_orders.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView_orders.Rows[index].Cells[12].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_orders.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from orders where id = {id}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {



                    var id = dataGridView_orders.Rows[index].Cells[0].Value.ToString();
                    var num = dataGridView_orders.Rows[index].Cells[1].Value.ToString();
                    var id_customer = dataGridView_orders.Rows[index].Cells[2].Value.ToString();
                    var customer = dataGridView_orders.Rows[index].Cells[3].Value.ToString();
                    var date_get = dataGridView_orders.Rows[index].Cells[4].Value.ToString();
                    var date_did = dataGridView_orders.Rows[index].Cells[5].Value.ToString();
                    var state = dataGridView_orders.Rows[index].Cells[6].Value.ToString();
                    var date_shipment = dataGridView_orders.Rows[index].Cells[7].Value.ToString();
                    var id_blank = dataGridView_orders.Rows[index].Cells[8].Value.ToString();
                    var type = dataGridView_orders.Rows[index].Cells[9].Value.ToString();
                    var count = dataGridView_orders.Rows[index].Cells[10].Value.ToString();
                    var cost = dataGridView_orders.Rows[index].Cells[11].Value.ToString();


                    var changeQuery = $"update orders set num = '{num}', id_customer = '{id_customer}', date_get = '{date_get}', date_did = '{date_did}', state = '{state}', cost = '{cost}', date_shipment = '{date_shipment}', id_blank = '{id_blank}', count = '{count}'   where id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();

                }


            }
            dataGridView_orders.AllowUserToAddRows = false;

            database.closeConnectiom();
        }



        private void Change()
        {
            var selectedRowIndex = dataGridView_orders.CurrentCell.RowIndex;
            
            
            var id = textBox_id.Text;

            var num = textBox_num.Text;

           var id_customer = textBox_id_customer.Text;

            var customer = textBox_customer.Text;
            var date_get = dateTimePicker_date_get.Text;
            var date_did = dateTimePicker_date_did.Text;

            var state = comboBox_state.Text;
            var date_shipment = dateTimePicker_date_shipment.Text;

            var id_blank = textBox_id_blank.Text;
            var type = textBox_type.Text;
            var count = textBox_count.Text;
            decimal cost;




            if (dataGridView_orders.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (decimal.TryParse(textBox_cost.Text, out cost))
                {
                    dataGridView_orders.Rows[selectedRowIndex].SetValues(id, num, id_customer, customer, date_get, date_did, state, date_shipment, id_blank, type, count, cost);
                    dataGridView_orders.Rows[selectedRowIndex].Cells[12].Value = RowState.Modified;
                }
                else { MessageBox.Show("Цена должна иметь числовой формат"); }
            }

        }





















        private void Search(DataGridView dgw) //Поиск
        {
            dgw.Rows.Clear();

            String searchstring = $"select O.id, O.num, O.id_customer, C.name, O.date_get, O.date_did, O.state, O.date_shipment, O.id_blank, B.name, O.count, O.cost from orders as O, customers as C, blanks as B where concat (O.id, O.num, O.id_customer, C.name, O.date_get, O.date_did, O.state, O.date_shipment, O.id_blank, B.name, O.count, O.cost) like '%" + textBox_search.Text + "%' and B.id = O.id_blank and C.id = O.id_customer";

            SqlCommand com = new SqlCommand(searchstring, database.GetConnection());

            database.openConnectiom();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();

        }









        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_orders);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView_orders);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            database.openConnectiom();



            var id = textBox_id.Text;

            var num = textBox_num.Text;

            var id_customer = textBox_id_customer.Text;
            var customer = textBox_customer.Text;
            var date_did = dateTimePicker_date_did.Text;
            var date_shipment = dateTimePicker_date_shipment.Text;
            var id_blank = textBox_id_blank.Text;
            var type = textBox_type.Text;
            var count = textBox_count.Text;
            decimal cost;
            if (decimal.TryParse(textBox_cost.Text, out cost))
            {
                var addQueryHist = $"insert into dispatch_history (num_order, customer, date_did, date_shipment, type, count, cost) values('{num}', '{customer}', '{date_did}', '{date_shipment}', '{type}', '{count}', '{cost}')";
                var commandHist = new SqlCommand(addQueryHist, database.GetConnection());
                commandHist.ExecuteNonQuery();
                MessageBox.Show("Заказ успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //var addQuery = $"update locb set count = count - '{count}' where '{id_cd}' =  cd_id";
            //var command = new SqlCommand(addQuery, database.GetConnection());
            //command.ExecuteNonQuery();




           else { MessageBox.Show("ПЛОХО", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            database.closeConnectiom();
        }
    }
}
