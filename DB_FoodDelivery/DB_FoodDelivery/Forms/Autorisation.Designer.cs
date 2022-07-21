namespace DB_FoodDelivery
{
    partial class Autorisation
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
            this.lbFP = new System.Windows.Forms.Label();
            this.lbToRegistr = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnReMove = new System.Windows.Forms.PictureBox();
            this.btnViewPass = new System.Windows.Forms.PictureBox();
            this.btnRecovery = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNotifications = new System.Windows.Forms.Label();
            this.tbLoginRec = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.tmrMoveLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrPassView = new System.Windows.Forms.Timer(this.components);
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.tmrReSize = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFP
            // 
            this.lbFP.AutoSize = true;
            this.lbFP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbFP.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFP.Location = new System.Drawing.Point(291, 308);
            this.lbFP.Name = "lbFP";
            this.lbFP.Size = new System.Drawing.Size(164, 23);
            this.lbFP.TabIndex = 10;
            this.lbFP.Text = "Вы забыли пароль?";
            this.lbFP.Click += new System.EventHandler(this.lbFP_Click);
            // 
            // lbToRegistr
            // 
            this.lbToRegistr.AutoSize = true;
            this.lbToRegistr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbToRegistr.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbToRegistr.Location = new System.Drawing.Point(174, 480);
            this.lbToRegistr.Name = "lbToRegistr";
            this.lbToRegistr.Size = new System.Drawing.Size(208, 23);
            this.lbToRegistr.TabIndex = 9;
            this.lbToRegistr.Text = "У Вас ещё нет аккаунта?";
            this.lbToRegistr.Click += new System.EventHandler(this.lbToRegistr_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.Location = new System.Drawing.Point(149, 421);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(262, 42);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.Gray;
            this.tbPassword.Location = new System.Drawing.Point(295, 268);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(164, 37);
            this.tbPassword.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(98, 263);
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
            this.label2.Location = new System.Drawing.Point(98, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.Color.Gray;
            this.tbLogin.Location = new System.Drawing.Point(295, 214);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(164, 37);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Click += new System.EventHandler(this.tbLogin_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.BackgroundImage = global::DB_FoodDelivery.Properties.Resources.Autorisation_bg;
            this.MainPanel.Controls.Add(this.btnReMove);
            this.MainPanel.Controls.Add(this.btnViewPass);
            this.MainPanel.Controls.Add(this.btnRecovery);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.lbNotifications);
            this.MainPanel.Controls.Add(this.tbLoginRec);
            this.MainPanel.Controls.Add(this.btnClose);
            this.MainPanel.Controls.Add(this.lbFP);
            this.MainPanel.Controls.Add(this.lbToRegistr);
            this.MainPanel.Controls.Add(this.btnEnter);
            this.MainPanel.Controls.Add(this.tbPassword);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.tbLogin);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(557, 557);
            this.MainPanel.TabIndex = 7;
            // 
            // btnReMove
            // 
            this.btnReMove.Image = global::DB_FoodDelivery.Properties.Resources.ArrowIcon;
            this.btnReMove.Location = new System.Drawing.Point(1056, 16);
            this.btnReMove.Name = "btnReMove";
            this.btnReMove.Size = new System.Drawing.Size(25, 25);
            this.btnReMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnReMove.TabIndex = 15;
            this.btnReMove.TabStop = false;
            this.btnReMove.Click += new System.EventHandler(this.btnReMove_Click_1);
            // 
            // btnViewPass
            // 
            this.btnViewPass.BackColor = System.Drawing.Color.Transparent;
            this.btnViewPass.Image = global::DB_FoodDelivery.Properties.Resources.ViewPassIcon;
            this.btnViewPass.Location = new System.Drawing.Point(465, 276);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(29, 18);
            this.btnViewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnViewPass.TabIndex = 14;
            this.btnViewPass.TabStop = false;
            this.btnViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.BackColor = System.Drawing.Color.Transparent;
            this.btnRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecovery.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecovery.ForeColor = System.Drawing.Color.Black;
            this.btnRecovery.Location = new System.Drawing.Point(701, 313);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(262, 42);
            this.btnRecovery.TabIndex = 13;
            this.btnRecovery.Text = "Восстановить";
            this.btnRecovery.UseVisualStyleBackColor = false;
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(682, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // lbNotifications
            // 
            this.lbNotifications.AutoSize = true;
            this.lbNotifications.BackColor = System.Drawing.Color.Transparent;
            this.lbNotifications.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNotifications.ForeColor = System.Drawing.Color.Red;
            this.lbNotifications.Location = new System.Drawing.Point(122, 356);
            this.lbNotifications.Name = "lbNotifications";
            this.lbNotifications.Size = new System.Drawing.Size(19, 24);
            this.lbNotifications.TabIndex = 11;
            this.lbNotifications.Text = "-";
            this.lbNotifications.Visible = false;
            // 
            // tbLoginRec
            // 
            this.tbLoginRec.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLoginRec.ForeColor = System.Drawing.Color.Gray;
            this.tbLoginRec.Location = new System.Drawing.Point(822, 200);
            this.tbLoginRec.Multiline = true;
            this.tbLoginRec.Name = "tbLoginRec";
            this.tbLoginRec.Size = new System.Drawing.Size(164, 37);
            this.tbLoginRec.TabIndex = 8;
            this.tbLoginRec.Click += new System.EventHandler(this.tbLoginRec_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::DB_FoodDelivery.Properties.Resources.ImgExitReg;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(509, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tmrMoveLeft
            // 
            this.tmrMoveLeft.Interval = 5;
            // 
            // tmrPassView
            // 
            this.tmrPassView.Interval = 10;
            this.tmrPassView.Tick += new System.EventHandler(this.tmrPassView_Tick);
            // 
            // tmrReSize
            // 
            this.tmrReSize.Interval = 5;
            this.tmrReSize.Tick += new System.EventHandler(this.tmrReSize_Tick);
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_FoodDelivery.Properties.Resources.Autorisation_bg;
            this.ClientSize = new System.Drawing.Size(557, 557);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autorisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autorisation";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFP;
        private System.Windows.Forms.Label lbToRegistr;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lbNotifications;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLoginRec;
        private System.Windows.Forms.Timer tmrMoveLeft;
        private System.Windows.Forms.Button btnRecovery;
        private System.Windows.Forms.PictureBox btnViewPass;
        private System.Windows.Forms.Timer tmrPassView;
        private System.Windows.Forms.PictureBox btnReMove;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Timer tmrReSize;
    }
}