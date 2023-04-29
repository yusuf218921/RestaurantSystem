namespace RestaurantSystem
{
    partial class LoginScreen
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
            
            this.button_signin = new System.Windows.Forms.Button();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.label_forgotPass = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_showHide = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            //
            //password hide
            //
            this.textbox_password.UseSystemPasswordChar = true;
            // 
            // button_signin
            // 
            this.button_signin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_signin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_signin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_signin.ForeColor = System.Drawing.Color.White;
            this.button_signin.Location = new System.Drawing.Point(703, 246);
            this.button_signin.Name = "button_signin";
            this.button_signin.Size = new System.Drawing.Size(65, 25);
            this.button_signin.TabIndex = 0;
            this.button_signin.Text = "Giriş Yap";
            this.button_signin.UseVisualStyleBackColor = true;
            this.button_signin.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(518, 202);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(250, 20);
            this.textbox_password.TabIndex = 2;
            // 
            // textbox_username
            // 
            this.textbox_username.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textbox_username.Location = new System.Drawing.Point(518, 163);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(250, 20);
            this.textbox_username.TabIndex = 3;
            this.textbox_username.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(403, 162);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(107, 21);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Kullanıcı Adı";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Transparent;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(432, 201);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(45, 21);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Şifre";
            // 
            // button_signup
            // 
            this.button_signup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button_signup.ForeColor = System.Drawing.Color.White;
            this.button_signup.Location = new System.Drawing.Point(623, 246);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(65, 25);
            this.button_signup.TabIndex = 8;
            this.button_signup.Text = "Kayıt Ol";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // label_forgotPass
            // 
            this.label_forgotPass.AutoSize = true;
            this.label_forgotPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label_forgotPass.ForeColor = System.Drawing.Color.White;
            this.label_forgotPass.Location = new System.Drawing.Point(515, 251);
            this.label_forgotPass.Name = "label_forgotPass";
            this.label_forgotPass.Size = new System.Drawing.Size(102, 15);
            this.label_forgotPass.TabIndex = 11;
            this.label_forgotPass.Text = "Şifremi Unuttum";
            this.label_forgotPass.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(400, 100);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(200, 40);
            this.label_welcome.TabIndex = 15;
            this.label_welcome.Text = "Hoşgeldiniz...";
            // 
            // button_showHide
            // 
            this.button_showHide.BackColor = System.Drawing.Color.White;
            this.button_showHide.BackgroundImage = global::RestaurantSystem.Properties.Resources.eye_password_hide_icon_512x512_iv45hct91;
            this.button_showHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_showHide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_showHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_showHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_showHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showHide.ForeColor = System.Drawing.Color.White;
            this.button_showHide.Location = new System.Drawing.Point(750, 203);
            this.button_showHide.Name = "button_showHide";
            this.button_showHide.Size = new System.Drawing.Size(18, 18);
            this.button_showHide.TabIndex = 14;
            this.button_showHide.UseVisualStyleBackColor = false;
            this.button_showHide.Click += new System.EventHandler(this.buttonShowHide_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RestaurantSystem.Properties.Resources._8e7392e045afce4456720c1aef91c013;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 461);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label_welcome);
            this.Controls.Add(this.button_showHide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_forgotPass);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textbox_username);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.button_signin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginScreen";
            this.Text = "Restorant Randevu - Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_signin;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.Label label_forgotPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_showHide;
    }
}

