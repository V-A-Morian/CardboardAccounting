using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardboardAccounting
{

    public partial class Main2 : Form
    {
        DataBase database = new DataBase();
        int selectedRow;

        public Main2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns() //Добавление колонок в datagridview
        {
            dataGridView_send.Columns.Add("inv_id", "id");
            dataGridView_send.Columns.Add("wh_num", "Номер склада");
            dataGridView_send.Columns.Add("cd_id", "id картона");
            dataGridView_send.Columns.Add("cd_name", "Марка картона");
            dataGridView_send.Columns.Add("price", "Цена общая в руб.");
            dataGridView_send.Columns.Add("count", "Количество в шт.");
            dataGridView_send.Columns.Add("date", "Дата последнего изменения");
            dataGridView_send.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record) // Присваиваю каждой строчке колонки свой 
        {
            dgw.Rows.Add
                (record.GetInt32(0), 
                record.GetInt32(1),
                record.GetInt32(2),
                record.GetString(3), 
                record.GetDecimal(4), 
                record.GetInt32(5), 
                record.GetDateTime(6), 
                RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw) //Заполнение datagrid'а данными
        {
            dgw.Rows.Clear();

            string querystring = $"select L.inv_id, L.wh_num, L.cd_id, C.name, L.price, L.count, L.date from locb as L, cardboard as C where C.cb_id = L.cd_id";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnectiom();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void dataGridView_send_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SendCardboard_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet4.locb". При необходимости она может быть перемещена или удалена.
            this.locbTableAdapter1.Fill(this.cADataSet4.locb);
            CreateColumns();
            RefreshDataGrid(dataGridView_send);
            dataGridView_send.Columns["IsNew"].Visible = false;
            dataGridView_send.Columns["inv_id"].Visible = false;
            dataGridView_send.Columns["date"].Width = 78;
        }



        private void dataGridView_send_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_send.Rows[selectedRow];
               textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_num.Text = row.Cells[1].Value.ToString();
                textBox_cb_id.Text = row.Cells[2].Value.ToString();
                textBox_type.Text = row.Cells[3].Value.ToString();
                textBox_cost.Text = row.Cells[4].Value.ToString();
                textBox_count.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[6].Value.ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_send);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Add_Send AS = new Add_Send();
            AS.Show();
        }



        
        private void Search (DataGridView dgw) //Поиск
        {
            dgw.Rows.Clear();

            String searchstring = $"select L.inv_id, L.wh_num, L.cd_id, C.name, L.price, L.count, L.date from locb as L, cardboard as C where concat (L.inv_id, L.wh_num, L.cd_id, C.name, L.price, L.count, L.date) like '%" + textBox_search.Text + "%' and C.cb_id = L.cd_id";

            SqlCommand com = new SqlCommand(searchstring, database.GetConnection());

            database.openConnectiom();

            SqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();

        }


        private void DeleteRow() //метод удаления строки
        {
            int index = dataGridView_send.CurrentCell.RowIndex;

            dataGridView_send.Rows[index].Visible = false;
            if (dataGridView_send.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView_send.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridView_send.Rows[index].Cells[7].Value = RowState.Deleted;
        }


        private void Update ()
        {
            database.openConnectiom();
            
            for (int index = 0; index < dataGridView_send.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView_send.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                    continue;
                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_send.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from locb where inv_id = {id}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {


                    var id = dataGridView_send.Rows[index].Cells[0].Value.ToString();

                    var num = dataGridView_send.Rows[index].Cells[1].Value.ToString();
                    var cb_id = dataGridView_send.Rows[index].Cells[2].Value.ToString();
                    var cost = dataGridView_send.Rows[index].Cells[4].Value.ToString();
                    var count = dataGridView_send.Rows[index].Cells[5].Value.ToString();
                    var date = dataGridView_send.Rows[index].Cells[6].Value.ToString();
                                                                                                                                  // ОШИБКА ПРИВЕДЕНИЯ ТИП ВАРЧАР К НУМЕРИК


                    var changeQuery = $"update locb set wh_num = '{num}', cd_id = '{cb_id}', price = '{cost}', count = '{count}', date = '{date}' where inv_id = '{id}'";

                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();

                }


            }
            dataGridView_send.AllowUserToAddRows = false;

            database.closeConnectiom();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView_send.CurrentCell.RowIndex;

            var id =textBox_ID.Text;
            var id_cb = textBox_cb_id.Text;
            var num = textBox_num.Text;
            var type = textBox_type.Text;
            decimal cost;
            var count = textBox_count.Text;
            var date = dateTimePicker1.Text;

            if (dataGridView_send.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(decimal.TryParse(textBox_cost.Text, out cost))
                {
                    dataGridView_send.Rows[selectedRowIndex].SetValues(id, num, id_cb, type, cost, count, date);
                    dataGridView_send.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                }
                else { MessageBox.Show("Цена должна иметь числовой формат"); }
            }

        }
        
















    //Поиск в textBox
    private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView_send);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button_dispatch_Click(object sender, EventArgs e)
        {
            Add_Dispatch dp = new Add_Dispatch();
            dp.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receipts_journal main = new Receipts_journal();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispatch dispatch = new Dispatch();
            dispatch.Show();
        }

        private void заготовкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blanks blanks = new blanks();
            blanks.Show();
        }

        private void маркиКартонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materials mat = new Materials();
            mat.Show();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Desktop\Журнал отгрузок.xlsx");
        }

        private void отправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Process.Start(@"D:\Desktop\Журнал поступлений.xlsx");
        }

        private void остаткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"D:\Desktop\отчёт остатки.xlsx");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.locbTableAdapter.FillBy(this.cADataSet3.locb);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void заказчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Orders_table orders = new Orders_table();
            orders.Show();
        }
    }
}