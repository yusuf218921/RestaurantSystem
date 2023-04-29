using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class MainScreen : Form
    {
        private static Button currentMainButton;
        public MainScreen()
        {
            InitializeComponent();
            profile_username.Text = "Kullanıcı Adı: " +"";
            profile_name.Text = "İsim: " + "";
            profile_email.Text = "E posta: " + "";
            profile_surname.Text = "Soyisim: " + "";
            profile_tel.Text = "Telefon: " + "";
            changeCurrentMainButton(button_makeAppointment);
        }
        //
        //Sol sekmedeki butonlar
        //
        private void button_makeAppointment_Click(object sender, EventArgs e)
        {
            pageController.SelectedTab = page_makeReservation;
            changeCurrentMainButton(button_makeAppointment);
        }
        private void button_showAppointments_Click(object sender, EventArgs e)
        {
            
            pageController.SelectedTab = page_showReservations;
            changeCurrentMainButton(button_showAppointments);
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
            //loginCol kullanılarak satırdaki kişiden reservasyonlar çekilecek
            for(int i = 0;i<100;i++)
            {
                show_reservations.Text += "\n" + "";
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
            pageController.SelectedTab = page_makeReservation_Detail;
            page_makeApp_detail_title.Text = "Köfteci Yusuf";
        }

        private void button_burgerSelectClick(object sender, EventArgs e)
        {
            pageController.SelectedTab = page_makeReservation_Detail;
            page_makeApp_detail_title.Text = "Burger King";
        }
        //
        //Profil görüntüle sayfası buttonları
        //
        bool doesEditActive = false;
        private void profile_button_edit_Click(object sender, EventArgs e)
        {
            if(doesEditActive)
            {
                doesEditActive = false;
                profile_message.Text = "";
                profile_textbox_email.Visible = false;
                profile_textbox_name.Visible = false;
                profile_textbox_surname.Visible = false;
                profile_textbox_tel.Visible = false; 
                profile_button_save.Visible = false;
                profile_button_save.Enabled = false;
                profile_button_edit.Text = "Düzenle";
                profile_button_edit.ForeColor = Color.FromArgb(100, 100, 255);
                profile_button_edit.FlatAppearance.BorderColor = Color.FromArgb(100, 100, 255);
                profile_button_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(40, 40, 100);
                profile_button_edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 100);
            }
            else
            {
                doesEditActive = true;
                profile_message.Text = "";
                profile_textbox_email.Visible = true;
                profile_textbox_name.Visible = true;
                profile_textbox_surname.Visible = true;
                profile_textbox_tel.Visible = true;
                profile_button_save.Visible = true;
                profile_button_save.Enabled = true;
                profile_button_edit.Text = "Geri dön";
                profile_button_edit.ForeColor = Color.Red;
                profile_button_edit.FlatAppearance.BorderColor = Color.Red;
                profile_button_edit.FlatAppearance.MouseDownBackColor = Color.FromArgb(100,0,0);
                profile_button_edit.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0);

            }
        }

        private void profile_button_save_Click(object sender, EventArgs e)
        {
            if (!profileCheckNull())
            {
                profile_message.ForeColor = Color.Green;
                profile_message.Text = "Başarıyla kaydedildi.";
            }
            else
            {
                profile_message.ForeColor = Color.Red;
                profile_message.Text = "Hatalı değer girdiniz! Lütfen tekrar deneyin.";
            }
        }
        //
        //girilen değerler boş mu kontrol yapan fonksiyon
        //
        private bool profileCheckNull()
        {
            if (profile_textbox_email.Text.Equals("")
                || profile_textbox_name.Text.Equals("")
                || profile_textbox_surname.Text.Equals("")
                || profile_textbox_tel.Text.Equals("")
                ) return true;
            else return false;
        }
        //
        //Randevu oluşturma detayına inen sayfadaki buttonlar
        //
        private void page_makeApp_detail_return_Click(object sender, EventArgs e)
        {
            pageController.SelectedTab = page_makeReservation;
        }

        private void page_makeApp_detail_confirm_Click(object sender, EventArgs e)
        {
            String date = page_makeApp_detail_datePicker.ToString();
            String hour = page_makeApp_detail_timePicker.ToString();
            
        }
    }
}
