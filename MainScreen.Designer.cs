using System.Windows.Forms;

namespace RestaurantSystem
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.button_profile = new System.Windows.Forms.Button();
            this.button_makeAppointment = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_showAppointments = new System.Windows.Forms.Button();
            this.pageController = new System.Windows.Forms.TabControl();
            this.page_getRes = new System.Windows.Forms.TabPage();
            this.button_burgerSelect = new System.Windows.Forms.Button();
            this.button_yusufSelect = new System.Windows.Forms.Button();
            this.page_getRes_Detail = new System.Windows.Forms.TabPage();
            this.page_getRes_detail_return = new System.Windows.Forms.Button();
            this.page_getRes_detail_confirm = new System.Windows.Forms.Button();
            this.page_getRes_detail_label2 = new System.Windows.Forms.Label();
            this.page_getRes_detail_label1 = new System.Windows.Forms.Label();
            this.page_getRes_detail_datePicker = new System.Windows.Forms.DateTimePicker();
            this.page_getRes_detail_timePicker = new System.Windows.Forms.DateTimePicker();
            this.page_getRes_detail_title = new System.Windows.Forms.Label();
            this.page_getRes_detail_text = new System.Windows.Forms.Label();
            this.page_showReservations = new System.Windows.Forms.TabPage();
            this.page_showReservations_text = new System.Windows.Forms.Label();
            this.page_showReservations_label = new System.Windows.Forms.Label();
            this.page_profile = new System.Windows.Forms.TabPage();
            this.profile_message = new System.Windows.Forms.Label();
            this.profile_textbox_name = new System.Windows.Forms.TextBox();
            this.profile_textbox_tel = new System.Windows.Forms.TextBox();
            this.profile_textbox_email = new System.Windows.Forms.TextBox();
            this.profile_textbox_surname = new System.Windows.Forms.TextBox();
            this.profile_button_save = new System.Windows.Forms.Button();
            this.profile_button_edit = new System.Windows.Forms.Button();
            this.profile_surname = new System.Windows.Forms.Label();
            this.profile_name = new System.Windows.Forms.Label();
            this.profile_tel = new System.Windows.Forms.Label();
            this.profile_email = new System.Windows.Forms.Label();
            this.profile_username = new System.Windows.Forms.Label();
            this.pageController.SuspendLayout();
            this.page_getRes.SuspendLayout();
            this.page_getRes_Detail.SuspendLayout();
            this.page_showReservations.SuspendLayout();
            this.page_profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_profile
            // 
            this.button_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_profile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_profile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_profile.ForeColor = System.Drawing.Color.White;
            this.button_profile.Location = new System.Drawing.Point(-1, 157);
            this.button_profile.Margin = new System.Windows.Forms.Padding(0);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(127, 80);
            this.button_profile.TabIndex = 4;
            this.button_profile.Text = "Profili Görüntüle";
            this.button_profile.UseVisualStyleBackColor = false;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // button_makeAppointment
            // 
            this.button_makeAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_makeAppointment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_makeAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button_makeAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button_makeAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_makeAppointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_makeAppointment.ForeColor = System.Drawing.Color.White;
            this.button_makeAppointment.Location = new System.Drawing.Point(-1, -3);
            this.button_makeAppointment.Margin = new System.Windows.Forms.Padding(0);
            this.button_makeAppointment.Name = "button_makeAppointment";
            this.button_makeAppointment.Size = new System.Drawing.Size(127, 80);
            this.button_makeAppointment.TabIndex = 3;
            this.button_makeAppointment.Text = "Rezervasyon Yap";
            this.button_makeAppointment.UseVisualStyleBackColor = false;
            this.button_makeAppointment.Click += new System.EventHandler(this.button_makeAppointment_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_logout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_logout.ForeColor = System.Drawing.Color.Red;
            this.button_logout.Location = new System.Drawing.Point(0, 237);
            this.button_logout.Margin = new System.Windows.Forms.Padding(0);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(127, 80);
            this.button_logout.TabIndex = 2;
            this.button_logout.Text = "Çıkış Yap";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_showAppointments
            // 
            this.button_showAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_showAppointments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_showAppointments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button_showAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.button_showAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showAppointments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_showAppointments.ForeColor = System.Drawing.Color.White;
            this.button_showAppointments.Location = new System.Drawing.Point(-1, 77);
            this.button_showAppointments.Margin = new System.Windows.Forms.Padding(0);
            this.button_showAppointments.Name = "button_showAppointments";
            this.button_showAppointments.Size = new System.Drawing.Size(127, 80);
            this.button_showAppointments.TabIndex = 1;
            this.button_showAppointments.Text = "Rezervasyonları Görüntüle";
            this.button_showAppointments.UseVisualStyleBackColor = false;
            this.button_showAppointments.Click += new System.EventHandler(this.button_showAppointments_Click);
            // 
            // pageController
            // 
            this.pageController.Controls.Add(this.page_getRes);
            this.pageController.Controls.Add(this.page_getRes_Detail);
            this.pageController.Controls.Add(this.page_showReservations);
            this.pageController.Controls.Add(this.page_profile);
            this.pageController.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageController.Location = new System.Drawing.Point(-8, -35);
            this.pageController.Name = "pageController";
            this.pageController.SelectedIndex = 0;
            this.pageController.Size = new System.Drawing.Size(813, 491);
            this.pageController.TabIndex = 5;
            // 
            // page_getRes
            // 
            this.page_getRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.page_getRes.Controls.Add(this.button_burgerSelect);
            this.page_getRes.Controls.Add(this.button_yusufSelect);
            this.page_getRes.ForeColor = System.Drawing.Color.White;
            this.page_getRes.Location = new System.Drawing.Point(4, 30);
            this.page_getRes.Name = "page_getRes";
            this.page_getRes.Size = new System.Drawing.Size(805, 457);
            this.page_getRes.TabIndex = 0;
            // 
            // button_burgerSelect
            // 
            this.button_burgerSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_burgerSelect.BackgroundImage")));
            this.button_burgerSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_burgerSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_burgerSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_burgerSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_burgerSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_burgerSelect.Location = new System.Drawing.Point(443, 85);
            this.button_burgerSelect.Name = "button_burgerSelect";
            this.button_burgerSelect.Size = new System.Drawing.Size(233, 233);
            this.button_burgerSelect.TabIndex = 1;
            this.button_burgerSelect.UseVisualStyleBackColor = true;
            this.button_burgerSelect.Click += new System.EventHandler(this.button_burgerSelectClick);
            // 
            // button_yusufSelect
            // 
            this.button_yusufSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_yusufSelect.BackgroundImage")));
            this.button_yusufSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_yusufSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_yusufSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_yusufSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_yusufSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yusufSelect.Location = new System.Drawing.Point(184, 85);
            this.button_yusufSelect.Name = "button_yusufSelect";
            this.button_yusufSelect.Size = new System.Drawing.Size(233, 233);
            this.button_yusufSelect.TabIndex = 0;
            this.button_yusufSelect.UseVisualStyleBackColor = true;
            this.button_yusufSelect.Click += new System.EventHandler(this.button_yusufSelectClick);
            // 
            // page_getRes_Detail
            // 
            this.page_getRes_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.page_getRes_Detail.Controls.Add(this.page_getRes_detail_return);
            this.page_getRes_Detail.Controls.Add(this.page_getRes_detail_confirm);
            this.page_getRes_Detail.Controls.Add(this.page_getRes_detail_label2);
            this.page_getRes_Detail.Controls.Add(this.page_getRes_detail_label1);
            this.page_getRes_Detail.Controls.Add(this.page_getRes_detail_datePicker);
            this.page_getRes_Detail.Controls.Add(this.page_getRes_detail_timePicker);
            this.page_getRes_Detail.Controls.Add(this.page_getRes_detail_title);
            this.page_getRes_Detail.Controls.Add(this.page_getRes_detail_text);
            this.page_getRes_Detail.ForeColor = System.Drawing.Color.White;
            this.page_getRes_Detail.Location = new System.Drawing.Point(4, 30);
            this.page_getRes_Detail.Name = "page_getRes_Detail";
            this.page_getRes_Detail.Size = new System.Drawing.Size(805, 457);
            this.page_getRes_Detail.TabIndex = 2;
            // 
            // page_getRes_detail_return
            // 
            this.page_getRes_detail_return.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.page_getRes_detail_return.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.page_getRes_detail_return.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.page_getRes_detail_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page_getRes_detail_return.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.page_getRes_detail_return.ForeColor = System.Drawing.Color.Red;
            this.page_getRes_detail_return.Location = new System.Drawing.Point(293, 213);
            this.page_getRes_detail_return.Name = "page_getRes_detail_return";
            this.page_getRes_detail_return.Size = new System.Drawing.Size(74, 40);
            this.page_getRes_detail_return.TabIndex = 21;
            this.page_getRes_detail_return.Text = "Geri Dön";
            this.page_getRes_detail_return.UseVisualStyleBackColor = true;
            this.page_getRes_detail_return.Click += new System.EventHandler(this.page_makeApp_detail_return_Click);
            // 
            // page_getRes_detail_confirm
            // 
            this.page_getRes_detail_confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.page_getRes_detail_confirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.page_getRes_detail_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.page_getRes_detail_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.page_getRes_detail_confirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.page_getRes_detail_confirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.page_getRes_detail_confirm.Location = new System.Drawing.Point(570, 213);
            this.page_getRes_detail_confirm.Name = "page_getRes_detail_confirm";
            this.page_getRes_detail_confirm.Size = new System.Drawing.Size(74, 40);
            this.page_getRes_detail_confirm.TabIndex = 20;
            this.page_getRes_detail_confirm.Text = "Randevu Al";
            this.page_getRes_detail_confirm.UseVisualStyleBackColor = true;
            this.page_getRes_detail_confirm.Click += new System.EventHandler(this.page_makeApp_detail_confirm_Click);
            // 
            // page_getRes_detail_label2
            // 
            this.page_getRes_detail_label2.AutoSize = true;
            this.page_getRes_detail_label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.page_getRes_detail_label2.Location = new System.Drawing.Point(510, 165);
            this.page_getRes_detail_label2.Name = "page_getRes_detail_label2";
            this.page_getRes_detail_label2.Size = new System.Drawing.Size(55, 25);
            this.page_getRes_detail_label2.TabIndex = 5;
            this.page_getRes_detail_label2.Text = "Saat:";
            // 
            // page_getRes_detail_label1
            // 
            this.page_getRes_detail_label1.AutoSize = true;
            this.page_getRes_detail_label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.page_getRes_detail_label1.Location = new System.Drawing.Point(302, 165);
            this.page_getRes_detail_label1.Name = "page_getRes_detail_label1";
            this.page_getRes_detail_label1.Size = new System.Drawing.Size(65, 25);
            this.page_getRes_detail_label1.TabIndex = 4;
            this.page_getRes_detail_label1.Text = "Tarih: ";
            // 
            // page_getRes_detail_datePicker
            // 
            this.page_getRes_detail_datePicker.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.page_getRes_detail_datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.page_getRes_detail_datePicker.Location = new System.Drawing.Point(373, 162);
            this.page_getRes_detail_datePicker.Name = "page_getRes_detail_datePicker";
            this.page_getRes_detail_datePicker.ShowUpDown = true;
            this.page_getRes_detail_datePicker.Size = new System.Drawing.Size(128, 32);
            this.page_getRes_detail_datePicker.TabIndex = 3;
            // 
            // page_getRes_detail_timePicker
            // 
            this.page_getRes_detail_timePicker.CustomFormat = "HH:mm";
            this.page_getRes_detail_timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.page_getRes_detail_timePicker.Location = new System.Drawing.Point(570, 165);
            this.page_getRes_detail_timePicker.Name = "page_getRes_detail_timePicker";
            this.page_getRes_detail_timePicker.ShowUpDown = true;
            this.page_getRes_detail_timePicker.Size = new System.Drawing.Size(74, 29);
            this.page_getRes_detail_timePicker.TabIndex = 2;
            // 
            // page_getRes_detail_title
            // 
            this.page_getRes_detail_title.AutoSize = true;
            this.page_getRes_detail_title.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.page_getRes_detail_title.Location = new System.Drawing.Point(225, 35);
            this.page_getRes_detail_title.Name = "page_getRes_detail_title";
            this.page_getRes_detail_title.Size = new System.Drawing.Size(204, 41);
            this.page_getRes_detail_title.TabIndex = 1;
            this.page_getRes_detail_title.Text = "Köfteci Yusuf";
            // 
            // page_getRes_detail_text
            // 
            this.page_getRes_detail_text.AutoSize = true;
            this.page_getRes_detail_text.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.page_getRes_detail_text.Location = new System.Drawing.Point(228, 111);
            this.page_getRes_detail_text.Name = "page_getRes_detail_text";
            this.page_getRes_detail_text.Size = new System.Drawing.Size(416, 25);
            this.page_getRes_detail_text.TabIndex = 0;
            this.page_getRes_detail_text.Text = "Lütfen randevu almak istediğiniz tarihi seçiniz";
            // 
            // page_showReservations
            // 
            this.page_showReservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.page_showReservations.Controls.Add(this.page_showReservations_text);
            this.page_showReservations.Controls.Add(this.page_showReservations_label);
            this.page_showReservations.ForeColor = System.Drawing.Color.White;
            this.page_showReservations.Location = new System.Drawing.Point(4, 30);
            this.page_showReservations.Name = "page_showReservations";
            this.page_showReservations.Size = new System.Drawing.Size(805, 457);
            this.page_showReservations.TabIndex = 1;
            // 
            // page_showReservations_text
            // 
            this.page_showReservations_text.AutoSize = true;
            this.page_showReservations_text.Location = new System.Drawing.Point(423, 82);
            this.page_showReservations_text.Name = "page_showReservations_text";
            this.page_showReservations_text.Size = new System.Drawing.Size(0, 21);
            this.page_showReservations_text.TabIndex = 1;
            // 
            // page_showReservations_label
            // 
            this.page_showReservations_label.AutoSize = true;
            this.page_showReservations_label.Location = new System.Drawing.Point(235, 82);
            this.page_showReservations_label.Name = "page_showReservations_label";
            this.page_showReservations_label.Size = new System.Drawing.Size(163, 21);
            this.page_showReservations_label.TabIndex = 0;
            this.page_showReservations_label.Text = "Rezervasyonlarınız: ";
            // 
            // page_profile
            // 
            this.page_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.page_profile.Controls.Add(this.profile_message);
            this.page_profile.Controls.Add(this.profile_textbox_name);
            this.page_profile.Controls.Add(this.profile_textbox_tel);
            this.page_profile.Controls.Add(this.profile_textbox_email);
            this.page_profile.Controls.Add(this.profile_textbox_surname);
            this.page_profile.Controls.Add(this.profile_button_save);
            this.page_profile.Controls.Add(this.profile_button_edit);
            this.page_profile.Controls.Add(this.profile_surname);
            this.page_profile.Controls.Add(this.profile_name);
            this.page_profile.Controls.Add(this.profile_tel);
            this.page_profile.Controls.Add(this.profile_email);
            this.page_profile.Controls.Add(this.profile_username);
            this.page_profile.ForeColor = System.Drawing.Color.White;
            this.page_profile.Location = new System.Drawing.Point(4, 30);
            this.page_profile.Name = "page_profile";
            this.page_profile.Size = new System.Drawing.Size(805, 457);
            this.page_profile.TabIndex = 4;
            // 
            // profile_message
            // 
            this.profile_message.AutoSize = true;
            this.profile_message.BackColor = System.Drawing.Color.Transparent;
            this.profile_message.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.profile_message.ForeColor = System.Drawing.Color.White;
            this.profile_message.Location = new System.Drawing.Point(506, 289);
            this.profile_message.Name = "profile_message";
            this.profile_message.Size = new System.Drawing.Size(0, 19);
            this.profile_message.TabIndex = 26;
            // 
            // profile_textbox_name
            // 
            this.profile_textbox_name.Location = new System.Drawing.Point(413, 125);
            this.profile_textbox_name.Name = "profile_textbox_name";
            this.profile_textbox_name.Size = new System.Drawing.Size(251, 29);
            this.profile_textbox_name.TabIndex = 25;
            this.profile_textbox_name.Visible = false;
            // 
            // profile_textbox_tel
            // 
            this.profile_textbox_tel.Location = new System.Drawing.Point(413, 238);
            this.profile_textbox_tel.Name = "profile_textbox_tel";
            this.profile_textbox_tel.Size = new System.Drawing.Size(251, 29);
            this.profile_textbox_tel.TabIndex = 24;
            this.profile_textbox_tel.Visible = false;
            // 
            // profile_textbox_email
            // 
            this.profile_textbox_email.Location = new System.Drawing.Point(413, 199);
            this.profile_textbox_email.Name = "profile_textbox_email";
            this.profile_textbox_email.Size = new System.Drawing.Size(251, 29);
            this.profile_textbox_email.TabIndex = 23;
            this.profile_textbox_email.Visible = false;
            // 
            // profile_textbox_surname
            // 
            this.profile_textbox_surname.Location = new System.Drawing.Point(413, 160);
            this.profile_textbox_surname.Name = "profile_textbox_surname";
            this.profile_textbox_surname.Size = new System.Drawing.Size(251, 29);
            this.profile_textbox_surname.TabIndex = 22;
            this.profile_textbox_surname.Visible = false;
            // 
            // profile_button_save
            // 
            this.profile_button_save.Enabled = false;
            this.profile_button_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.profile_button_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.profile_button_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.profile_button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_button_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.profile_button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.profile_button_save.Location = new System.Drawing.Point(412, 284);
            this.profile_button_save.Name = "profile_button_save";
            this.profile_button_save.Size = new System.Drawing.Size(74, 29);
            this.profile_button_save.TabIndex = 19;
            this.profile_button_save.Text = "Kaydet";
            this.profile_button_save.UseVisualStyleBackColor = true;
            this.profile_button_save.Visible = false;
            this.profile_button_save.Click += new System.EventHandler(this.profile_button_save_Click);
            // 
            // profile_button_edit
            // 
            this.profile_button_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.profile_button_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.profile_button_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.profile_button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_button_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.profile_button_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.profile_button_edit.Location = new System.Drawing.Point(332, 284);
            this.profile_button_edit.Name = "profile_button_edit";
            this.profile_button_edit.Size = new System.Drawing.Size(74, 29);
            this.profile_button_edit.TabIndex = 18;
            this.profile_button_edit.Text = "Düzenle";
            this.profile_button_edit.UseVisualStyleBackColor = true;
            this.profile_button_edit.Click += new System.EventHandler(this.profile_button_edit_Click);
            // 
            // profile_surname
            // 
            this.profile_surname.AutoSize = true;
            this.profile_surname.BackColor = System.Drawing.Color.Transparent;
            this.profile_surname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profile_surname.ForeColor = System.Drawing.Color.White;
            this.profile_surname.Location = new System.Drawing.Point(329, 163);
            this.profile_surname.Name = "profile_surname";
            this.profile_surname.Size = new System.Drawing.Size(78, 21);
            this.profile_surname.TabIndex = 17;
            this.profile_surname.Text = "Soyisim: ";
            // 
            // profile_name
            // 
            this.profile_name.AutoSize = true;
            this.profile_name.BackColor = System.Drawing.Color.Transparent;
            this.profile_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profile_name.ForeColor = System.Drawing.Color.White;
            this.profile_name.Location = new System.Drawing.Point(357, 124);
            this.profile_name.Name = "profile_name";
            this.profile_name.Size = new System.Drawing.Size(50, 21);
            this.profile_name.TabIndex = 16;
            this.profile_name.Text = "İsim: ";
            // 
            // profile_tel
            // 
            this.profile_tel.AutoSize = true;
            this.profile_tel.BackColor = System.Drawing.Color.Transparent;
            this.profile_tel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profile_tel.ForeColor = System.Drawing.Color.White;
            this.profile_tel.Location = new System.Drawing.Point(332, 241);
            this.profile_tel.Name = "profile_tel";
            this.profile_tel.Size = new System.Drawing.Size(75, 21);
            this.profile_tel.TabIndex = 15;
            this.profile_tel.Text = "Telefon: ";
            // 
            // profile_email
            // 
            this.profile_email.AutoSize = true;
            this.profile_email.BackColor = System.Drawing.Color.Transparent;
            this.profile_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profile_email.ForeColor = System.Drawing.Color.White;
            this.profile_email.Location = new System.Drawing.Point(328, 202);
            this.profile_email.Name = "profile_email";
            this.profile_email.Size = new System.Drawing.Size(79, 21);
            this.profile_email.TabIndex = 14;
            this.profile_email.Text = "E- posta: ";
            // 
            // profile_username
            // 
            this.profile_username.AutoSize = true;
            this.profile_username.BackColor = System.Drawing.Color.Transparent;
            this.profile_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profile_username.ForeColor = System.Drawing.Color.White;
            this.profile_username.Location = new System.Drawing.Point(292, 82);
            this.profile_username.Name = "profile_username";
            this.profile_username.Size = new System.Drawing.Size(115, 21);
            this.profile_username.TabIndex = 12;
            this.profile_username.Text = "Kullanıcı Adı: ";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_profile);
            this.Controls.Add(this.button_makeAppointment);
            this.Controls.Add(this.button_showAppointments);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.pageController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainScreen";
            this.Text = "Rezervasyon Yap";
            this.pageController.ResumeLayout(false);
            this.page_getRes.ResumeLayout(false);
            this.page_getRes_Detail.ResumeLayout(false);
            this.page_getRes_Detail.PerformLayout();
            this.page_showReservations.ResumeLayout(false);
            this.page_showReservations.PerformLayout();
            this.page_profile.ResumeLayout(false);
            this.page_profile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button button_showAppointments;
        public System.Windows.Forms.Button button_logout;
        public System.Windows.Forms.Button button_makeAppointment;
        public System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.TabControl pageController;
        private System.Windows.Forms.TabPage page_getRes;
        private System.Windows.Forms.TabPage page_showReservations;
        private System.Windows.Forms.Button button_yusufSelect;
        private System.Windows.Forms.Button button_burgerSelect;
        private System.Windows.Forms.TabPage page_getRes_Detail;
        private System.Windows.Forms.Label page_getRes_detail_text;
        private System.Windows.Forms.TabPage page_profile;
        private System.Windows.Forms.Label profile_surname;
        private System.Windows.Forms.Label profile_name;
        private System.Windows.Forms.Label profile_tel;
        private System.Windows.Forms.Label profile_email;
        private System.Windows.Forms.Label profile_username;
        private System.Windows.Forms.Button profile_button_save;
        private System.Windows.Forms.Button profile_button_edit;
        private System.Windows.Forms.TextBox profile_textbox_tel;
        private System.Windows.Forms.TextBox profile_textbox_email;
        private System.Windows.Forms.TextBox profile_textbox_surname;
        private System.Windows.Forms.TextBox profile_textbox_name;
        private System.Windows.Forms.Label profile_message;
        private System.Windows.Forms.Label page_getRes_detail_title;
        private System.Windows.Forms.DateTimePicker page_getRes_detail_timePicker;
        private DateTimePicker page_getRes_detail_datePicker;
        private Label page_getRes_detail_label1;
        private Label page_getRes_detail_label2;
        private Button page_getRes_detail_confirm;
        private Button page_getRes_detail_return;
        private Label page_showReservations_text;
        private Label page_showReservations_label;
    }
}