using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DB_FoodDelivery
{
    public partial class MainFormAdmin : Form
    {
        FoodDeliveryEntities context = new FoodDeliveryEntities();
        Staff authorizedStaff = new Staff();
        Notification notification_form = new Notification();

        public MailAddress Sender = new MailAddress("rm_volkovich@mail.ru", "FoodDelivery.com");
        string currTableName = "";
        int ColumsCount = 0;

        public MainFormAdmin()
        {
            InitializeComponent();
        }

        public Staff AuthorizedStaff
        {
            set
            {
                authorizedStaff = value;
            }
            get
            {
                return authorizedStaff;
            }
        }

        public void loadDtv(string tableName)
        {
            dtvMain.Rows.Clear();
            pbReloadDtv.Visible = true;
            dtvMain.Visible = true;

            if (tableName == "rest")
            {
                dtvMain.Columns[0].HeaderText = "ID";
                dtvMain.Columns[1].HeaderText = "Название";
                dtvMain.Columns[2].HeaderText = "Короткое описание";
                dtvMain.Columns[3].HeaderText = "Логотип";
                dtvMain.Columns[4].HeaderText = "Длинное описание";
                dtvMain.Columns[5].HeaderText = "Время работы";
                dtvMain.Columns[6].HeaderText = "Адрес";
                dtvMain.Columns[7].HeaderText = "Популярное";
                dtvMain.Columns[8].HeaderText = "Категория";
                dtvMain.Columns[7].Visible = true;
                dtvMain.Columns[8].Visible = true;

                var restaurants = context.Restaurant.ToList();

                foreach (var item in restaurants)
                {
                    dtvMain.Rows.Add(item.id, item.name, item.shortDesc, item.img, item.longDesc, item.workingTime, item.address, item.isFavourite, item.FoodCategoryid);
                }
            }
            else if (tableName == "dish")
            {
                dtvMain.Columns[0].HeaderText = "ID";
                dtvMain.Columns[1].HeaderText = "Название";
                dtvMain.Columns[2].HeaderText = "Вес";
                dtvMain.Columns[3].HeaderText = "Короткое описание";
                dtvMain.Columns[4].HeaderText = "Изображение";
                dtvMain.Columns[5].HeaderText = "Цена";
                dtvMain.Columns[6].HeaderText = "Ресторан владелец";
                dtvMain.Columns[7].Visible = false;
                dtvMain.Columns[8].Visible = false;

                var dishes = context.Dish.ToList();

                foreach (var item in dishes)
                {
                    dtvMain.Rows.Add(item.id, item.name, item.weight, item.shortDesc, item.img, item.price, item.restaurantID);
                }
            }
            else if (tableName == "order")
            {
                dtvMain.Columns[0].HeaderText = "ID";
                dtvMain.Columns[1].HeaderText = "Имя заказчика";
                dtvMain.Columns[2].HeaderText = "Фамилия заказчика";
                dtvMain.Columns[3].HeaderText = "Адрес заказчика";
                dtvMain.Columns[4].HeaderText = "Телефон заказчика";
                dtvMain.Columns[5].HeaderText = "Почта заказчика";
                dtvMain.Columns[6].HeaderText = "Время заказа";
                dtvMain.Columns[7].HeaderText = "Время доставки";
                dtvMain.Columns[8].HeaderText = "Способ доставки";
                dtvMain.Columns[7].Visible = true;
                dtvMain.Columns[8].Visible = true;


                var orders = context.Order.ToList();

                foreach (var item in orders)
                {
                    dtvMain.Rows.Add(item.id, item.name, item.surname, item.adress, item.phone, item.email, item.orderTime, item.deliveryTime, item.deliveryType);
                }
            }
            else if (tableName == "staff")
            {
                cbNameStaff.Items.Clear();
                foreach (var item in context.Staff.ToList())
                {
                    if (item.login != "admin")
                    {
                        cbNameStaff.Items.Add(item.login);
                    }
                }

                // dtvMain.Columns[0].HeaderText = "ID";
                dtvMain.Columns[0].HeaderText = "Имя работника";
                dtvMain.Columns[1].HeaderText = "Фамилия работника";
                dtvMain.Columns[2].HeaderText = "Логин работника";
                dtvMain.Columns[3].HeaderText = "Пароль работника";
                dtvMain.Columns[4].HeaderText = "Почта работника";
                dtvMain.Columns[5].HeaderText = "Должность работника";
                dtvMain.Columns[6].HeaderText = "Персональная информация";
                dtvMain.Columns[7].Visible = false;
                dtvMain.Columns[8].Visible = false;

                var staffs = context.Staff.ToList();

                foreach (var item in staffs)
                {
                    dtvMain.Rows.Add(item.name, item.surname, item.login, item.password, item.email, item.position, item.persInfo);
                }
            }
        }
        private void btnRest_Click(object sender, EventArgs e)
        {
            ColumsCount = 9;
            loadDtv("rest");
            currTableName = "rest";
            pnMailStaff.Visible = false;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnDishes_Click(object sender, EventArgs e)
        {
            ColumsCount = 7;
            loadDtv("dish");
            currTableName = "dish";
            pnMailStaff.Visible = false;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnOders_Click(object sender, EventArgs e)
        {
            ColumsCount = 9;
            loadDtv("order");
            currTableName = "order";
            pnMailStaff.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ColumsCount = 7;
            loadDtv("staff");
            currTableName = "staff";
            pnMailStaff.Visible = true;
            btnAdd.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntMailStaff_Click(object sender, EventArgs e)
        {
            if ((tbTextMailStaff.Text != "") && (cbNameStaff.Text != ""))
            {
                Staff currStaff = context.Staff.Where(p => p.login == cbNameStaff.Text).FirstOrDefault();
                string recipient = currStaff.email;
                string name = currStaff.name;
                ToSendMail(recipient, name, tbTextMailStaff.Text);

                notification_form.msgNotification = "Письмо успешно отправлено!";
                tbTextMailStaff.Text = "";
                notification_form.lbNotifLeft = 30;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
            else
            {
                notification_form.msgNotification = "Заполните поле!";
                notification_form.lbNotifLeft = 90;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        public void ToSendMail(string recipient, string name, string text)
        {

            MailAddress Recipient = new MailAddress(recipient);
            MailMessage msg = new MailMessage(Sender, Recipient);

            msg.Subject = "Сообщение от администрации!";
            msg.Body = $"<h2>Здравствуйте {name} </h2>" +
                       $"<h3> Сообщение: {text} </h4>";

            msg.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.mail.ru", 587);
            smtpClient.Credentials = new NetworkCredential("rm_volkovich@mail.ru", "Prekol1827");
            smtpClient.EnableSsl = true;
            smtpClient.Send(msg);
        }

        //Boolean IsUserExist()
        //{
        //    using (var db = new FoodDeliveryEntities())
        //    {
        //        int staffID = Convert.ToInt32(tbIdStaff.Text);
        //        Staff check = db.Staff.Where(p => p.Id == staffID).Where(k => k.Id != authorizedStaff.Id).FirstOrDefault();
        //        if (check != null)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            notification_form.msgNotification = "Такого сотрудника нет!";
        //            notification_form.lbNotifLeft = 20;
        //            notification_form.lbNotifTop = 78;
        //            notification_form.Show();
        //            return false;
        //        }
        //    }
        //}

        private void btnScShot_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(dtvMain.Width, dtvMain.Height);
            dtvMain.DrawToBitmap(bitmap, new Rectangle(new Point(), dtvMain.Size));
            bitmap.Save(@"C:\Users\User\source\repos\DB_FoodDelivery\DB_FoodDelivery\bin\Debug\screenshotsAdmin\printscreen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            notification_form.msgNotification = "Скрин-шот был успешно сохранён!";
            notification_form.lbNotifLeft = 55;
            notification_form.lbNotifTop = 78;
            notification_form.Show();
        }

        public void ExcellExport(DataGridView dtv)
        {

            Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel._Worksheet worksheet = null;
            app.Visible = true;

            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Name = "Экспорт таблицы";

            for (int i = 1; i < ColumsCount + 1; i++)
            {
                worksheet.Cells[1, i] = dtv.Columns[i - 1].HeaderText;
                worksheet.Cells[1, i].Font.Color = ColorTranslator.ToOle(Color.White);
                worksheet.Cells[1, i].Interior.Color = ColorTranslator.ToOle(Color.Red);
            }

            for (int i = 0; i < dtv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < ColumsCount; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dtv.Rows[i].Cells[j].Value.ToString();
                    worksheet.Cells[i + 2, j + 1].Font.Color = ColorTranslator.ToOle(Color.Black);
                    worksheet.Cells[i + 2, j + 1].Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                }
            }
            app.Quit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin_form = new AddAdmin();

            if (currTableName == "rest")
            {
                addAdmin_form.Show();
                addAdmin_form.cbRest.Visible = false;
                addAdmin_form.tb5.Visible = true;
                addAdmin_form.lb6.Visible = false;
                addAdmin_form.tb6.Visible = false;
                addAdmin_form.lb7.Visible = true;
                addAdmin_form.comboB1.Visible = true;
                addAdmin_form.cb1.Visible = true;
                addAdmin_form.btnSelImg.Visible = true;
                addAdmin_form.comboB1.Items.Clear();
                addAdmin_form.lb1.Text = "Название";
                addAdmin_form.lb2.Text = "Короткое описание";
                addAdmin_form.lb3.Text = "Длинное описание";
                addAdmin_form.lb4.Text = "Время работы";
                addAdmin_form.lb5.Text = "Адрес";
                addAdmin_form.lb7.Text = "Категория";
                addAdmin_form.comboB1.Items.Add("Суши");
                addAdmin_form.comboB1.Items.Add("Пицца");
                addAdmin_form.comboB1.Items.Add("Бургеры");
                addAdmin_form.comboB1.Items.Add("Другое");
                addAdmin_form.cb1.Text = "Популярное";
            }
            else if (currTableName == "dish")
            {
                foreach (var item in context.Restaurant.ToList())
                {
                    addAdmin_form.cbRest.Items.Add(item.name);
                }
                addAdmin_form.cbRest.Visible = true;
                addAdmin_form.tb5.Visible = false;
                addAdmin_form.lb6.Visible = false;
                addAdmin_form.tb6.Visible = false;
                addAdmin_form.lb7.Visible = false;
                addAdmin_form.comboB1.Visible = false;
                addAdmin_form.cb1.Visible = false;
                addAdmin_form.btnSelImg.Visible = true;
                addAdmin_form.Show();
                addAdmin_form.lb1.Text = "Название";
                addAdmin_form.lb2.Text = "Вес";
                addAdmin_form.lb3.Text = "Короткое описание";
                addAdmin_form.lb4.Text = "Цена";
                addAdmin_form.lb5.Text = "Ресторан";
            }
            else if (currTableName == "staff")
            {
                addAdmin_form.cbRest.Visible = false;
                addAdmin_form.tb5.Visible = true;
                addAdmin_form.Show();
                addAdmin_form.lb6.Visible = true;
                addAdmin_form.tb6.Visible = true;
                addAdmin_form.lb7.Visible = true;
                addAdmin_form.comboB1.Visible = true;
                addAdmin_form.cb1.Visible = false;
                addAdmin_form.comboB1.Items.Clear();
                addAdmin_form.lb1.Text = "Имя сотрудника";
                addAdmin_form.lb2.Text = "Фамилия сотрудника";
                addAdmin_form.lb3.Text = "Логин сотрудника";
                addAdmin_form.lb4.Text = "Пароль сотрудника";
                addAdmin_form.lb5.Text = "Почта сотрудника";
                addAdmin_form.lb6.Text = "Персональная информация";
                addAdmin_form.lb7.Text = "Должность";
                addAdmin_form.comboB1.Items.Add("Ресторатор");
                addAdmin_form.comboB1.Items.Add("Курьер");
                addAdmin_form.btnSelImg.Visible = false;
            }
            else
            {
                notification_form.msgNotification = "Выберите таблицу!";
                notification_form.lbNotifLeft = 77;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAdmin deleteAdmin_form = new DeleteAdmin();

            if (currTableName == "rest")
            {
                foreach (var item in context.Restaurant.ToList())
                {
                    deleteAdmin_form.cbDelete.Items.Add(item.name);
                }
                deleteAdmin_form.lbText.Text = "Выберите название \n ресторана:";
                deleteAdmin_form.Show();
            }
            else if (currTableName == "dish")
            {
                foreach (var item in context.Dish.ToList())
                {
                    deleteAdmin_form.cbDelete.Items.Add(item.name);
                }
                deleteAdmin_form.lbText.Text = "Выберите название \n блюда:";
                deleteAdmin_form.Show();
            }
            else if (currTableName == "staff")
            {
                foreach (var item in context.Staff.ToList())
                {
                    if (item.login != "админ")
                    {
                        deleteAdmin_form.cbDelete.Items.Add(item.login);
                    }
                }
                deleteAdmin_form.lbText.Text = "Выберите логин \n сотрудника:";
                deleteAdmin_form.Show();
            }
            else
            {
                notification_form.msgNotification = "Выберите таблицу!";
                notification_form.lbNotifLeft = 77;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        private void pbExcel_Click(object sender, EventArgs e)
        {
            ExcellExport(dtvMain);
        }

        private void pbScrenShot_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(dtvMain.Width, dtvMain.Height);
            dtvMain.DrawToBitmap(bitmap, new Rectangle(new Point(), dtvMain.Size));
            bitmap.Save(@"C:\Users\User\source\repos\DB_FoodDelivery\DB_FoodDelivery\bin\Debug\screenshotsAdmin\printscreen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            notification_form.msgNotification = "Скрин-шот сохранён!";
            notification_form.lbNotifLeft = 72;
            notification_form.lbNotifTop = 78;
            notification_form.Show();
        }

        private void pbReloadDtv_Click(object sender, EventArgs e)
        {
            loadDtv(currTableName);
        }

        private void btnBackAutorisation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorisation autorisation_form = new Autorisation();
            autorisation_form.Show();
        }

        private void btnSQL1_Click(object sender, EventArgs e)
        {
            lbSQL1.Text = "";
            using (var db = new FoodDeliveryEntities())
            {
                double avgPrice = db.Dish
                         .Average(p => p.price);
                lbSQL1.Text = Convert.ToString(Math.Round(avgPrice, 2));

                if (lbSQL1.Text == "")
                {
                    MessageBox.Show("No values ​​found!");
                }
            }
        }

        private void btnSQL2_Click(object sender, EventArgs e)
        {
            lbSQL2.Text = "";
            using (var db = new FoodDeliveryEntities())
            {
                double? countOrders = db.Order
                         .Count(p => p.deliveryType == "курьером");
                lbSQL2.Text = Convert.ToString(countOrders);

                if (lbSQL2.Text == "")
                {
                    MessageBox.Show("No values ​​found!");
                }
            }
        }

        private void btnSQL3_Click(object sender, EventArgs e)
        {
            lbSQL3.Text = "";
            using (var db = new FoodDeliveryEntities())
            {
                double? countStaff = db.Staff
                         .Count();
                lbSQL3.Text = Convert.ToString(countStaff);

                if (lbSQL3.Text == "")
                {
                    MessageBox.Show("No values ​​found!");
                }
            }
        }

        private void btnSQL4_Click(object sender, EventArgs e)
        {
            lbSQL4.Text = "";
            using (var db = new FoodDeliveryEntities())
            {
                double? countRest = db.Restaurant
                         .Count();
                lbSQL4.Text = Convert.ToString(countRest);

                if (lbSQL4.Text == "")
                {
                    MessageBox.Show("No values ​​found!");
                }
            }
        }

        private void btnSQL5_Click(object sender, EventArgs e)
        {
            lbSQL5.Text = "";
            using (var db = new FoodDeliveryEntities())
            {
                double? countDish = db.Dish
                         .Count();
                lbSQL5.Text = Convert.ToString(countDish);

                if (lbSQL5.Text == "")
                {
                    MessageBox.Show("No values ​​found!");
                }
            }
        }

        private void btnSQL6_Click(object sender, EventArgs e)
        {
            lbSQL6.Text = "";
            using (var db = new FoodDeliveryEntities())
            {
                double? countOrders = db.Order
                         .Count(p => p.deliveryType == "самовывоз");
                lbSQL6.Text = Convert.ToString(countOrders);

                if (lbSQL6.Text == "")
                {
                    MessageBox.Show("No values ​​found!");
                }
            }
        }


        //private void MainFormAdmin_Load(object sender, EventArgs e)
        //{
        //    this.staffTableAdapter.Fill(this.foodDeliveryDataSet.Staff);
        //}
    }
}
