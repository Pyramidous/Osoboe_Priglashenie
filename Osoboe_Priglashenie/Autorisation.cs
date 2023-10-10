using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Osoboe_Priglashenie
{
    /// <summary>
    /// Белеберда
    /// </summary>
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text == "admin" && PasswordTB.Text == "admin")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            else
            {
                SQL dataBase = new SQL("hachapurchik", "Osoboe_Priglashenie");
                System.Data.DataTable dataTable = new System.Data.DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataBase.OpenSQL();
                string query_list = $"SELECT Name_Staff FROM Staff WHERE INN_Staff = '{LoginTB.Text}' AND Password_Staff = '{PasswordTB.Text}'";
                SqlCommand list = new SqlCommand(query_list, dataBase.GetConnection());
                dataAdapter.SelectCommand = list;
                dataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    Staff staff = new Staff();
                    staff.gateway = list.ExecuteScalar().ToString();
                    staff.INN = LoginTB.Text;
                    staff.Show();
                    this.Close();
                }
                else MessageBox.Show("Неправильное имя пользователя или пароль. Попробуйте снова, или обратитесь к администратору для смены данных для входа", "Ошибка авторизации");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void Autorisation_Load(object sender, EventArgs e)
        {
            PasswordTB.UseSystemPasswordChar = true;
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            if (ShowPasswordBtn.ImageIndex == 0) 
            {
                PasswordTB.UseSystemPasswordChar = false;
                ShowPasswordBtn.ImageIndex = 1;
            }
            else
            {
                PasswordTB.UseSystemPasswordChar = true;
                ShowPasswordBtn.ImageIndex = 0;
            }
        }
    }
}
