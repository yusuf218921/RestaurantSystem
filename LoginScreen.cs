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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {/*
            bool login = false;
            SqlConnection connection = new SqlConnection(@"Data Source=127.0.0.1\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=RestaurantSystem;User ID=SA;Password=218921aa");
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
                    RestaurantSystem.Program.userName = textBoxUsername.Text;
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
            */
            this.Hide();
            Form mainScreen = new MainScreen();
            mainScreen.Closed += (s, args) => this.Close();
            mainScreen.Show();
        }

        

        

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form signupScreen = new SignupScreen();
            signupScreen.Closed += (s, args) => this.Close();
            signupScreen.Show();
        }

      

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form forgotPasswordScreen = new ForgotPasswordScreen();
            forgotPasswordScreen.Closed += (s, args) => this.Close();
            forgotPasswordScreen.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        bool doShowHideActive = false;
        private void buttonShowHide_Click(object sender, EventArgs e)
        {
            
            if (doShowHideActive)
            {
                textbox_password.UseSystemPasswordChar = false;
                doShowHideActive = false;
            }
            else
            {
                textbox_password.UseSystemPasswordChar = true;
                doShowHideActive = true;
            }
        }
    }
}
