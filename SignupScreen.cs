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
            SqlConnection conn = new SqlConnection(@"Data Source=127.0.0.1\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=RestaurantSystem;User ID=SA;Password=218921aa");
            conn.Open();
            string queryString = "SELECT * FROM [city]";
            SqlCommand command = new SqlCommand(queryString, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string city = reader["city"].ToString();
                comboBox_City.Items.Add(city);
            }
            conn.Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            
            if (!checkNull())
            {
                label_message.Text = "";
                bool user_control = true;
                bool email_control = true;
                bool phone_control = true;
                DBHelper db = new DBHelper();
                SqlConnection connection = db.SqlConnection;
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
                    int user_id=1;
                    queryString = "Select * FROM [user]";
                    command = new SqlCommand(queryString, connection);
                    reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        user_id = (int)reader["id"];
                    }
                    MessageBox.Show(user_id.ToString());
                    reader.Close();
                    queryString = "Select * FROM [towns]";
                    command = new SqlCommand(queryString, connection);
                    reader = command.ExecuteReader();
                    int townid=0;
                    while(reader.Read())
                    {
                        if (reader["town"].ToString().Equals(comboBox_Town.Text))
                        {
                            townid = (int)reader["id"];
                        }
                    }
                    reader.Close();
                    queryString = "INSERT INTO [adress] (userid, cityid, townid,district,postalcode,adresstext) VALUES (@userid, @cityid, @townid, @district, @postalcode, @adresstext)";
                    command.Parameters.AddWithValue("@userid", user_id);
                    command.Parameters.AddWithValue("@cityid", comboBox_City.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@townid", townid);
                    command.Parameters.AddWithValue("@district", textBox_District.Text);
                    command.Parameters.AddWithValue("@postalcode", textbox_postalCode.Text);
                    command.Parameters.AddWithValue("@adresstext", richTextBox_Adress.Text);
                    int _rowsAffected = command.ExecuteNonQuery();
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
                || textBox_District.Text.Equals("")
                ) return true;
            else return false;
        }

        private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Town.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=127.0.0.1\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=RestaurantSystem;User ID=SA;Password=218921aa");
            conn.Open();
            int id = comboBox_City.SelectedIndex + 1;
            string queryString = string.Format("SELECT * FROM [towns] where city_id = {0}", id);
            SqlCommand command = new SqlCommand(queryString, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox_Town.Items.Add(reader["town"]);
            }
            conn.Close();
        }

        private void comboBox_Town_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
