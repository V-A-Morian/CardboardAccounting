using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CardboardAccounting
{
     class DataBase
    {   //Вводим месторасположение БД
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-UINS311;Initial Catalog = CA; Integrated Security = SSPI");

        public void openConnectiom() //Открываем соединение с БД, если оно закрыто
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            { 
            sqlConnection.Open();
            }         
        }

        public void closeConnectiom() //Закрываем соединение с БД, если оно открыто
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        
        public SqlConnection GetConnection() //Возвращение строки
        { 
            return sqlConnection; 
        }

    }
}
