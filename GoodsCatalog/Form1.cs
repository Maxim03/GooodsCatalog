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
using System.Configuration;


namespace GoodsCatalog
{
    public partial class Form1 : Form
    {
        string conn_str;
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn_str = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            conn = new SqlConnection(conn_str);
        }

        public string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        private bool Auth()
        {
            bool success = false;
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                const string testLogin = "admin";
                const string testPassw = "202cb962ac59075b964b07152d234b70";
                string login = loginForm.Login;
                string passw = loginForm.Passw;

                if (login == testLogin && CreateMD5(passw) == testPassw)
                {
                    MessageBox.Show("Ви вдало авторизувалися!", "Сповищення",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    success = true;
                }
                else
                {
                    MessageBox.Show("Авторизация провалина!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            return success;
        }

        private void LoadCategories()
        {
            string query = "select * from Categories";
            CategoriesList.Items.Clear();
            CategoriesList.Items.Add("Всы категории");

            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CategoriesList.Items.Add(reader["CategoryName"]);
                }
            }
            conn.Close();
            CategoriesList.SelectedIndex = 0;
        }

        private void LoadProducers()
        {
            //Д.З.!
        }
        private void LoadProducts()
        {
            // наступне заняття - запов List
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Auth())
            {
                LoadCategories();
            }
        }
    }
}
