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
    public partial class ForgotPasswordScreen : Form
    {
        public ForgotPasswordScreen()
        {
            InitializeComponent();
        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            if (checkNullTextBoxes()){
                label_message.ForeColor = Color.Red;
                label_message.Text = "Lütfen her şeyi doldurduğunuzdan emin olun";
            }
            else
            {
                bool doFound = false;
                DBHelper db = new DBHelper();
                SqlConnection connection = db.SqlConnection;
                connection.Open();
                string queryString = "SELECT * FROM [user]";
                SqlCommand command = new SqlCommand(queryString, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["username"].ToString() == textbox_username.Text 
                        && reader["email"].ToString() == textbox_email.Text 
                        && reader["phoneNumber"].ToString() == textbox_phone.Text)
                    {
                        doFound = true;
                        label_message.ForeColor = Color.Green;
                        label_message.Text = "Şifreniz: " + reader["password"].ToString();
                        connection.Close();
                        break;
                    }
                }
                if(!doFound) {
                    label_message.ForeColor = Color.Red;
                    label_message.Text = "Hatalı bilgi girdiniz, lütfen tekrar deneyiniz...";
                }
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginScreen= new LoginScreen();
            loginScreen.Closed += (s, args) => this.Close();
            loginScreen.Show();
        }
        private bool checkNullTextBoxes() {
            if (textbox_email.Text.Equals(null) || textbox_email.Text.Equals("")) return true;
            else if (textbox_phone.Text.Equals(null) || textbox_phone.Text.Equals("")) return true;
            else if (textbox_username.Text.Equals(null) || textbox_username.Text.Equals("")) return true;
            else return false;
        }
    }
}
