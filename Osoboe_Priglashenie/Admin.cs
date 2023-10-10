using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Osoboe_Priglashenie
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            OrderPanel.Show();
            HistoryPanel.Hide();
            ClientPanel.Hide();
            ProductPanel.Hide();
            StaffPanel.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "osoboe_PriglashenieDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.osoboe_PriglashenieDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "osoboe_PriglashenieDataSet.Staff". При необходимости она может быть перемещена или удалена.
            this.staffTableAdapter.Fill(this.osoboe_PriglashenieDataSet.Staff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "osoboe_PriglashenieDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.osoboe_PriglashenieDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "osoboe_PriglashenieDataSet.Order_History". При необходимости она может быть перемещена или удалена.
            this.order_HistoryTableAdapter.Fill(this.osoboe_PriglashenieDataSet.Order_History);
            this.orderTableAdapter.Fill(this.osoboe_PriglashenieDataSet.Order);
            OrderPanel.Hide();
            HistoryPanel.Hide();
            ClientPanel.Hide();
            ProductPanel.Hide();
            StaffPanel.Hide();
        }

        private void AcceptOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.orderBindingSource.EndEdit();
                this.orderTableAdapter.Update(this.osoboe_PriglashenieDataSet);
                MessageBox.Show("Данные сохранены");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AcceptHistoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.orderHistoryBindingSource.EndEdit();
                this.order_HistoryTableAdapter.Update(this.osoboe_PriglashenieDataSet);
                MessageBox.Show("Данные сохранены");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AcceptClientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.clientBindingSource.EndEdit();
                this.clientTableAdapter.Update(this.osoboe_PriglashenieDataSet);
                MessageBox.Show("Данные сохранены");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AcceptStaffBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.staffBindingSource.EndEdit();
                this.staffTableAdapter.Update(this.osoboe_PriglashenieDataSet);
                MessageBox.Show("Данные сохранены");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void AcceptProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.productBindingSource.EndEdit();
                this.productTableAdapter.Update(this.osoboe_PriglashenieDataSet);
                MessageBox.Show("Данные сохранены");
            }
            catch (System.Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            OrderPanel.Hide();
            HistoryPanel.Show();
            ClientPanel.Hide();
            ProductPanel.Hide();
            StaffPanel.Hide();
        }

        private void ClientBtn_Click(object sender, EventArgs e)
        {
            OrderPanel.Hide();
            HistoryPanel.Hide();
            ClientPanel.Show();
            ProductPanel.Hide();
            StaffPanel.Hide();
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            OrderPanel.Hide();
            HistoryPanel.Hide();
            ClientPanel.Hide();
            ProductPanel.Hide();
            StaffPanel.Show();
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            OrderPanel.Hide();
            HistoryPanel.Hide();
            ClientPanel.Hide();
            ProductPanel.Show();
            StaffPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Workbooks.Open(Directory.GetCurrentDirectory() + @"\journal.xlsx");
            Excel.Worksheet sheet = excel.ActiveSheet;
            for (int i = 0; i <= dataGridView5.RowCount - 2; i++)
            {
                for (int j = 0; j <= dataGridView5.ColumnCount - 1; j++)
                {
                    sheet.Cells[i + 2, j + 1] = dataGridView5[j, i].Value.ToString();
                }
            }
            excel.ActiveWorkbook.SaveAs(Directory.GetCurrentDirectory() + @"\readyjournal.xlsx");
            excel.Workbooks.Close();
        }
    }
}
