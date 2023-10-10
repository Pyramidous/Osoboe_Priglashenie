using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osoboe_Priglashenie
{
    public partial class Staff : Form
    {
        public string gateway
        {
            get; set;
        }
        public string INN
        {
            get; set;
        }
        public Staff()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "osoboe_PriglashenieDataSet.Order". При необходимости она может быть перемещена или удалена.
            //this.orderTableAdapter.Fill(this.osoboe_PriglashenieDataSet.Order);
            WelcomeLbl.Text = $"Добро пожаловать, {gateway}";
            YourOrderPanel.Hide();
            NewOrderPanel.Hide();
            HistoryPanel.Hide();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            SQL dataBase = new SQL("hachapurchik", "Osoboe_Priglashenie");
            dataBase.OpenSQL();
            int RowIndex = FreeOrderDGW.SelectedCells[0].RowIndex;
            string cellValue = "'" + FreeOrderDGW.Rows[RowIndex].Cells[0].Value.ToString() + "'";
            string query = $"UPDATE [Order] SET INN_Staff = '{INN}' WHERE ID_Order = {cellValue}";
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Заказ успешно принят", "Информация");
            NewOrderPanel.Hide();
        }

        private void YourOrderBtn_Click(object sender, EventArgs e)
        {
            SQL dataBase = new SQL("hachapurchik", "Osoboe_Priglashenie");
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataBase.OpenSQL();
            string query_list = $"SELECT * FROM [Order] WHERE INN_Staff = '{INN}'";
            SqlCommand list = new SqlCommand(query_list, dataBase.GetConnection());
            dataAdapter.SelectCommand = list;
            dataAdapter.Fill(dataSet);
            YourOrderDGW.DataSource = dataSet.Tables[0];
            YourOrderPanel.Show();
            NewOrderPanel.Hide();
            HistoryPanel.Hide();
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            SQL dataBase =  new SQL("hachapurchik", "Osoboe_Priglashenie");
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataBase.OpenSQL();
            string query_list = $"SELECT * FROM [Order] WHERE INN_Staff IS NULL";
            SqlCommand list = new SqlCommand(query_list, dataBase.GetConnection());
            dataAdapter.SelectCommand = list;
            dataAdapter.Fill(dataSet);
            FreeOrderDGW.DataSource = dataSet.Tables[0];
            NewOrderPanel.Show();
            YourOrderPanel.Hide();
            HistoryPanel.Hide();
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            this.order_HistoryTableAdapter.Fill(this.osoboe_PriglashenieDataSet.Order_History);
            HistoryPanel.Show();
            YourOrderPanel.Hide();
            NewOrderPanel.Hide();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            SQL dataBase = new SQL("hachapurchik", "Osoboe_Priglashenie");
            dataBase.OpenSQL();
            int rowIndex = YourOrderDGW.SelectedCells[0].RowIndex;
            string cellValue = "";
            for (int i = 1; i < 5; i++)
            {

                cellValue += "'" + YourOrderDGW.Rows[rowIndex].Cells[i].Value.ToString() + "', ";


            }
            cellValue += "'" + YourOrderDGW.Rows[rowIndex].Cells[5].Value.ToString() + "'";
            string query = $"INSERT INTO Order_History (INN_Client, INN_Staff, ID_Product, Count, Price) VALUES ({cellValue})";
            SqlCommand command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
            query = $"DELETE FROM [Order] WHERE ID_Order = '{YourOrderDGW.Rows[rowIndex].Cells[0].Value.ToString()}'";
            command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Заказ успешно закрыт", "Информация");
            YourOrderPanel.Hide();
        }
    }
}
