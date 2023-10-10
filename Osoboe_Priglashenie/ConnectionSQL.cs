using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoboe_Priglashenie
{/// <summary>
/// Класс подключения к БД
/// </summary>
    internal class SQL
    {
        public SqlConnection sqlConnection;
        /// <summary>
        /// Конструктор для создания соединения
        /// </summary>
        /// <param name="server">Название сервера</param>
        /// <param name="database">Название БД</param>
        public SQL(string server, string database)
        {
            sqlConnection = new SqlConnection($"Data Source = {server}; Initial Catalog = {database}; Integrated Security = True");
        }
        //SqlConnection SqlConnection = new SqlConnection("Data Source=hachapurchik;Initial Catalog=Osoboe_Priglashenie;Integrated Security=True");
        /// <summary>
        /// Метод открытия соединения с БД
        /// </summary>
        public void OpenSQL()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }
        /// <summary>
        /// Метода закрытия соединения с БД
        /// </summary>
        public void CloseSQL()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }
        /// <summary>
        /// Метод возвращения строки подключения
        /// </summary>
        /// <returns>Строка подключения</returns>
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
