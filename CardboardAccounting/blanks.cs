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





    public partial class blanks : Form
    {
        DataBase database = new DataBase();
        int selectedRow;
        public blanks()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns() //Добавление колонок в datagridview
        {
            dataGridView_blanks.Columns.Add("id", "id");
            dataGridView_blanks.Columns.Add("name", "Название заготовки");
            dataGridView_blanks.Columns.Add("price", "Цена за штуку в руб.");
            dataGridView_blanks.Columns.Add("id_type", "id заготовки");
            dataGridView_blanks.Columns.Add("type", "Тип картона для производства");

            dataGridView_blanks.Columns.Add("IsNew", String.Empty);

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record) // Присваиваю каждой строчке колонки свой 
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDecimal(2), record.GetInt32(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw) //Заполнение datagrid'а данными
        {
            dgw.Rows.Clear();

            string querystring = $"select b.id, b.name, b.price, b.id_cb, cb.name  from blanks as b, cardboard as cb where b.id_cb = cb.cb_id";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnectiom();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void blanks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cADataSet4.cardboard". При необходимости она может быть перемещена или удалена.
            this.cardboardTableAdapter.Fill(this.cADataSet4.cardboard);
            CreateColumns();
            RefreshDataGrid(dataGridView_blanks);

            dataGridView_blanks.Columns["IsNew"].Visible = false;
            dataGridView_blanks.Columns["id"].Visible = false;
            dataGridView_blanks.Columns["id_type"].Visible = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            add_blanks add_blanks = new add_blanks();
            add_blanks.Show();
        }




        private void DeleteRow() //метод удаления строки
        {
            int index = dataGridView_blanks.CurrentCell.RowIndex;

            dataGridView_blanks.Rows[index].Visible = false;
            if (dataGridView_blanks.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView_blanks.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView_blanks.Rows[index].Cells[5].Value = RowState.Deleted;
        }




        private void Update()
        {
            database.openConnectiom();

            for (int index = 0; index < dataGridView_blanks.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView_blanks.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_blanks.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from blanks where id = {id}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {


                    var id = dataGridView_blanks.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView_blanks.Rows[index].Cells[1].Value.ToString();
                    var price = dataGridView_blanks.Rows[index].Cells[2].Value.ToString();
                    var id_type = dataGridView_blanks.Rows[index].Cells[3].Value.ToString();
                    var type = dataGridView_blanks.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"update blanks set name = '{name}', price = '{price}', id_cb = '{id_type}' where id = '{id}'";
                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();

                }


            }
            dataGridView_blanks.AllowUserToAddRows = false;

            database.closeConnectiom();
        }




        private void Change()
        {
            var selectedRowIndex = dataGridView_blanks.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var name = textBox_name.Text;
            decimal cost;
            var type = comboBox2.Text;

    
          

            if (dataGridView_blanks.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (decimal.TryParse(textBox_cost.Text, out cost))
                {
                    dataGridView_blanks.Rows[selectedRowIndex].SetValues(id, name, cost, type);
                    dataGridView_blanks.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else { MessageBox.Show("Цена должна иметь числовой формат"); }
            }

        }















        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_blanks);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_blanks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_blanks.Rows[selectedRow];
                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_name.Text = row.Cells[1].Value.ToString();
                textBox_cost.Text = row.Cells[2].Value.ToString();
                comboBox2.Text = row.Cells[3].Value.ToString();
                comboBox1.Text = row.Cells[4].Value.ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
    }
}
