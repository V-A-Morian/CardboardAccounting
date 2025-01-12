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
    public partial class Authorization : Form
    {
        DataBase database = new DataBase();
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var loginUser = username_textBox.Text;
            var passUser = password_textBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and  password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, database.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {

                MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                Main2 m = new Main2();
                this.Hide();
                m.ShowDialog();
               
            }
            else
                MessageBox.Show("Такого аккаунта не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            password_textBox.PasswordChar = '*';
            pictureBox_hideText.Visible = false;
            username_textBox.MaxLength = 50;
            password_textBox.MaxLength = 50;
        }

        private void createUser_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.ShowDialog();
        }

        private void pictureBox_showText_Click(object sender, EventArgs e)
        {
            password_textBox.PasswordChar = '\0';
            pictureBox_showText.Visible = false;
            pictureBox_hideText.Visible = true;
        }

        private void pictureBox_hideText_Click(object sender, EventArgs e)
        {
            password_textBox.PasswordChar = '*';
            pictureBox_hideText.Visible = false;            
            pictureBox_showText.Visible = true;

        }

        private void clearTextBox_pictureBox_Click(object sender, EventArgs e)
        {
            username_textBox.Clear();
            password_textBox.Clear();
        }

        private void clearTextBox_pictureBox_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
