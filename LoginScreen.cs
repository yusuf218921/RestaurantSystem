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
        bool login = false;
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=127.0.0.1\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=RestaurantSystem;User ID=SA;Password=218921aa");
            connection.Open();
            string queryString = "SELECT * FROM [user]";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            int col=0;//Nerede bulunduğuna dair bir satır sayısı tutacak değişken
            while (reader.Read())
            {
                if (reader["username"].ToString() == textbox_username.Text 
                    && reader["password"].ToString() == textbox_username.Text) 
                {
                    login = true;
                    Program.loginCol = col;//Eğer giriş yapılmışsa database'de hangi satırda olduğunun kaydını tutar
                    break;
                }
                col++;
            }
            connection.Close();
            if (login)
            {
                this.Hide();
                Form mainScreen = new MainScreen();
                mainScreen.Closed += (s, args) => this.Close();
                mainScreen.Show();
                
            }
            else label_message.Text = "Kullanıcı adı veya şifre yanlış girildi...";
        }
        private void buttonSignIn_Test(object sender, EventArgs e)
        {
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


        bool doShowHideActive = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
