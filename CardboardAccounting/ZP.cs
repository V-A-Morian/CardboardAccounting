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
    public partial class ZP : Form
    {

        DataBase database = new DataBase();
        public ZP()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns() //Добавление колонок в datagridview
        {
            dataGridView_zp.Columns.Add("name", "Имя");
            dataGridView_zp.Columns.Add("surname", "Фамилия");
            dataGridView_zp.Columns.Add("Secondname", "Отчество");
            dataGridView_zp.Columns.Add("post", "Должность");
            dataGridView_zp.Columns.Add("salary", "Оклад");
            dataGridView_zp.Columns.Add("IsNew", String.Empty);
        }


        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetDecimal(4), RowState.ModifiedNew);
        }


        private void RefreshDataGrid(DataGridView dgw) //Заполнение datagrid'а данными
        {
            dgw.Rows.Clear();

            string querystring = $"select name, surname, secondname, post, salary from workers";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            database.openConnectiom();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }


        private void LeftoversCardboard_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_zp);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_zp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
