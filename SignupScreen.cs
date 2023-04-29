using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class SignupScreen : Form
    {
        public SignupScreen()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            
            if (!checkNull())
            {
                label_message.Text = "";
                bool user_control = true;
                bool email_control = true;
                bool phone_control = true;
                SqlConnection connection = new SqlConnection(@"Data Source=127.0.0.1\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=RestaurantSystem;User ID=SA;Password=218921aa");
                connection.Open();
                string queryString = "SELECT * FROM [user]";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["username"].ToString() == textbox_username.Text)
                    {
                        user_control = false;
                        break;
                    }
                    else if (reader["email"].ToString() == textbox_email.Text)
                    {
                        email_control = false;
                        break;
                    }
                    else if (reader["phoneNumber"].ToString() == textbox_phone.Text)
                    {
                        phone_control = false;
                        break;
                    }

                }
                reader.Close();
                if (user_control && email_control && phone_control)
                {
                    queryString = "INSERT INTO [user] (username, password, firstname,lastname,email,phoneNumber) VALUES (@username, @password, @firstname,@lastname,@email,@phoneNumber)";
                    command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@username", textbox_username.Text);
                    command.Parameters.AddWithValue("@password", textbox_password.Text);
                    command.Parameters.AddWithValue("@firstname", textbox_name.Text);
                    command.Parameters.AddWithValue("@lastname", textbox_surname.Text);
                    command.Parameters.AddWithValue("@email", textbox_email.Text);
                    command.Parameters.AddWithValue("@phoneNumber", textbox_phone.Text);

                    int rowsAffected = command.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Kayıt Başarıyla Oluşturuldu");
                    this.Close();
                }
                else if (!user_control)
                {
                    label_message.Text= "Bu kullanıcı adı daha önce alınmış. Lütfen yeni bir kullanıcı adı giriniz...";
                }
                else if (!email_control)
                {
                    label_message.Text = "E posta adresi daha önce alınmış. Lütfen yeni bir e posta giriniz...";
                }
                else if (!phone_control)
                {
                    label_message.Text = "Bu telefon numarası daha önce alınmış. Lütfen yeni bir telefon numarası giriniz...";
                }
            }
            else
            {
                label_message.Text = "Lütfen hiçbir değeri boş bırakmayınız";
            }
            
        }
        private void buttonSignupTest(object sender, EventArgs e)
        {
            if (checkNull())
            
            {
                label_message.Text = "Lütfen hiçbir değeri boş bırakmayınız";
            }
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

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginScreen = new LoginScreen();
            loginScreen.Closed += (s, args) => this.Close();
            loginScreen.Show();
        }
        private bool checkNull()
        {
            if (
                textbox_username.Text.Equals("")
                || textbox_password.Text.Equals("")
                || textbox_name.Text.Equals("")
                || textbox_surname.Text.Equals("")
                || textbox_email.Text.Equals("")
                || textbox_phone.Text.Equals("")
                || textbox_postalCode.Text.Equals("")
                ) return true;
            else return false;
        }

    }
}
