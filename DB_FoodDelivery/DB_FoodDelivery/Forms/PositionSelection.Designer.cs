namespace DB_FoodDelivery
{
    partial class PositionSelection
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
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.btnBackAutorisation = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPosition
            // 
            this.cbPosition.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPosition.ForeColor = System.Drawing.Color.Gray;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "курьер",
            "ресторатор"});
            this.cbPosition.Location = new System.Drawing.Point(197, 123);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(257, 32);
            this.cbPosition.TabIndex = 0;
            // 
            // btnBackAutorisation
            // 
            this.btnBackAutorisation.AutoSize = true;
            this.btnBackAutorisation.BackColor = System.Drawing.Color.Transparent;
            this.btnBackAutorisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAutorisation.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackAutorisation.Location = new System.Drawing.Point(218, 270);
            this.btnBackAutorisation.Name = "btnBackAutorisation";
            this.btnBackAutorisation.Size = new System.Drawing.Size(211, 23);
            this.btnBackAutorisation.TabIndex = 11;
            this.btnBackAutorisation.Text = "Вернуться к авторизации";
            this.btnBackAutorisation.Click += new System.EventHandler(this.btnBackAutorisation_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.ForeColor = System.Drawing.Color.Black;
            this.btnEnter.Location = new System.Drawing.Point(193, 207);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(262, 42);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // PositionSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DB_FoodDelivery.Properties.Resources.PositionSell_bg;
            this.ClientSize = new System.Drawing.Size(647, 308);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnBackAutorisation);
            this.Controls.Add(this.cbPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PositionSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PositionSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label btnBackAutorisation;
        private System.Windows.Forms.Button btnEnter;
    }
}