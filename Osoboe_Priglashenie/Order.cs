using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osoboe_Priglashenie
{
    public partial class Order : Form
    {
        public int value
        {
            get; set;
        }
        public Order()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (ProductCB.Text != string.Empty && CountTB.Text != string.Empty && SurnameTB.Text != string.Empty && NameTB.Text != string.Empty && SecnameTB.Text != string.Empty && LoginTB.Text != string.Empty)
            {
                SQL dataBase = new SQL("hachapurchik", "Osoboe_Priglashenie");
                System.Data.DataTable dataTable = new System.Data.DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataBase.OpenSQL();
                string query_list = $"SELECT * FROM Client WHERE INN_Client = '{LoginTB.Text}'";
                SqlCommand list = new SqlCommand(query_list, dataBase.GetConnection());
                dataAdapter.SelectCommand = list;
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count <= 0)
                {
                    query_list = $"INSERT INTO Client (INN_Client, Surname_Client, Name_Client, Secname_Client) VALUES ('{LoginTB.Text}', '{SurnameTB.Text}', '{NameTB.Text}', '{SecnameTB.Text}')";
                    list = new SqlCommand(query_list, dataBase.GetConnection());
                    list.ExecuteNonQuery();
                }
                query_list = $"INSERT INTO [Order] (INN_Client, ID_Product, Count, Price) VALUES ('{LoginTB.Text}', '{ProductCB.SelectedValue}', '{CountTB.Text}', '{value}')";
                list = new SqlCommand(query_list, dataBase.GetConnection());
                list.ExecuteNonQuery();
                MessageBox.Show("Заказ успешно оформлен", "Информация");
            }
            else MessageBox.Show("Все поля должны быть заполнены", "Ошибка");
            CountTB.Text = string.Empty; 
            SurnameTB.Text = string.Empty;
            NameTB.Text = string.Empty;
            SecnameTB.Text = string.Empty;
            LoginTB.Text = string.Empty;
        }

        private void CountTB_TextChanged(object sender, EventArgs e)
        {
            if (CountTB.Text != string.Empty && Regex.IsMatch(CountTB.Text, @"^\d+$"))
            {
                SQL dataBase = new SQL("hachapurchik", "Osoboe_Priglashenie");
                dataBase.OpenSQL();
                string query_list = $"SELECT Price_Product FROM Product WHERE ID_Product = '{ProductCB.SelectedValue}'";
                SqlCommand list = new SqlCommand(query_list, dataBase.GetConnection());
                object price = list.ExecuteScalar();
                dataBase.CloseSQL();
                value = int.Parse(price.ToString()) * int.Parse(CountTB.Text);
                PriceLbl.Text = "Итоговая стоимость: " + value.ToString() + " руб";
            }
            else PriceLbl.Text = "Итоговая стоимость: 0 руб";
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "osoboe_PriglashenieDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.osoboe_PriglashenieDataSet.Product);

        }
    }
}
