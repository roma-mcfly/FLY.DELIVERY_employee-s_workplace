namespace DB_FoodDelivery
{
    partial class MainFormCourier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormCourier));
            this.dtvMain = new System.Windows.Forms.DataGridView();
            this.Идентификатор = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Адрес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Телефон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Почта = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Время = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntDelOrder = new System.Windows.Forms.Button();
            this.btnMapView = new System.Windows.Forms.Button();
            this.lbWorkingTime = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pnWebBrowser = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUruchye = new System.Windows.Forms.Button();
            this.btnGrMeadow = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnCall = new System.Windows.Forms.Button();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.btnBackAutorisation = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbExcel = new System.Windows.Forms.PictureBox();
            this.pbReloadDtv = new System.Windows.Forms.PictureBox();
            this.pbScrenShot = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbTotalPriceText = new System.Windows.Forms.Label();
            this.cbCont = new System.Windows.Forms.ComboBox();
            this.btnContentOrder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCall = new System.Windows.Forms.ComboBox();
            this.cbMap = new System.Windows.Forms.ComboBox();
            this.cbDel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMain)).BeginInit();
            this.pnWebBrowser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadDtv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrenShot)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvMain
            // 
            this.dtvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Идентификатор,
            this.Имя,
            this.Фамилия,
            this.Адрес,
            this.Телефон,
            this.Почта,
            this.Время});
            this.dtvMain.Location = new System.Drawing.Point(37, 204);
            this.dtvMain.Name = "dtvMain";
            this.dtvMain.RowHeadersWidth = 51;
            this.dtvMain.RowTemplate.Height = 24;
            this.dtvMain.Size = new System.Drawing.Size(945, 239);
            this.dtvMain.TabIndex = 18;
            // 
            // Идентификатор
            // 
            this.Идентификатор.HeaderText = "Идентификатор";
            this.Идентификатор.MinimumWidth = 6;
            this.Идентификатор.Name = "Идентификатор";
            this.Идентификатор.Width = 125;
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.MinimumWidth = 6;
            this.Имя.Name = "Имя";
            this.Имя.Width = 125;
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.MinimumWidth = 6;
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Width = 125;
            // 
            // Адрес
            // 
            this.Адрес.HeaderText = "Адрес";
            this.Адрес.MinimumWidth = 6;
            this.Адрес.Name = "Адрес";
            this.Адрес.Width = 125;
            // 
            // Телефон
            // 
            this.Телефон.HeaderText = "Телефон";
            this.Телефон.MinimumWidth = 6;
            this.Телефон.Name = "Телефон";
            this.Телефон.Width = 125;
            // 
            // Почта
            // 
            this.Почта.HeaderText = "Почта";
            this.Почта.MinimumWidth = 6;
            this.Почта.Name = "Почта";
            this.Почта.Width = 125;
            // 
            // Время
            // 
            this.Время.HeaderText = "Время доставки";
            this.Время.MinimumWidth = 6;
            this.Время.Name = "Время";
            this.Время.Width = 125;
            // 
            // bntDelOrder
            // 
            this.bntDelOrder.BackColor = System.Drawing.Color.Transparent;
            this.bntDelOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntDelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntDelOrder.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntDelOrder.ForeColor = System.Drawing.Color.Black;
            this.bntDelOrder.Location = new System.Drawing.Point(269, 581);
            this.bntDelOrder.Name = "bntDelOrder";
            this.bntDelOrder.Size = new System.Drawing.Size(203, 80);
            this.bntDelOrder.TabIndex = 24;
            this.bntDelOrder.Text = "Отметить выполнение заказа";
            this.bntDelOrder.UseVisualStyleBackColor = false;
            this.bntDelOrder.Click += new System.EventHandler(this.bntDelOrder_Click);
            // 
            // btnMapView
            // 
            this.btnMapView.BackColor = System.Drawing.Color.Transparent;
            this.btnMapView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMapView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapView.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMapView.ForeColor = System.Drawing.Color.Black;
            this.btnMapView.Location = new System.Drawing.Point(503, 581);
            this.btnMapView.Name = "btnMapView";
            this.btnMapView.Size = new System.Drawing.Size(203, 80);
            this.btnMapView.TabIndex = 25;
            this.btnMapView.Text = "Посмотреть заказ на карте";
            this.btnMapView.UseVisualStyleBackColor = false;
            this.btnMapView.Click += new System.EventHandler(this.btnMapView_Click);
            // 
            // lbWorkingTime
            // 
            this.lbWorkingTime.AutoSize = true;
            this.lbWorkingTime.BackColor = System.Drawing.Color.Transparent;
            this.lbWorkingTime.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWorkingTime.Location = new System.Drawing.Point(258, 151);
            this.lbWorkingTime.Name = "lbWorkingTime";
            this.lbWorkingTime.Size = new System.Drawing.Size(43, 29);
            this.lbWorkingTime.TabIndex = 19;
            this.lbWorkingTime.Text = "---";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(16, 10);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1155, 631);
            this.webBrowser1.TabIndex = 28;
            // 
            // pnWebBrowser
            // 
            this.pnWebBrowser.BackColor = System.Drawing.Color.Khaki;
            this.pnWebBrowser.Controls.Add(this.pictureBox1);
            this.pnWebBrowser.Controls.Add(this.webBrowser1);
            this.pnWebBrowser.Location = new System.Drawing.Point(12, 22);
            this.pnWebBrowser.Name = "pnWebBrowser";
            this.pnWebBrowser.Size = new System.Drawing.Size(1219, 657);
            this.pnWebBrowser.TabIndex = 29;
            this.pnWebBrowser.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DB_FoodDelivery.Properties.Resources.ImgExitReg;
            this.pictureBox1.Location = new System.Drawing.Point(1177, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(286, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 36;
            // 
            // btnUruchye
            // 
            this.btnUruchye.BackColor = System.Drawing.Color.Transparent;
            this.btnUruchye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUruchye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUruchye.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUruchye.ForeColor = System.Drawing.Color.Black;
            this.btnUruchye.Location = new System.Drawing.Point(1009, 308);
            this.btnUruchye.Name = "btnUruchye";
            this.btnUruchye.Size = new System.Drawing.Size(203, 55);
            this.btnUruchye.TabIndex = 37;
            this.btnUruchye.Text = "Уручье";
            this.btnUruchye.UseVisualStyleBackColor = false;
            this.btnUruchye.Click += new System.EventHandler(this.btnUruchye_Click);
            // 
            // btnGrMeadow
            // 
            this.btnGrMeadow.BackColor = System.Drawing.Color.Transparent;
            this.btnGrMeadow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrMeadow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrMeadow.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGrMeadow.ForeColor = System.Drawing.Color.Black;
            this.btnGrMeadow.Location = new System.Drawing.Point(1009, 400);
            this.btnGrMeadow.Name = "btnGrMeadow";
            this.btnGrMeadow.Size = new System.Drawing.Size(203, 55);
            this.btnGrMeadow.TabIndex = 38;
            this.btnGrMeadow.Text = "Зелёный Луг";
            this.btnGrMeadow.UseVisualStyleBackColor = false;
            this.btnGrMeadow.Click += new System.EventHandler(this.btnGrMeadow_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.BackColor = System.Drawing.Color.Transparent;
            this.btnCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCenter.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCenter.ForeColor = System.Drawing.Color.Black;
            this.btnCenter.Location = new System.Drawing.Point(1009, 492);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(203, 55);
            this.btnCenter.TabIndex = 39;
            this.btnCenter.Text = "Центральный";
            this.btnCenter.UseVisualStyleBackColor = false;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnCall
            // 
            this.btnCall.BackColor = System.Drawing.Color.Transparent;
            this.btnCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCall.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCall.ForeColor = System.Drawing.Color.Black;
            this.btnCall.Location = new System.Drawing.Point(735, 581);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(203, 80);
            this.btnCall.TabIndex = 42;
            this.btnCall.Text = "Позвонить клиенту";
            this.btnCall.UseVisualStyleBackColor = false;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.BackColor = System.Drawing.Color.Transparent;
            this.lbEndTime.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEndTime.Location = new System.Drawing.Point(812, 150);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(43, 29);
            this.lbEndTime.TabIndex = 48;
            this.lbEndTime.Text = "---";
            // 
            // btnBackAutorisation
            // 
            this.btnBackAutorisation.AutoSize = true;
            this.btnBackAutorisation.BackColor = System.Drawing.Color.Transparent;
            this.btnBackAutorisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAutorisation.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackAutorisation.Location = new System.Drawing.Point(973, 615);
            this.btnBackAutorisation.Name = "btnBackAutorisation";
            this.btnBackAutorisation.Size = new System.Drawing.Size(211, 23);
            this.btnBackAutorisation.TabIndex = 51;
            this.btnBackAutorisation.Text = "Вернуться к авторизации";
            this.btnBackAutorisation.Click += new System.EventHandler(this.btnBackAutorisation_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1188, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 17;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(44, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "Логин:";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogin.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(149, 107);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(43, 29);
            this.lbLogin.TabIndex = 34;
            this.lbLogin.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(44, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Текущая смена:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(466, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 29);
            this.label9.TabIndex = 54;
            this.label9.Text = "На момент входа";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(466, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 29);
            this.label10.TabIndex = 55;
            this.label10.Text = "до конца смены осталось:";
            // 
            // pbExcel
            // 
            this.pbExcel.BackColor = System.Drawing.Color.Transparent;
            this.pbExcel.Image = ((System.Drawing.Image)(resources.GetObject("pbExcel.Image")));
            this.pbExcel.Location = new System.Drawing.Point(884, 452);
            this.pbExcel.Name = "pbExcel";
            this.pbExcel.Size = new System.Drawing.Size(32, 32);
            this.pbExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExcel.TabIndex = 56;
            this.pbExcel.TabStop = false;
            this.pbExcel.Click += new System.EventHandler(this.pbExcel_Click);
            // 
            // pbReloadDtv
            // 
            this.pbReloadDtv.BackColor = System.Drawing.Color.Khaki;
            this.pbReloadDtv.Image = ((System.Drawing.Image)(resources.GetObject("pbReloadDtv.Image")));
            this.pbReloadDtv.Location = new System.Drawing.Point(940, 404);
            this.pbReloadDtv.Name = "pbReloadDtv";
            this.pbReloadDtv.Size = new System.Drawing.Size(32, 32);
            this.pbReloadDtv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbReloadDtv.TabIndex = 57;
            this.pbReloadDtv.TabStop = false;
            this.pbReloadDtv.Click += new System.EventHandler(this.pbReloadDtv_Click);
            // 
            // pbScrenShot
            // 
            this.pbScrenShot.BackColor = System.Drawing.Color.Transparent;
            this.pbScrenShot.Image = ((System.Drawing.Image)(resources.GetObject("pbScrenShot.Image")));
            this.pbScrenShot.Location = new System.Drawing.Point(938, 452);
            this.pbScrenShot.Name = "pbScrenShot";
            this.pbScrenShot.Size = new System.Drawing.Size(32, 32);
            this.pbScrenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbScrenShot.TabIndex = 58;
            this.pbScrenShot.TabStop = false;
            this.pbScrenShot.Click += new System.EventHandler(this.pbScrenShot_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1054, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 60;
            this.label4.Text = "заказов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(1032, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 29);
            this.label7.TabIndex = 59;
            this.label7.Text = "Сортировка";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(1032, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 61;
            this.label8.Text = "по районам:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTotalPrice.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotalPrice.Location = new System.Drawing.Point(246, 446);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(34, 24);
            this.lbTotalPrice.TabIndex = 71;
            this.lbTotalPrice.Text = "---";
            this.lbTotalPrice.Visible = false;
            // 
            // lbTotalPriceText
            // 
            this.lbTotalPriceText.AutoSize = true;
            this.lbTotalPriceText.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbTotalPriceText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTotalPriceText.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTotalPriceText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTotalPriceText.Location = new System.Drawing.Point(36, 446);
            this.lbTotalPriceText.Name = "lbTotalPriceText";
            this.lbTotalPriceText.Size = new System.Drawing.Size(189, 24);
            this.lbTotalPriceText.TabIndex = 70;
            this.lbTotalPriceText.Text = "Стоимость заказа:";
            this.lbTotalPriceText.Visible = false;
            // 
            // cbCont
            // 
            this.cbCont.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCont.ForeColor = System.Drawing.Color.Gray;
            this.cbCont.FormattingEnabled = true;
            this.cbCont.Location = new System.Drawing.Point(37, 541);
            this.cbCont.Name = "cbCont";
            this.cbCont.Size = new System.Drawing.Size(203, 28);
            this.cbCont.TabIndex = 74;
            // 
            // btnContentOrder
            // 
            this.btnContentOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnContentOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContentOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContentOrder.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContentOrder.ForeColor = System.Drawing.Color.Black;
            this.btnContentOrder.Location = new System.Drawing.Point(37, 581);
            this.btnContentOrder.Name = "btnContentOrder";
            this.btnContentOrder.Size = new System.Drawing.Size(203, 80);
            this.btnContentOrder.TabIndex = 72;
            this.btnContentOrder.Text = "Просмотреть содержимое заказа";
            this.btnContentOrder.UseVisualStyleBackColor = false;
            this.btnContentOrder.Click += new System.EventHandler(this.btnContentOrder_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(33, 506);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 24);
            this.label11.TabIndex = 73;
            this.label11.Text = "Выберите № заказа:";
            // 
            // cbCall
            // 
            this.cbCall.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCall.ForeColor = System.Drawing.Color.Gray;
            this.cbCall.FormattingEnabled = true;
            this.cbCall.Location = new System.Drawing.Point(735, 541);
            this.cbCall.Name = "cbCall";
            this.cbCall.Size = new System.Drawing.Size(203, 28);
            this.cbCall.TabIndex = 77;
            this.cbCall.Click += new System.EventHandler(this.cbCall_Click);
            // 
            // cbMap
            // 
            this.cbMap.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbMap.ForeColor = System.Drawing.Color.Gray;
            this.cbMap.FormattingEnabled = true;
            this.cbMap.Location = new System.Drawing.Point(503, 541);
            this.cbMap.Name = "cbMap";
            this.cbMap.Size = new System.Drawing.Size(203, 28);
            this.cbMap.TabIndex = 76;
            this.cbMap.Click += new System.EventHandler(this.cbMap_Click);
            // 
            // cbDel
            // 
            this.cbDel.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDel.ForeColor = System.Drawing.Color.Gray;
            this.cbDel.FormattingEnabled = true;
            this.cbDel.Location = new System.Drawing.Point(269, 541);
            this.cbDel.Name = "cbDel";
            this.cbDel.Size = new System.Drawing.Size(203, 28);
            this.cbDel.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(265, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 78;
            this.label1.Text = "Выберите № заказа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(499, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 24);
            this.label5.TabIndex = 79;
            this.label5.Text = "Выберите № заказа:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(731, 506);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 24);
            this.label12.TabIndex = 80;
            this.label12.Text = "Выберите № заказа:";
            // 
            // MainFormCourier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1241, 679);
            this.Controls.Add(this.pnWebBrowser);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCall);
            this.Controls.Add(this.cbMap);
            this.Controls.Add(this.cbDel);
            this.Controls.Add(this.cbCont);
            this.Controls.Add(this.btnContentOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbTotalPriceText);
            this.Controls.Add(this.pbReloadDtv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMapView);
            this.Controls.Add(this.bntDelOrder);
            this.Controls.Add(this.lbWorkingTime);
            this.Controls.Add(this.dtvMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUruchye);
            this.Controls.Add(this.btnGrMeadow);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.pbExcel);
            this.Controls.Add(this.pbScrenShot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbEndTime);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btnBackAutorisation);
            this.Controls.Add(this.btnCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFormCourier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormCourier";
            this.Load += new System.EventHandler(this.MainFormCourier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvMain)).EndInit();
            this.pnWebBrowser.ResumeLayout(false);
            this.pnWebBrowser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadDtv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrenShot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridView dtvMain;
        private System.Windows.Forms.Button bntDelOrder;
        private System.Windows.Forms.Button btnMapView;
        private System.Windows.Forms.Label lbWorkingTime;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel pnWebBrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Идентификатор;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Адрес;
        private System.Windows.Forms.DataGridViewTextBoxColumn Телефон;
        private System.Windows.Forms.DataGridViewTextBoxColumn Почта;
        private System.Windows.Forms.DataGridViewTextBoxColumn Время;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUruchye;
        private System.Windows.Forms.Button btnGrMeadow;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label btnBackAutorisation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbExcel;
        private System.Windows.Forms.PictureBox pbReloadDtv;
        private System.Windows.Forms.PictureBox pbScrenShot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbTotalPriceText;
        private System.Windows.Forms.ComboBox cbCont;
        private System.Windows.Forms.Button btnContentOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCall;
        private System.Windows.Forms.ComboBox cbMap;
        private System.Windows.Forms.ComboBox cbDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
    }
}