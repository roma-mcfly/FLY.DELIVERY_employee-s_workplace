namespace DB_FoodDelivery
{
    partial class Varification
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnBackAutorisation = new System.Windows.Forms.Label();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.btnReSend = new System.Windows.Forms.Label();
            this.lbHours = new System.Windows.Forms.Label();
            this.lbUnCorrectKey = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.Location = new System.Drawing.Point(192, 207);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(262, 42);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKey.ForeColor = System.Drawing.Color.Gray;
            this.tbKey.Location = new System.Drawing.Point(242, 133);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(164, 37);
            this.tbKey.TabIndex = 15;
            // 
            // btnBackAutorisation
            // 
            this.btnBackAutorisation.AutoSize = true;
            this.btnBackAutorisation.BackColor = System.Drawing.Color.Transparent;
            this.btnBackAutorisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAutorisation.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackAutorisation.Location = new System.Drawing.Point(221, 267);
            this.btnBackAutorisation.Name = "btnBackAutorisation";
            this.btnBackAutorisation.Size = new System.Drawing.Size(211, 23);
            this.btnBackAutorisation.TabIndex = 17;
            this.btnBackAutorisation.Text = "Вернуться к авторизации";
            this.btnBackAutorisation.Click += new System.EventHandler(this.btnBackAutorisation_Click);
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.BackColor = System.Drawing.Color.Transparent;
            this.lbMinutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMinutes.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMinutes.Location = new System.Drawing.Point(55, 267);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(21, 23);
            this.lbMinutes.TabIndex = 18;
            this.lbMinutes.Text = "0";
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 500;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // btnReSend
            // 
            this.btnReSend.AutoSize = true;
            this.btnReSend.BackColor = System.Drawing.Color.Transparent;
            this.btnReSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReSend.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReSend.ForeColor = System.Drawing.Color.Red;
            this.btnReSend.Location = new System.Drawing.Point(188, 173);
            this.btnReSend.Name = "btnReSend";
            this.btnReSend.Size = new System.Drawing.Size(273, 23);
            this.btnReSend.TabIndex = 19;
            this.btnReSend.Text = "Отправить письмо повторно";
            this.btnReSend.Visible = false;
            this.btnReSend.Click += new System.EventHandler(this.btnReSend_Click);
            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.BackColor = System.Drawing.Color.Transparent;
            this.lbHours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbHours.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHours.Location = new System.Drawing.Point(25, 267);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(31, 23);
            this.lbHours.TabIndex = 20;
            this.lbHours.Text = "0 :";
            // 
            // lbUnCorrectKey
            // 
            this.lbUnCorrectKey.AutoSize = true;
            this.lbUnCorrectKey.BackColor = System.Drawing.Color.Transparent;
            this.lbUnCorrectKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUnCorrectKey.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUnCorrectKey.ForeColor = System.Drawing.Color.Red;
            this.lbUnCorrectKey.Location = new System.Drawing.Point(422, 141);
            this.lbUnCorrectKey.Name = "lbUnCorrectKey";
            this.lbUnCorrectKey.Size = new System.Drawing.Size(166, 23);
            this.lbUnCorrectKey.TabIndex = 21;
            this.lbUnCorrectKey.Text = "Не верный ключ!";
            this.lbUnCorrectKey.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::DB_FoodDelivery.Properties.Resources.ImgExitReg;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(600, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Varification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_FoodDelivery.Properties.Resources.Varification_bg;
            this.ClientSize = new System.Drawing.Size(646, 309);
            this.Controls.Add(this.lbUnCorrectKey);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.btnReSend);
            this.Controls.Add(this.lbMinutes);
            this.Controls.Add(this.btnBackAutorisation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.btnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Varification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varification";
            this.Load += new System.EventHandler(this.Varification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label btnBackAutorisation;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label btnReSend;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.Label lbUnCorrectKey;
    }
}