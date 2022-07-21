using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace DB_FoodDelivery
{
    public partial class MainFormCourier : Form
    {
        Dictionary<string, string> words = new Dictionary<string, string>();
        FoodDeliveryEntities context = new FoodDeliveryEntities();
        Staff authorizedStaff = new Staff();
        Notification notification_form = new Notification();

        string[] stretsUruchye =
        {
            "Уручская",
            "Гинтовта",
            "Городецкая",
            "Ложинская",
            "Никифирова",
            "Острошицкая",
            "Руссиянова",
            "Стариновская"
        };

        string[] stretsGrMeadow =
        {
            "Восточная",
            "Гамарника",
            "Калиновского",
            "Карбышева",
            "Кольцова",
            "Крамского",
            "Логойский тракт",
            "Мирошниченко",
            "Седых",
            "Широкая"
        };

        string[] stretsCenter =
       {
            "Витебская",
            "Гагарина",
            "Гастелло",
            "Гвардейская",
            "Замковая",
            "Немига",
            "Красная",
            "Кальварийская",
            "Энгельса",
            "Янки Купалы",
            "Гагарина"
        };

        int startTime = 0;
        int finTime = 0;

        public MainFormCourier()
        {
            InitializeComponent();
            words.Add("а", "a");
            words.Add("б", "b");
            words.Add("в", "v");
            words.Add("г", "g");
            words.Add("д", "d");
            words.Add("е", "e");
            words.Add("ё", "yo");
            words.Add("ж", "zh");
            words.Add("з", "z");
            words.Add("и", "i");
            words.Add("й", "j");
            words.Add("к", "k");
            words.Add("л", "l");
            words.Add("м", "m");
            words.Add("н", "n");
            words.Add("о", "o");
            words.Add("п", "p");
            words.Add("р", "r");
            words.Add("с", "s");
            words.Add("т", "t");
            words.Add("у", "u");
            words.Add("ф", "f");
            words.Add("х", "h");
            words.Add("ц", "c");
            words.Add("ч", "ch");
            words.Add("ш", "sh");
            words.Add("щ", "sch");
            words.Add("ъ", "j");
            words.Add("ы", "i");
            words.Add("ь", "j");
            words.Add("э", "e");
            words.Add("ю", "yu");
            words.Add("я", "ya");
            words.Add("А", "A");
            words.Add("Б", "B");
            words.Add("В", "V");
            words.Add("Г", "G");
            words.Add("Д", "D");
            words.Add("Е", "E");
            words.Add("Ё", "Yo");
            words.Add("Ж", "Zh");
            words.Add("З", "Z");
            words.Add("И", "I");
            words.Add("Й", "J");
            words.Add("К", "K");
            words.Add("Л", "L");
            words.Add("М", "M");
            words.Add("Н", "N");
            words.Add("О", "O");
            words.Add("П", "P");
            words.Add("Р", "R");
            words.Add("С", "S");
            words.Add("Т", "T");
            words.Add("У", "U");
            words.Add("Ф", "F");
            words.Add("Х", "H");
            words.Add("Ц", "C");
            words.Add("Ч", "Ch");
            words.Add("Ш", "Sh");
            words.Add("Щ", "Sch");
            words.Add("Ъ", "J");
            words.Add("Ы", "I");
            words.Add("Ь", "J");
            words.Add("Э", "E");
            words.Add("Ю", "Yu");
            words.Add("Я", "Ya");
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

        public object Session { get; private set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainFormCourier_Load(object sender, EventArgs e)
        {
            loadDtv();

            lbLogin.Text = authorizedStaff.login;

            webBrowser1.ScriptErrorsSuppressed = true;
           
            if (authorizedStaff.persInfo == "00:00 - 10:00")
            {
                startTime = 0;
                finTime = 10;
            }
            if (authorizedStaff.persInfo == "10:00 - 18:00")
            {
                startTime = 10;
                finTime = 18;
            }
            if (authorizedStaff.persInfo == "18:00 - 00:00")
            {
                startTime = 18;
                finTime = 0;
            }

            if (finTime == 0)
            {
                finTime = finTime - DateTime.Now.Hour + 23;
            }
            else
            {
                finTime = finTime - DateTime.Now.Hour - 1;
            }

            int minEnd = 60;
            minEnd = minEnd - DateTime.Now.Minute;
            lbEndTime.Text = Convert.ToString(finTime) + " час(а) " + Convert.ToString(minEnd) + " минут(ы)";
        }

        public void loadDtv()
        {
            DtvReturnColumns();

            if (authorizedStaff.persInfo == "00:00 - 10:00")
            {
                startTime = 0;
                finTime = 10;
                lbWorkingTime.Text = "00:00 - 10:00";
                CbFill(0, 10);
            }
            else if (authorizedStaff.persInfo == "10:00 - 18:00")
            {
                startTime = 10;
                finTime = 18;
                lbWorkingTime.Text = "10:00 - 18:00";
                CbFill(10, 18);
            }
            else if (authorizedStaff.persInfo == "18:00 - 00:00")
            {
                startTime = 18;
                finTime = 24;
                lbWorkingTime.Text = "18:00 - 00:00";
                CbFill(18, 24);
            }

            dtvMain.Rows.Clear();

            List<Order> orders = context.Order.Where(p => p.deliveryType == "Курьером").Where(k => k.deliveryTime.Hour >= startTime).Where(t => t.deliveryTime.Hour < finTime).Where(h => h.deliveryTime.Day == DateTime.Now.Day).ToList();

            foreach (var order in orders)
            {
                dtvMain.Rows.Add(order.id, order.name, order.surname, order.adress, order.phone, order.email, order.deliveryTime);
            }
        }

        private void DtvReturnColumns()
        {
            lbTotalPriceText.Visible = false;
            lbTotalPrice.Visible = false;
            pbExcel.Visible = true;
            dtvMain.Rows.Clear();
            dtvMain.Columns[0].HeaderText = "Идентификатор";
            dtvMain.Columns[1].HeaderText = "Имя";
            dtvMain.Columns[2].HeaderText = "Фамилия";
            dtvMain.Columns[3].HeaderText = "Адрес";
            dtvMain.Columns[4].HeaderText = "Телефон";
            dtvMain.Columns[5].HeaderText = "Почта";
            dtvMain.Columns[6].HeaderText = "Время доставки"; ;
        }

        private void CbFill(int start, int end)
        {
            cbDel.Items.Clear();
            cbMap.Items.Clear();
            cbCall.Items.Clear();
            cbCont.Items.Clear();
            cbDel.Text = "";
            cbMap.Text = "";
            cbCall.Text = "";
            cbCont.Text = "";
            foreach (var item in context.Order.ToList())
            {
                if ((item.deliveryTime.Hour >= start) && (item.deliveryTime.Hour < end) && (item.deliveryTime.Day == DateTime.Now.Day) && (item.deliveryType == "Курьером"))
                {
                    cbMap.Items.Add(item.id);
                    cbCall.Items.Add(item.id);
                    cbCont.Items.Add(item.id);
                }
                if ((item.deliveryTime.Hour >= start) && (item.deliveryTime.Hour < end) && (item.deliveryTime.Day == DateTime.Now.Day) && (item.deliveryType == "Курьером") && (item.restReady == true) && (item.courReady == false))
                {
                    cbDel.Items.Add(item.id);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnWebBrowser.Visible = false;
        }

        private void btnMapView_Click(object sender, EventArgs e)
        {
            if (cbMap.Text != "")
            {
                try
                {
                    pnWebBrowser.Visible = true;

                    int idOrder = Convert.ToInt32(cbMap.Text);

                    Order currOrder = context.Order.Where(p => p.id == idOrder).FirstOrDefault();

                    string adress = Transliter(currOrder.adress);

                    StringBuilder queryaddress = new StringBuilder();
                    queryaddress.Append("http://maps.google.com/maps?q=");

                    if (adress != string.Empty)
                    {
                        queryaddress.Append(adress);
                    }

                    webBrowser1.Navigate(queryaddress.ToString());
                }
                catch (Exception ex)
                {
                    notification_form.msgNotification = "Ошибка!";
                    notification_form.lbNotifLeft = 100;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                }
            }
            else
            {
                notification_form.msgNotification = "Выберите заказ!";
                notification_form.lbNotifLeft = 90;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        private void bntDelOrder_Click(object sender, EventArgs e)
        {
            if (cbDel.Text != "")
            {
                int idOrder = Convert.ToInt32(cbDel.Text);
                Order delOrder = context.Order.Where(c => c.id == idOrder).FirstOrDefault();
                delOrder.courReady = true;
                context.SaveChanges();
                loadOrders(Convert.ToInt32(cbDel.Text));
                cbDel.Text = "";

                notification_form.msgNotification = "Заказ выполнен!";
                notification_form.lbNotifLeft = 90;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
            else
            {
                notification_form.msgNotification = "Выберите заказ!";
                notification_form.lbNotifLeft = 90;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        private void btnUruchye_Click(object sender, EventArgs e)
        {
            regionOutput(stretsUruchye);
        }

        private void btnGrMeadow_Click(object sender, EventArgs e)
        {
            regionOutput(stretsGrMeadow);
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            regionOutput(stretsCenter);
        }

        public void regionOutput(string[] masName)
        {
            string index = "";
            DtvReturnColumns();

            for (int i = 0; i < masName.Length; i++)
            {
                index = masName[i];
                List<Order> orders = context.Order.Where(k => k.adress.Contains(index)).Where(p => p.deliveryType == "Курьером").Where(k => k.deliveryTime.Hour >= startTime).Where(t => t.deliveryTime.Day == DateTime.Now.Day).ToList();
                if (orders != null)
                {
                    foreach (var order in orders)
                    {
                        dtvMain.Rows.Add(order.id, order.name, order.surname, order.adress, order.phone, order.email, order.deliveryTime);
                    }
                    if (dtvMain.Rows.Count == 1)
                    {
                        notification_form.msgNotification = "В данном районе заказов нет!";
                        notification_form.lbNotifLeft = 25;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                    else
                    {
                        notification_form.msgNotification = "Заказы найдены!";
                        notification_form.lbNotifLeft = 85;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                }
            }
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            if (cbCall.Text != "")
            {
                try
                {
                    int idOrder = Convert.ToInt32(cbCall.Text);

                    Order currOrder = context.Order.Where(p => p.id == idOrder).FirstOrDefault();

                    string phNumber = currOrder.phone;

                    StringBuilder queryaddress = new StringBuilder();
                    queryaddress.Append("https://my.zadarma.com/connect/?number=");

                    if (phNumber != string.Empty)
                    {
                        queryaddress.Append(phNumber);
                    }

                    Process.Start("chrome.exe", queryaddress.ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Ошибка!");
                }
            }
            else
            {
                notification_form.msgNotification = "Выберите заказ!";
                notification_form.lbNotifLeft = 90;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
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

            for (int i = 1; i < dtv.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dtv.Columns[i - 1].HeaderText;
                worksheet.Cells[1, i].Font.Color = ColorTranslator.ToOle(Color.White);
                worksheet.Cells[1, i].Interior.Color = ColorTranslator.ToOle(Color.Red);
            }

            for (int i = 0; i < dtv.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtv.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dtv.Rows[i].Cells[j].Value.ToString();
                    worksheet.Cells[i + 2, j + 1].Font.Color = ColorTranslator.ToOle(Color.Black);
                    worksheet.Cells[i + 2, j + 1].Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                }
            }
            app.Quit();
        }

        private void btnBackAutorisation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorisation autorisation_form = new Autorisation();
            autorisation_form.Show();
        }

        private void pbExcel_Click(object sender, EventArgs e)
        {
            ExcellExport(dtvMain);
        }

        private void pbReloadDtv_Click(object sender, EventArgs e)
        {
            loadDtv();
        }

        private void pbScrenShot_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(dtvMain.Width, dtvMain.Height);
            dtvMain.DrawToBitmap(bitmap, new Rectangle(new Point(), dtvMain.Size));
            bitmap.Save(@"C:\Users\User\source\repos\DB_FoodDelivery\DB_FoodDelivery\bin\Debug\screenshotsCourier\printscreen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            notification_form.msgNotification = "Скрин-шот сохранён!";
            notification_form.lbNotifLeft = 72;
            notification_form.lbNotifTop = 78;
            notification_form.Show();
        }

        public string Transliter(string input)
        {
            string source = input;
            foreach (KeyValuePair<string, string> pair in words)
            {
                source = source.Replace(pair.Key, pair.Value);
            }
            return source;
        }

        private void cbMap_Click(object sender, EventArgs e)
        {
            loadDtv();
        }

        private void cbCall_Click(object sender, EventArgs e)
        {
            loadDtv();
        }

        private void btnContentOrder_Click(object sender, EventArgs e)
        {
            if (cbCont.Text != "")
            {
                loadOrders(Convert.ToInt32(cbCont.Text));
            }
            else
            {
                notification_form.msgNotification = "Выберите заказ!";
                notification_form.lbNotifLeft = 90;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        private void loadOrders(int currId)
        {
            long totalPrice = 0;
            dtvMain.Rows.Clear();
            dtvMain.Columns[0].HeaderText = "Номер";
            dtvMain.Columns[1].HeaderText = "Название";
            dtvMain.Columns[2].HeaderText = "Вес";
            dtvMain.Columns[3].HeaderText = "Цена";
            dtvMain.Columns[4].HeaderText = "Ресторан";
            dtvMain.Columns[5].HeaderText = "Статус ресторана";
            dtvMain.Columns[6].HeaderText = "Статус доставки";

            var ordersContent = context.OrderInfo.ToList();
            var dishes = context.Dish.ToList();

            foreach (var content in ordersContent)
            {
                Order currOrder = context.Order.Where(c => c.id == content.orderId).FirstOrDefault();
                Dish currDish = context.Dish.Where(d => d.id == content.dishId).FirstOrDefault();
                Restaurant currRest = context.Restaurant.Where(r => r.id == currDish.restaurantID).FirstOrDefault();

                if (content.orderId == currId)
                {
                    totalPrice += content.price;
                    if ((currOrder.restReady == false) && (currOrder.courReady == false))
                    {
                        dtvMain.Rows.Add(content.orderId, currDish.name, currDish.weight, currDish.price, currRest.name, "Не готов", "Не доставлен");
                    }
                    else if ((currOrder.restReady == true) && (currOrder.courReady == true))
                    {
                        dtvMain.Rows.Add(content.orderId, currDish.name, currDish.weight, currDish.price, currRest.name, "Готов", "Доставлен");
                    }
                    else if ((currOrder.restReady == true) && (currOrder.courReady == false))
                    {
                        dtvMain.Rows.Add(content.orderId, currDish.name, currDish.weight, currDish.price, currRest.name, "Готов", "Не доставлен");
                    }
                    else if ((currOrder.restReady == false) && (currOrder.courReady == true))
                    {
                        dtvMain.Rows.Add(content.orderId, currDish.name, currDish.weight, currDish.price, currRest.name, "Не готов", "Доставлен");
                    }
                }
            }
            lbTotalPriceText.Visible = true;
            lbTotalPrice.Visible = true;
            pbExcel.Visible = false;
            lbTotalPrice.Text = totalPrice.ToString() + " р.";
        }
    }
}

