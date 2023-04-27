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

namespace RestaurantSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            bool login = false;
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DB85IPR;Initial Catalog=RestaurantSystem;User ID=SA;Password=218921aa;");
            connection.Open();
            string queryString = "SELECT * FROM [user]";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["username"].ToString() == textBoxUsername.Text 
                    && reader["password"].ToString() == textBoxPassword.Text) 
                {
                    login = true;
                    break;
                }
            }
            if(login)
            {
                MessageBox.Show("Tebrikler, Başarıyla Giriş Yaptınız...");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış girildi...");
            }
            connection.Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPassword.CheckState == CheckState.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
