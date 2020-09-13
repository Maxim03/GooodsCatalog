using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodsCatalog
{
    public partial class LoginForm : Form
    {
        public string Login { get; set; }
        public string Passw { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExsesButton_Click(object sender, EventArgs e)
        {
            string login = LoginFeild.Text;
            string passw = PassFeild.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(passw))
            {
                MessageBox.Show("Ви не ввели все поля", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Login = login;
                Passw = passw;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LoginFeild.Clear();
            PassFeild.Clear();
            LoginFeild.Focus();
        }
    }
}
