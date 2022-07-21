namespace DB_FoodDelivery
{
    partial class MainFormRestorator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormRestorator));
            this.foodDeliveryDataSet = new DB_FoodDelivery.FoodDeliveryDataSet();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishTableAdapter = new DB_FoodDelivery.FoodDeliveryDataSetTableAdapters.DishTableAdapter();
            this.dtvMain = new System.Windows.Forms.DataGridView();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Опимание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Вес = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Статус = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRestName = new System.Windows.Forms.Label();
            this.lbRestInfo = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btnChangeDish = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemoveDish = new System.Windows.Forms.Button();
            this.bntAddDish = new System.Windows.Forms.Button();
            this.btnBackAutorisation = new System.Windows.Forms.Label();
            this.pctbRestImg = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.foodDeliveryDataSet1 = new DB_FoodDelivery.FoodDeliveryDataSet();
            this.pbExcel = new System.Windows.Forms.PictureBox();
            this.pbScrenShot = new System.Windows.Forms.PictureBox();
            this.pbReloadDtv = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbChangeInfo = new System.Windows.Forms.PictureBox();
            this.btnChangeDesc = new System.Windows.Forms.Button();
            this.tbChangeDesc = new System.Windows.Forms.TextBox();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.pnWorkload = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pgWorkload = new System.Windows.Forms.ProgressBar();
            this.pnOrders = new System.Windows.Forms.Panel();
            this.cbOrders = new System.Windows.Forms.ComboBox();
            this.btnContentOrder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pnDishes = new System.Windows.Forms.Panel();
            this.btnCurrentOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodDeliveryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRestImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDeliveryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrenShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadDtv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeInfo)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.pnWorkload.SuspendLayout();
            this.pnOrders.SuspendLayout();
            this.pnDishes.SuspendLayout();
            this.SuspendLayout();
            // 
            // foodDeliveryDataSet
            // 
            this.foodDeliveryDataSet.DataSetName = "FoodDeliveryDataSet";
            this.foodDeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataMember = "Dish";
            this.dishBindingSource.DataSource = this.foodDeliveryDataSet;
            // 
            // dishTableAdapter
            // 
            this.dishTableAdapter.ClearBeforeFill = true;
            // 
            // dtvMain
            // 
            this.dtvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Название,
            this.Опимание,
            this.Цена,
            this.Вес,
            this.Статус});
            this.dtvMain.Location = new System.Drawing.Point(48, 217);
            this.dtvMain.Name = "dtvMain";
            this.dtvMain.RowHeadersWidth = 51;
            this.dtvMain.RowTemplate.Height = 24;
            this.dtvMain.Size = new System.Drawing.Size(699, 277);
            this.dtvMain.TabIndex = 6;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.MinimumWidth = 6;
            this.Название.Name = "Название";
            this.Название.Width = 125;
            // 
            // Опимание
            // 
            this.Опимание.HeaderText = "Описание";
            this.Опимание.MinimumWidth = 6;
            this.Опимание.Name = "Опимание";
            this.Опимание.Width = 125;
            // 
            // Цена
            // 
            this.Цена.HeaderText = "Цена";
            this.Цена.MinimumWidth = 6;
            this.Цена.Name = "Цена";
            this.Цена.Width = 125;
            // 
            // Вес
            // 
            this.Вес.HeaderText = "Вес";
            this.Вес.MinimumWidth = 6;
            this.Вес.Name = "Вес";
            this.Вес.Width = 125;
            // 
            // Статус
            // 
            this.Статус.HeaderText = "Статус";
            this.Статус.MinimumWidth = 6;
            this.Статус.Name = "Статус";
            this.Статус.Width = 125;
            // 
            // lbRestName
            // 
            this.lbRestName.AutoSize = true;
            this.lbRestName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbRestName.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRestName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbRestName.Location = new System.Drawing.Point(42, 120);
            this.lbRestName.Name = "lbRestName";
            this.lbRestName.Size = new System.Drawing.Size(359, 42);
            this.lbRestName.TabIndex = 7;
            this.lbRestName.Text = "Название ресторана";
            // 
            // lbRestInfo
            // 
            this.lbRestInfo.AutoSize = true;
            this.lbRestInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbRestInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRestInfo.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRestInfo.Location = new System.Drawing.Point(43, 174);
            this.lbRestInfo.Name = "lbRestInfo";
            this.lbRestInfo.Size = new System.Drawing.Size(250, 29);
            this.lbRestInfo.TabIndex = 10;
            this.lbRestInfo.Text = "Описание ресторана";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogin.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(151, 49);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(43, 29);
            this.lbLogin.TabIndex = 11;
            this.lbLogin.Text = "---";
            // 
            // btnChangeDish
            // 
            this.btnChangeDish.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeDish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDish.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeDish.ForeColor = System.Drawing.Color.Black;
            this.btnChangeDish.Location = new System.Drawing.Point(15, 62);
            this.btnChangeDish.Name = "btnChangeDish";
            this.btnChangeDish.Size = new System.Drawing.Size(203, 42);
            this.btnChangeDish.TabIndex = 18;
            this.btnChangeDish.Text = "Изменить блюдо";
            this.btnChangeDish.UseVisualStyleBackColor = false;
            this.btnChangeDish.Click += new System.EventHandler(this.btnChangeDish_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.ForeColor = System.Drawing.Color.Gray;
            this.tbSearch.Location = new System.Drawing.Point(110, 11);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(164, 37);
            this.tbSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(10, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 37);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemoveDish
            // 
            this.btnRemoveDish.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveDish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDish.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveDish.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveDish.Location = new System.Drawing.Point(15, 112);
            this.btnRemoveDish.Name = "btnRemoveDish";
            this.btnRemoveDish.Size = new System.Drawing.Size(203, 42);
            this.btnRemoveDish.TabIndex = 19;
            this.btnRemoveDish.Text = "Удалить блюдо";
            this.btnRemoveDish.UseVisualStyleBackColor = false;
            this.btnRemoveDish.Click += new System.EventHandler(this.btnRemoveDish_Click);
            // 
            // bntAddDish
            // 
            this.bntAddDish.BackColor = System.Drawing.Color.Transparent;
            this.bntAddDish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAddDish.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bntAddDish.ForeColor = System.Drawing.Color.Black;
            this.bntAddDish.Location = new System.Drawing.Point(15, 14);
            this.bntAddDish.Name = "bntAddDish";
            this.bntAddDish.Size = new System.Drawing.Size(203, 42);
            this.bntAddDish.TabIndex = 23;
            this.bntAddDish.Text = "Добавить блюдо";
            this.bntAddDish.UseVisualStyleBackColor = false;
            this.bntAddDish.Click += new System.EventHandler(this.bntAddDish_Click);
            // 
            // btnBackAutorisation
            // 
            this.btnBackAutorisation.AutoSize = true;
            this.btnBackAutorisation.BackColor = System.Drawing.Color.Transparent;
            this.btnBackAutorisation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackAutorisation.Font = new System.Drawing.Font("Roboto Cn", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackAutorisation.Location = new System.Drawing.Point(966, 615);
            this.btnBackAutorisation.Name = "btnBackAutorisation";
            this.btnBackAutorisation.Size = new System.Drawing.Size(211, 23);
            this.btnBackAutorisation.TabIndex = 24;
            this.btnBackAutorisation.Text = "Вернуться к авторизации";
            this.btnBackAutorisation.Click += new System.EventHandler(this.btnBackAutorisation_Click);
            // 
            // pctbRestImg
            // 
            this.pctbRestImg.Location = new System.Drawing.Point(797, 231);
            this.pctbRestImg.Name = "pctbRestImg";
            this.pctbRestImg.Size = new System.Drawing.Size(156, 72);
            this.pctbRestImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbRestImg.TabIndex = 13;
            this.pctbRestImg.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::DB_FoodDelivery.Properties.Resources.ImgExitReg;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1192, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // foodDeliveryDataSet1
            // 
            this.foodDeliveryDataSet1.DataSetName = "FoodDeliveryDataSet";
            this.foodDeliveryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbExcel
            // 
            this.pbExcel.BackColor = System.Drawing.Color.Transparent;
            this.pbExcel.Image = ((System.Drawing.Image)(resources.GetObject("pbExcel.Image")));
            this.pbExcel.Location = new System.Drawing.Point(775, 405);
            this.pbExcel.Name = "pbExcel";
            this.pbExcel.Size = new System.Drawing.Size(32, 32);
            this.pbExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExcel.TabIndex = 59;
            this.pbExcel.TabStop = false;
            this.pbExcel.Visible = false;
            this.pbExcel.Click += new System.EventHandler(this.pbExcel_Click);
            // 
            // pbScrenShot
            // 
            this.pbScrenShot.BackColor = System.Drawing.Color.Transparent;
            this.pbScrenShot.Image = ((System.Drawing.Image)(resources.GetObject("pbScrenShot.Image")));
            this.pbScrenShot.Location = new System.Drawing.Point(775, 454);
            this.pbScrenShot.Name = "pbScrenShot";
            this.pbScrenShot.Size = new System.Drawing.Size(32, 32);
            this.pbScrenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbScrenShot.TabIndex = 60;
            this.pbScrenShot.TabStop = false;
            this.pbScrenShot.Click += new System.EventHandler(this.pbScrenShot_Click);
            // 
            // pbReloadDtv
            // 
            this.pbReloadDtv.BackColor = System.Drawing.Color.Transparent;
            this.pbReloadDtv.Image = ((System.Drawing.Image)(resources.GetObject("pbReloadDtv.Image")));
            this.pbReloadDtv.Location = new System.Drawing.Point(705, 454);
            this.pbReloadDtv.Name = "pbReloadDtv";
            this.pbReloadDtv.Size = new System.Drawing.Size(32, 32);
            this.pbReloadDtv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbReloadDtv.TabIndex = 61;
            this.pbReloadDtv.TabStop = false;
            this.pbReloadDtv.Click += new System.EventHandler(this.pbReloadDtv_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(43, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "Логин:";
            // 
            // pbChangeInfo
            // 
            this.pbChangeInfo.BackColor = System.Drawing.Color.Transparent;
            this.pbChangeInfo.Image = ((System.Drawing.Image)(resources.GetObject("pbChangeInfo.Image")));
            this.pbChangeInfo.Location = new System.Drawing.Point(1120, 296);
            this.pbChangeInfo.Name = "pbChangeInfo";
            this.pbChangeInfo.Size = new System.Drawing.Size(32, 32);
            this.pbChangeInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbChangeInfo.TabIndex = 64;
            this.pbChangeInfo.TabStop = false;
            this.pbChangeInfo.Click += new System.EventHandler(this.pbChangeInfo_Click);
            // 
            // btnChangeDesc
            // 
            this.btnChangeDesc.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeDesc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeDesc.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangeDesc.ForeColor = System.Drawing.Color.Black;
            this.btnChangeDesc.Location = new System.Drawing.Point(1028, 345);
            this.btnChangeDesc.Name = "btnChangeDesc";
            this.btnChangeDesc.Size = new System.Drawing.Size(124, 37);
            this.btnChangeDesc.TabIndex = 66;
            this.btnChangeDesc.Text = "Изменить";
            this.btnChangeDesc.UseVisualStyleBackColor = false;
            this.btnChangeDesc.Visible = false;
            this.btnChangeDesc.Click += new System.EventHandler(this.btnChangeDesc_Click);
            // 
            // tbChangeDesc
            // 
            this.tbChangeDesc.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbChangeDesc.ForeColor = System.Drawing.Color.Gray;
            this.tbChangeDesc.Location = new System.Drawing.Point(797, 345);
            this.tbChangeDesc.Multiline = true;
            this.tbChangeDesc.Name = "tbChangeDesc";
            this.tbChangeDesc.Size = new System.Drawing.Size(225, 37);
            this.tbChangeDesc.TabIndex = 65;
            this.tbChangeDesc.Visible = false;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnSearch.Controls.Add(this.btnSearch);
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Location = new System.Drawing.Point(39, 510);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(290, 54);
            this.pnSearch.TabIndex = 85;
            // 
            // pnWorkload
            // 
            this.pnWorkload.BackColor = System.Drawing.Color.Transparent;
            this.pnWorkload.Controls.Add(this.label4);
            this.pnWorkload.Controls.Add(this.label3);
            this.pnWorkload.Controls.Add(this.label2);
            this.pnWorkload.Controls.Add(this.label1);
            this.pnWorkload.Controls.Add(this.pgWorkload);
            this.pnWorkload.Location = new System.Drawing.Point(39, 534);
            this.pnWorkload.Name = "pnWorkload";
            this.pnWorkload.Size = new System.Drawing.Size(426, 99);
            this.pnWorkload.TabIndex = 84;
            this.pnWorkload.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Brown;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(312, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 75;
            this.label4.Text = "Высокая";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chocolate;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "Средняя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Низкая";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 72;
            this.label1.Text = "Загруженность ресторана";
            // 
            // pgWorkload
            // 
            this.pgWorkload.Location = new System.Drawing.Point(10, 36);
            this.pgWorkload.Name = "pgWorkload";
            this.pgWorkload.Size = new System.Drawing.Size(404, 26);
            this.pgWorkload.TabIndex = 71;
            // 
            // pnOrders
            // 
            this.pnOrders.BackColor = System.Drawing.Color.Transparent;
            this.pnOrders.Controls.Add(this.cbOrders);
            this.pnOrders.Controls.Add(this.btnContentOrder);
            this.pnOrders.Controls.Add(this.label11);
            this.pnOrders.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnOrders.ForeColor = System.Drawing.Color.Gray;
            this.pnOrders.Location = new System.Drawing.Point(508, 496);
            this.pnOrders.Name = "pnOrders";
            this.pnOrders.Size = new System.Drawing.Size(257, 178);
            this.pnOrders.TabIndex = 86;
            this.pnOrders.Visible = false;
            // 
            // cbOrders
            // 
            this.cbOrders.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOrders.ForeColor = System.Drawing.Color.Gray;
            this.cbOrders.FormattingEnabled = true;
            this.cbOrders.Location = new System.Drawing.Point(29, 48);
            this.cbOrders.Name = "cbOrders";
            this.cbOrders.Size = new System.Drawing.Size(215, 28);
            this.cbOrders.TabIndex = 78;
            // 
            // btnContentOrder
            // 
            this.btnContentOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnContentOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContentOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContentOrder.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContentOrder.ForeColor = System.Drawing.Color.Black;
            this.btnContentOrder.Location = new System.Drawing.Point(29, 84);
            this.btnContentOrder.Name = "btnContentOrder";
            this.btnContentOrder.Size = new System.Drawing.Size(215, 79);
            this.btnContentOrder.TabIndex = 76;
            this.btnContentOrder.Text = "Отметить передачу заказа курьеру";
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
            this.label11.Location = new System.Drawing.Point(25, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 24);
            this.label11.TabIndex = 77;
            this.label11.Text = "Выберите № заказа:";
            // 
            // pnDishes
            // 
            this.pnDishes.BackColor = System.Drawing.Color.Transparent;
            this.pnDishes.Controls.Add(this.bntAddDish);
            this.pnDishes.Controls.Add(this.btnChangeDish);
            this.pnDishes.Controls.Add(this.btnRemoveDish);
            this.pnDishes.Location = new System.Drawing.Point(529, 500);
            this.pnDishes.Name = "pnDishes";
            this.pnDishes.Size = new System.Drawing.Size(236, 163);
            this.pnDishes.TabIndex = 87;
            // 
            // btnCurrentOrders
            // 
            this.btnCurrentOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnCurrentOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentOrders.Font = new System.Drawing.Font("Roboto Lt", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCurrentOrders.ForeColor = System.Drawing.Color.Black;
            this.btnCurrentOrders.Location = new System.Drawing.Point(822, 450);
            this.btnCurrentOrders.Name = "btnCurrentOrders";
            this.btnCurrentOrders.Size = new System.Drawing.Size(330, 44);
            this.btnCurrentOrders.TabIndex = 88;
            this.btnCurrentOrders.Text = "Текущие заказы";
            this.btnCurrentOrders.UseVisualStyleBackColor = false;
            this.btnCurrentOrders.Click += new System.EventHandler(this.btnCurrentOrders_Click);
            // 
            // MainFormRestorator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1240, 686);
            this.Controls.Add(this.btnCurrentOrders);
            this.Controls.Add(this.pnDishes);
            this.Controls.Add(this.pnOrders);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.pnWorkload);
            this.Controls.Add(this.btnChangeDesc);
            this.Controls.Add(this.tbChangeDesc);
            this.Controls.Add(this.pbChangeInfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbReloadDtv);
            this.Controls.Add(this.pbExcel);
            this.Controls.Add(this.pbScrenShot);
            this.Controls.Add(this.btnBackAutorisation);
            this.Controls.Add(this.pctbRestImg);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.lbRestInfo);
            this.Controls.Add(this.lbRestName);
            this.Controls.Add(this.dtvMain);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFormRestorator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainFormRestorator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodDeliveryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRestImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDeliveryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrenShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReloadDtv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeInfo)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnWorkload.ResumeLayout(false);
            this.pnWorkload.PerformLayout();
            this.pnOrders.ResumeLayout(false);
            this.pnOrders.PerformLayout();
            this.pnDishes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private FoodDeliveryDataSet foodDeliveryDataSet;
        private System.Windows.Forms.BindingSource dishBindingSource;
        private FoodDeliveryDataSetTableAdapters.DishTableAdapter dishTableAdapter;
        public System.Windows.Forms.DataGridView dtvMain;
        private System.Windows.Forms.Label lbRestName;
        private System.Windows.Forms.Label lbRestInfo;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.PictureBox pctbRestImg;
        private System.Windows.Forms.Button btnChangeDish;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemoveDish;
        private System.Windows.Forms.Button bntAddDish;
        private System.Windows.Forms.Label btnBackAutorisation;
        private FoodDeliveryDataSet foodDeliveryDataSet1;
        private System.Windows.Forms.PictureBox pbExcel;
        private System.Windows.Forms.PictureBox pbScrenShot;
        private System.Windows.Forms.PictureBox pbReloadDtv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbChangeInfo;
        private System.Windows.Forms.Button btnChangeDesc;
        private System.Windows.Forms.TextBox tbChangeDesc;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.Panel pnWorkload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgWorkload;
        private System.Windows.Forms.Panel pnOrders;
        private System.Windows.Forms.ComboBox cbOrders;
        private System.Windows.Forms.Button btnContentOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnDishes;
        private System.Windows.Forms.Button btnCurrentOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Опимание;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Вес;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статус;
    }
}