namespace DB_FoodDelivery
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            this.tmrPassView = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnViewPass = new System.Windows.Forms.PictureBox();
            this.tbDoublePassword = new System.Windows.Forms.TextBox();
            this.cbPersonalInfo = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lbPasswordCheck = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPersInfo = new System.Windows.Forms.Label();
            this.btnBackAutorisation = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrPassView
            // 
            this.tmrPassView.Interval = 10;
            this.tmrPassView.Tick += new System.EventHandler(this.tmrPassView_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainPanel.BackgroundImage = global::DB_FoodDelivery.Properties.Resources.Registration_form;
            this.MainPanel.Controls.Add(this.btnViewPass);
            this.MainPanel.Controls.Add(this.tbDoublePassword);
            this.MainPanel.Controls.Add(this.cbPersonalInfo);
            this.MainPanel.Controls.Add(this.btnClose);
            this.MainPanel.Controls.Add(this.lbPasswordCheck);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.lbPersInfo);
            this.MainPanel.Controls.Add(this.btnBackAutorisation);
            this.MainPanel.Controls.Add(this.tbEmail);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.tbSurname);
            this.MainPanel.Controls.Add(this.tbName);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.btnRegistration);
            this.MainPanel.Controls.Add(this.tbPassword);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.tbLogin);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1065, 629);
            this.MainPanel.TabIndex = 8;
            // 
            // btnViewPass
            // 
            this.btnViewPass.BackColor = System.Drawing.Color.Transparent;
            this.btnViewPass.Image = global::DB_FoodDelivery.Properties.Resources.ViewPassIcon;
            this.btnViewPass.Location = new System.Drawing.Point(465, 373);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(29, 18);
            this.btnViewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnViewPass.TabIndex = 22;
            this.btnViewPass.TabStop = false;
            this.btnViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // tbDoublePassword
            // 
            this.tbDoublePassword.Font = new System.Drawing.Font("Roboto Lt", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDoublePassword.ForeColor = System.Drawing.Color.Gray;
            this.tbDoublePassword.Location = new System.Drawing.Point(782, 363);
            this.tbDoublePassword.Multiline = true;
            this.tbDoublePassword.Name = "tbDoublePassword";
            this.tbDoublePassword.PasswordChar = '*';
            this.tbDoublePassword.Size = new System.Drawing.Size(233, 37);
            this.tbDoublePassword.TabIndex = 18;
            // 
            // cbPersonalInfo
            // 
            this.cbPersonalInfo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPersonalInfo.ForeColor = System.Drawing.Color.Gray;
            this.cbPersonalInfo.FormattingEnabled = true;
            this.cbPersonalInfo.Location = new System.Drawing.Point(782, 216);
            this.cbPersonalInfo.Name = "cbPersonalInfo";
            this.cbPersonalInfo.Size = new System.Drawing.Size(233, 32);
            this.cbPersonalInfo.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::DB_FoodDelivery.Properties.Resources.ImgExitReg;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1014, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbPasswordCheck
            // 
            this.lbPasswordCheck.AutoSize = true;
            this.lbPasswordCheck.BackColor = System.Drawing.Color.Transparent;
            this.lbPasswordCheck.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPasswordCheck.ForeColor = System.Drawing.Color.Red;
            this.lbPasswordCheck.Location = new System.Drawing.Point(410, 440);
            this.lbPasswordCheck.Name = "lbPasswordCheck";
            this.lbPasswordCheck.Size = new System.Drawing.Size(219, 24);
            this.lbPasswordCheck.TabIndex = 19;
            this.lbPasswordCheck.Text = "Пароли не совпадают!";
            this.lbPasswordCheck.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(585, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Пароль*";
            // 
            // lbPersInfo
            // 
            this.lbPersInfo.AutoSize = true;
            this.lbPersInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbPersInfo.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPersInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPersInfo.Location = new System.Drawing.Point(585, 205);
            this.lbPersInfo.Name = "lbPersInfo";
            this.lbPersInfo.Size = new System.Drawing.Size(80, 42);
            this.lbPersInfo.TabIndex = 15;
            this.lbPersInfo.Text = "Info";
            // 
            // btnBackAutorisation
            // 
            this.btnBackAutorisation.AutoSize = true;
            this.btnBackAutorisation.BackColor = System.Drawing.Color.Transparent;
            this.btnBackAutorisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAutorisation.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackAutorisation.Location = new System.Drawing.Point(415, 570);
            this.btnBackAutorisation.Name = "btnBackAutorisation";
            this.btnBackAutorisation.Size = new System.Drawing.Size(211, 23);
            this.btnBackAutorisation.TabIndex = 10;
            this.btnBackAutorisation.Text = "Вернуться к авторизации";
            this.btnBackAutorisation.Click += new System.EventHandler(this.btnBackAutorisation_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.ForeColor = System.Drawing.Color.Gray;
            this.tbEmail.Location = new System.Drawing.Point(782, 150);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(233, 37);
            this.tbEmail.TabIndex = 14;
            this.tbEmail.Click += new System.EventHandler(this.tbEmail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(585, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 42);
            this.label7.TabIndex = 13;
            this.label7.Text = "Почта";
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.ForeColor = System.Drawing.Color.Gray;
            this.tbSurname.Location = new System.Drawing.Point(241, 259);
            this.tbSurname.Multiline = true;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(218, 37);
            this.tbSurname.TabIndex = 12;
            this.tbSurname.Click += new System.EventHandler(this.tbSurname_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.Gray;
            this.tbName.Location = new System.Drawing.Point(241, 205);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(218, 37);
            this.tbName.TabIndex = 11;
            this.tbName.Click += new System.EventHandler(this.tbName_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(51, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 42);
            this.label6.TabIndex = 10;
            this.label6.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(51, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "Имя";
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegistration.ForeColor = System.Drawing.Color.Black;
            this.btnRegistration.Location = new System.Drawing.Point(384, 499);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(262, 42);
            this.btnRegistration.TabIndex = 8;
            this.btnRegistration.Text = "Далее";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Roboto Lt", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.Gray;
            this.tbPassword.Location = new System.Drawing.Point(241, 363);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(218, 37);
            this.tbPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(51, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(51, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.Color.Gray;
            this.tbLogin.Location = new System.Drawing.Point(241, 150);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(218, 37);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Click += new System.EventHandler(this.tbLogin_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 629);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label btnBackAutorisation;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lbPersInfo;
        private System.Windows.Forms.TextBox tbDoublePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPasswordCheck;
        private System.Windows.Forms.Timer tmrPassView;
        private System.Windows.Forms.ComboBox cbPersonalInfo;
        private System.Windows.Forms.PictureBox btnViewPass;
    }
}