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

    enum RowState //Перечисление возможных состояний колонок
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }


    public partial class Materials : Form
    {
        DataBase database = new DataBase();
        int selectedRow;

        public Materials()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns() //Добавление колонок в datagridview
        {
            dataGridView_materials.Columns.Add("id", "id");
            dataGridView_materials.Columns.Add("name", "Марка картона");
            dataGridView_materials.Columns.Add("price", "Цена за штуку в руб.");
            dataGridView_materials.Columns.Add("IsNew", String.Empty);

        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record) // Присваиваю каждой строчке колонки свой 
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDecimal(2), RowState.ModifiedNew);
        }


        private void RefreshDataGrid(DataGridView dgw) //Заполнение datagrid'а данными
        {
            dgw.Rows.Clear();

            string querystring = $"select * from cardboard";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnectiom();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }


        private void dataGridView_send_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteRow() //метод удаления строки
        {
            int index = dataGridView_materials.CurrentCell.RowIndex;

            dataGridView_materials.Rows[index].Visible = false;
            if (dataGridView_materials.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView_materials.Rows[index].Cells[3].Value = RowState.Deleted;
                return;
            }
            dataGridView_materials.Rows[index].Cells[3].Value = RowState.Deleted;
        }




        private void Update()
        {
            database.openConnectiom();

            for (int index = 0; index < dataGridView_materials.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView_materials.Rows[index].Cells[3].Value;

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView_materials.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from cardboard where cb_id = {id}";

                    var command = new SqlCommand(deleteQuery, database.GetConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {


                    var id = dataGridView_materials.Rows[index].Cells[0].Value.ToString();
                    var name = dataGridView_materials.Rows[index].Cells[1].Value.ToString();
                    var cost = dataGridView_materials.Rows[index].Cells[2].Value.ToString();

                    var changeQuery = $"update cardboard set name = '{name}', price = '{cost}' where cb_id = '{id}'";
                    var command = new SqlCommand(changeQuery, database.GetConnection());
                    command.ExecuteNonQuery();

                }


            }
            dataGridView_materials.AllowUserToAddRows = false;

            database.closeConnectiom();
        }






        private void Change()
        {
            var selectedRowIndex = dataGridView_materials.CurrentCell.RowIndex;

            var id = label_id.Text;
            var type = textBox_type.Text;
            decimal cost;

            if (dataGridView_materials.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (decimal.TryParse(textBox_cost.Text, out cost))
                {
                    dataGridView_materials.Rows[selectedRowIndex].SetValues(id, type, cost);
                    dataGridView_materials.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
                }
                else { MessageBox.Show("Цена должна иметь числовой формат"); }
            }

        }



        private void Materials_Load(object sender, EventArgs e)
        {

            CreateColumns();
            RefreshDataGrid(dataGridView_materials);
            this.dataGridView_materials.Columns[3].Visible = false;
            this.dataGridView_materials.Columns[0].Width = 20;
        }

        private void dataGridView_materials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView_materials_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void dataGridView_materials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_materials.Rows[selectedRow];
                label_id.Text = row.Cells[0].Value.ToString();
                textBox_type.Text = row.Cells[1].Value.ToString();
                textBox_cost.Text = row.Cells[2].Value.ToString();

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click_1(object sender, EventArgs e)
        {
            database.openConnectiom();

            var name = textBox_type.Text;
            decimal price;

            if (decimal.TryParse(textBox_cost.Text, out price))
            {

                var addQueryHist = $"insert into cardboard (name, price) values('{name}', '{price}')";
                var commandHist = new SqlCommand(addQueryHist, database.GetConnection());
                commandHist.ExecuteNonQuery();

                MessageBox.Show("Материал добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else { MessageBox.Show("Цена должна иметь числовой формат", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            database.closeConnectiom();
        }
    }
}
