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
    public partial class Register : Form
    {
        DataBase database = new DataBase();

        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            pictureBox_hideText.Visible = false;
            textBox_username.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_createAccount_Click(object sender, EventArgs e)
        {

            if (checkuser())

            {
                return;
            }

            DataBase database = new DataBase();

            var login = textBox_username.Text;
            var password = textBox_password.Text;

            string querystring = $"insert into register (login_user, password_user) values ('{login}', '{password}')";


            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            database.openConnectiom();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успех");
                Authorization a = new Authorization();
                this.Hide();
                a.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Аккаунт не получилось создать");
            }
            database.closeConnectiom();

        }

        private Boolean checkuser()
        {
            var loginuser = textBox_username.Text;
            var passworduser = textBox_password.Text;


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginuser}' and password_user = '{passworduser}'";
            SqlCommand command = new SqlCommand(querystring, database.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else
            { 
                return false; 
            }
            

        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_hideText_Click(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            pictureBox_hideText.Visible = false;
            pictureBox_showText.Visible = true;
        }

        private void pictureBox_showText_Click(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '\0';
            pictureBox_showText.Visible = false;
            pictureBox_hideText.Visible = true;
        }

        private void pictureBox_clearTextBox_Click(object sender, EventArgs e)
        {
            textBox_password.Clear();
            textBox_username.Clear();
        }
    }
}
