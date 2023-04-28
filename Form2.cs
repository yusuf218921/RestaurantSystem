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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.CheckState == CheckState.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
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
                if (reader["username"].ToString() == textBoxUsername.Text)
                {
                    user_control = false;
                    break;
                }
                else if (reader["email"].ToString() == textBoxEmail.Text)
                {
                    email_control = false;
                    break;
                }
                else if (reader["phoneNumber"].ToString() == textBoxPhone.Text)
                {
                    phone_control = false;
                    break;
                }
                
            }
            reader.Close();
            if(user_control && email_control && phone_control)
            {
                queryString = "INSERT INTO [user] (username, password, firstname,lastname,email,phoneNumber) VALUES (@username, @password, @firstname,@lastname,@email,@phoneNumber)";
                command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                command.Parameters.AddWithValue("@password", textBoxPassword.Text);
                command.Parameters.AddWithValue("@firstname", textBoxFirstName.Text);
                command.Parameters.AddWithValue("@lastname", textBoxLastname.Text);
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                command.Parameters.AddWithValue("@phoneNumber", textBoxPhone.Text);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Kayıt Başarıyla Oluşturuldu");
                this.Close();
            }
            else if(!user_control)
            {
                MessageBox.Show("Girmiş olduğunuz Kullanıcı Adı daha önce alınmış lütfen yeni bir kullanıcı adı oluşturunuz...");
            }
            else if (!email_control)
            {
                MessageBox.Show("Girmiş olduğunuz E-posta daha önce alınmış lütfen yeni bir E-posta giriniz...");
            }
            else if (!phone_control)
            {
                MessageBox.Show("Girmiş olduğunuz Telefon numarası daha önce alınmış lütfen yeni bir Telefon numarası giriniz...");
            }
        }
    }
}
