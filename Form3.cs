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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonControl_Click(object sender, EventArgs e)
        {
            bool control = false;
            SqlConnection connection = new SqlConnection(@"Data Source=(127.0.0.1)\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=RestaurantSystem;User ID=SA;Password=218921aa");
            connection.Open();
            string queryString = "SELECT * FROM [user]";
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["username"].ToString() == textBoxUsername.Text && reader["email"].ToString() == textBoxEmail.Text && reader["phoneNumber"].ToString() == textBoxPhone.Text)
                {
                    control = true;
                    MessageBox.Show("Şifreniz: " + reader["password"].ToString());
                    connection.Close();
                    break;
                }
            }
            if(!control)
            {
                MessageBox.Show("Girmiş olduğunuz bilgiler yanlış, lütfen tekrar deneyiniz...");
            }
        }
    }
}
