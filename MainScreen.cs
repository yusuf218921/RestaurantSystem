using System;
using System.Collections;
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
    public partial class MainScreen : Form
    {
        User user;
        private static Button currentMainButton;
        public MainScreen(User user)
        {
            InitializeComponent();
            this.user = user;
            profile_username.Text = "Kullanıcı Adı:  " + user.Username;
            profile_name.Text = "İsim:  " + user.Name;
            profile_email.Text = "E posta:  " + user.Email;
            profile_surname.Text = "Soyisim:  " + user.Surname;
            profile_tel.Text = "Telefon:  " + user.Tel;
            changeCurrentMainButton(button_makeAppointment);
            DBHelper db = new DBHelper();
            SqlConnection connection = db.SqlConnection;
            connection.Open();
            string queryString = "Select * from [reservation] where customer_id = " + user.Id;
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                string date = reader["reservation_date"].ToString();
                string time = reader["reservation_time"].ToString();
                string restourant_name = reader["restaurant_name"].ToString();
                Reservation reservation = new Reservation(restourant_name, date, time, user.Username);
                user.Reservations.Add(reservation);
            }
            connection.Close();
        }


        //
        //Sol sekmedeki butonlar
        //
        private void button_makeAppointment_Click(object sender, EventArgs e)
        {
            page_getRes_Detail_message.Text = "";
            pageController.SelectedTab = page_getRes;
            changeCurrentMainButton(button_makeAppointment);
        }
        private void button_showAppointments_Click(object sender, EventArgs e)
        {
            
            pageController.SelectedTab = page_showReservations;
            changeCurrentMainButton(button_showAppointments);
            listReservations();
        }
        private void button_profile_Click(object sender, EventArgs e)
        {
            pageController.SelectedTab = page_profile;
            changeCurrentMainButton(button_profile);
        }
        private void button_logout_Click(object sender, EventArgs e)
        {
            Program.loginCol = 0;
            this.Hide();
            Form loginScreen = new LoginScreen();
            loginScreen.Closed += (s, args) => this.Close();
            loginScreen.Show();
        }
        //
        //Rezervasyonları yazdırma
        //
        
        private void listReservations()
        {
            page_showReservations_text.Text = "";
            //loginCol kullanılarak satırdaki kişiden reservasyonlar çekilecek
            int i = 0;
            foreach (Reservation reservation in user.Reservations)
            {
                if (i == 0) {
                    page_showReservations_text.Text +=  reservation.Restourant + " - " + reservation.Date.Substring(0, 10) + " - "
                    + reservation.Hour.Substring(0, 5);
                }
                else
                {
                    page_showReservations_text.Text += "\n" + reservation.Restourant + " - " + reservation.Date.Substring(0, 10) + " - "
                    + reservation.Hour.Substring(0, 5);
                }
            }
        }
        //
        // Ana button'u (Seçilmiş butonnu) ayarlayan fonksiyon
        //
        private void changeCurrentMainButton(Button newCurrentButton)
        {
            currentMainButton = newCurrentButton;
            //all enable
            button_makeAppointment.Enabled = true;
            button_showAppointments.Enabled = true;
            button_profile.Enabled = true;
            //all size
            button_makeAppointment.Size = new Size(127, 80);
            button_showAppointments.Size = new Size(127, 80);
            button_profile.Size = new Size(127, 80);
            //all back color
            button_makeAppointment.BackColor = Color.FromArgb(30, 30, 30);
            button_showAppointments.BackColor = Color.FromArgb(30, 30, 30);
            button_profile.BackColor = Color.FromArgb(30, 30, 30);
            //all fore color
            button_makeAppointment.ForeColor = Color.White;
            button_showAppointments.ForeColor = Color.White;
            button_profile.ForeColor = Color.White;
            //Bordor color
            button_makeAppointment.FlatAppearance.BorderColor = Color.White;
            button_showAppointments.FlatAppearance.BorderColor = Color.White;
            button_profile.FlatAppearance.BorderColor = Color.White;
            //current
            currentMainButton.Enabled = false;
            currentMainButton.Size = new Size(150,80);
            currentMainButton.BackColor = Color.FromArgb(100, 255, 100);
            currentMainButton.FlatAppearance.BorderColor = Color.FromArgb(100,255,100);
            currentMainButton.ForeColor = Color.FromArgb(30, 30, 30);
        }
        //
        //Randevu oluşturma sayfası buttonları
        //
        private void button_yusufSelectClick(object sender, EventArgs e)
        {
            page_getRes_Detail_message.Text = "";
            pageController.SelectedTab = page_getRes_Detail;
            page_getRes_detail_title.Text = "Köfteci Yusuf";
        }

        private void button_burgerSelectClick(object sender, EventArgs e)
        {
            page_getRes_Detail_message.Text = "";
            pageController.SelectedTab = page_getRes_Detail;
            page_getRes_detail_title.Text = "Burger King";
        }
        //
        //Profil görüntüle sayfası buttonları
        //
        bool doesEditActive = false;
        
        //
        //Randevu oluşturma detayına inen sayfadaki buttonlar
        //
        private void page_makeApp_detail_return_Click(object sender, EventArgs e)
        {
            pageController.SelectedTab = page_getRes;
            page_getRes_Detail_message.Text = "";
        }

        private void page_makeApp_detail_confirm_Click(object sender, EventArgs e)
        {
            DateTime datetime = page_getRes_detail_datePicker.Value;
            String date = datetime.ToString("yyyy-MM-dd");
            DateTime time = page_getRes_detail_timePicker.Value;
            String _time = time.ToString("HH:mm:ss");
            DBHelper dBHelper = new DBHelper();
            SqlConnection connection = dBHelper.SqlConnection;
            connection.Open();
            string queryString = "INSERT INTO [reservation] (reservation_date, reservation_time, restaurant_name, customer_id) VALUES (@reservation_date, @reservation_time, @restaurant_name, @customer_id)";
            SqlCommand command = new SqlCommand(queryString, connection);

            command.Parameters.AddWithValue("@reservation_date", date);
            command.Parameters.AddWithValue("@reservation_time", _time);
            command.Parameters.AddWithValue("@restaurant_name", page_getRes_detail_title.Text);
            command.Parameters.AddWithValue("@customer_id", user.Id);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            Reservation reservation = new Reservation(page_getRes_detail_title.Text,date,_time,user.Username);
            user.Reservations.Add(reservation);
            page_getRes_Detail_message.Text = "Randevu Başarıyla Alındı";
        }
    }
}
