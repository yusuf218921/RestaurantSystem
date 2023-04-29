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
        public User user;
        public LoginScreen()
        {
            InitializeComponent();
        }
        bool login = false;
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if(textbox_username.Text.Equals("") || textbox_password.Text.Equals(""))
            {
                label_message.Text = "Lütfen kullanıcı adı veya şifreyi boş bırakmayınız.";
            }
            else
            {
                DBHelper db = new DBHelper();
                SqlConnection connection = db.SqlConnection;
                connection.Open();
                string queryString = "SELECT * FROM [user]";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    if (reader["username"].ToString().Equals(textbox_username.Text)
                        && reader["password"].ToString().Equals(textbox_password.Text))
                    {
                        string username = reader["username"].ToString();
                        string password = reader["password"].ToString();
                        string firstname = reader["firstname"].ToString();
                        string lastname = reader["lastname"].ToString();
                        string email = reader["email"].ToString();
                        string tel = reader["phoneNumber"].ToString();
                        int user_id = (int)reader["id"];
                        user = new User(user_id, username, password, firstname, lastname, email, tel);
                        login = true;
                        break;
                    }

                }

                connection.Close();
                if (login)
                {
                    this.Hide();
                    Form mainScreen = new MainScreen(user);
                    mainScreen.Closed += (s, args) => this.Close();
                    mainScreen.Show();

                }
                else label_message.Text = "Kullanıcı adı veya şifre yanlış girildi...";
            }
        }
        private void buttonSignIn_Test(object sender, EventArgs e)
        {

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
