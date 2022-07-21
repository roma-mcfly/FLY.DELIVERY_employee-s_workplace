using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Forms.Internals;
using Excel = Microsoft.Office.Interop.Excel;

namespace DB_FoodDelivery
{
    public partial class MainFormRestorator : Form
    {
        Staff authorizedStaff = new Staff();
        Notification notification_form = new Notification();
        FoodDeliveryEntities context = new FoodDeliveryEntities();
        Dictionary<string, string> words = new Dictionary<string, string>();

        public MainFormRestorator()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        public DataGridView DtvMain
        {
            set
            {
                dtvMain = value;
            }
            get
            {
                return dtvMain;
            }
        }

        public void loadDtv()
        {
             pbExcel.Visible = false;
            ///
            pnWorkload.Visible = false;
            pnOrders.Visible = false;
            pnDishes.Visible = true;
            pnSearch.Visible = true;
            dtvMain.Rows.Clear();
            dtvMain.Columns[0].HeaderText = "Название";
            dtvMain.Columns[1].HeaderText = "Описание";
            dtvMain.Columns[2].HeaderText = "Цена";
            dtvMain.Columns[3].HeaderText = "Вес";
            dtvMain.Columns[4].Visible = false;

            using (var db = new FoodDeliveryEntities())
            {
                string transinfo = Transliter(authorizedStaff.persInfo);
                Restaurant currRest = db.Restaurant.Where(p => p.name == transinfo).FirstOrDefault();
                List<Dish> dishes = db.Dish.Where(p => p.restaurantID == currRest.id).ToList();

                foreach (var dish in dishes)
                {
                    dtvMain.Rows.Add(dish.name, dish.shortDesc, dish.price, dish.weight);
                }
            }
        }

        private void btnChangeDish_Click(object sender, EventArgs e)
        {
            string transinfo = Transliter(authorizedStaff.persInfo);
            using (var db = new FoodDeliveryEntities())
            {
                Restaurant currRest = db.Restaurant.Where(p => p.name == transinfo).FirstOrDefault();
                Add add_form = new Add();
                add_form.idCurrRest = currRest.id;
                add_form.headingText = "Изменение";
                add_form.isChange = true;
                add_form.Show();
            }
        }

        private void bntAddDish_Click(object sender, EventArgs e)
        {
            string transinfo = Transliter(authorizedStaff.persInfo);
            using (var db = new FoodDeliveryEntities())
            {
                Restaurant currRest = db.Restaurant.Where(p => p.name == transinfo).FirstOrDefault();
                Add add_form = new Add();
                add_form.idCurrRest = currRest.id;
                add_form.headingText = "Добавление";
                add_form.Show();
            }
        }

        private void btnRemoveDish_Click(object sender, EventArgs e)
        {
            string transinfo = Transliter(authorizedStaff.persInfo);
            DeleteForm deleteForm = new DeleteForm();
            using (var db = new FoodDeliveryEntities())
            {
                Restaurant currRest = db.Restaurant.Where(p => p.name == transinfo).FirstOrDefault();
                foreach (var item in context.Dish.Where(r => r.restaurantID == currRest.id).ToList())
                {
                    deleteForm.cbDelete.Items.Add(item.name);
                }
            }             
            deleteForm.headingText = "Выберите название \n блюда:";
            deleteForm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                dtvMain.Rows.Clear();
                using (var db = new FoodDeliveryEntities())
                {
                    string transinfo = Transliter(authorizedStaff.persInfo);
                    Restaurant currRest = db.Restaurant.Where(p => p.name == transinfo).FirstOrDefault();

                    int RestId = currRest.id;

                    if (currRest != null)
                    {
                        List<Dish> dishes = db.Dish.Where(p => p.name.Contains(tbSearch.Text)).Where(k => k.restaurantID == currRest.id).ToList();

                        for (int i = 0; i < dishes.Count; i++)
                        {
                            if (dishes[i].restaurantID != RestId)
                            {
                                dishes.Remove(dishes[i]);
                            }
                        }

                        int countContains = dishes.Count();

                        foreach (var dish in dishes)
                        {
                            dtvMain.Rows.Add(dish.name, dish.shortDesc, dish.price, dish.weight);
                        }

                        notification_form.msgNotification = "Найдено: " + countContains + " совпадения(й)";
                        notification_form.lbNotifLeft = 35;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();

                    }
                    else
                    {
                        notification_form.msgNotification = "Такого блюда не найдено!";
                        notification_form.lbNotifLeft = 35;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                }
            }
            else
            {
                notification_form.msgNotification = "Заполните поле!";
                notification_form.lbNotifLeft = 92;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        private void MainFormRestorator_Load(object sender, EventArgs e)
        {
            string transinfo = Transliter(authorizedStaff.persInfo);
            using (var db = new FoodDeliveryEntities())
            {
                Restaurant currRest = db.Restaurant.Where(p => p.name == transinfo).FirstOrDefault();
                lbRestInfo.Text = currRest.longDesc;
                pctbRestImg.Image = Image.FromFile(@"C:\Users\User\source\repos\FoodDelivery\FoodDelivery\wwwroot\" + currRest.img);
            }

            lbLogin.Text = authorizedStaff.login;
            lbRestName.Text = transinfo;

            loadDtv();
        }

        private void btnBackAutorisation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorisation autorisation_form = new Autorisation();
            autorisation_form.Show();
        }

        private void pbReloadDtv_Click(object sender, EventArgs e)
        {
            loadDtv();
        }

        private void pbExcel_Click(object sender, EventArgs e)
        {
            ExcellExport(dtvMain);
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

        private void pbScrenShot_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(dtvMain.Width, dtvMain.Height);
            dtvMain.DrawToBitmap(bitmap, new Rectangle(new Point(), dtvMain.Size));
            bitmap.Save(@"C:\Users\User\source\repos\DB_FoodDelivery\DB_FoodDelivery\bin\Debug\screenshotsRestMan\printscreen.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            notification_form.msgNotification = "Скрин-шот сохранён!";
            notification_form.lbNotifLeft = 72;
            notification_form.lbNotifTop = 78;
            notification_form.Show();
        }

        private void pbChangeInfo_Click(object sender, EventArgs e)
        {
            tbChangeDesc.Visible = true;
            btnChangeDesc.Visible = true;
        }

        private void btnChangeDesc_Click(object sender, EventArgs e)
        {
            string transinfo = Transliter(authorizedStaff.persInfo);
            if (tbChangeDesc.Text != "")
            {
                Restaurant changeRest = context.Restaurant.Where(p => p.name == transinfo).FirstOrDefault();
                if (changeRest != null)
                {
                    changeRest.longDesc = tbChangeDesc.Text;

                    notification_form.msgNotification = "Описание успешно изменено!";
                    tbChangeDesc.Visible = false;
                    btnChangeDesc.Visible = false;
                    notification_form.lbNotifLeft = 30;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                    context.SaveChanges();

                    Restaurant currRest = context.Restaurant.Where(p => p.name == transinfo).FirstOrDefault();
                    lbRestInfo.Text = currRest.longDesc;
                }
            }
            else
            {
                notification_form.msgNotification = "Заполните поле!";
                notification_form.lbNotifLeft = 55;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        private void btnContentOrder_Click(object sender, EventArgs e)
        {
            if (cbOrders.Text != "")
            {
                int idOrder = Convert.ToInt32(cbOrders.Text);
                Order delOrder = context.Order.Where(c => c.id == idOrder).FirstOrDefault();
                delOrder.restReady = true;
                context.SaveChanges();
                loadOrders();
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

        private void btnCurrentOrders_Click(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void loadOrders()
        {
            pnWorkload.Visible = true;
            pnOrders.Visible = true;
            pnDishes.Visible = false;
            pnSearch.Visible = false;
            int progress = 0;
            dtvMain.Rows.Clear();
            cbOrders.Items.Clear();
            cbOrders.Text = "";
            dtvMain.Columns[0].HeaderText = "Номер";
            dtvMain.Columns[1].HeaderText = "Блюдо";
            dtvMain.Columns[2].HeaderText = "Статус";
            dtvMain.Columns[3].HeaderText = "Время готовности";
            dtvMain.Columns[4].HeaderText = "Способ доставки";
            dtvMain.Columns[4].Visible = true;
            pbExcel.Visible = false;

            var ordersContent = context.OrderInfo.ToList();

            string transinfo = Transliter(authorizedStaff.persInfo);
            Restaurant currRest = context.Restaurant.Where(p => p.name == transinfo).FirstOrDefault();

            foreach (var content in ordersContent)
            {
                Order currOrder = context.Order.Where(c => c.id == content.orderId).FirstOrDefault();

                if (currOrder.deliveryTime.Date == DateTime.Now.Date)
                {
                    Dish currDish = context.Dish.Where(c => c.restaurantID == currRest.id).Where(d => d.id == content.dishId).FirstOrDefault();

                    if ((currDish != null) && (currOrder != null))
                    {
                        if (currOrder.restReady == false)
                        {
                            dtvMain.Rows.Add(content.orderId, currDish.name, "Не готов", currOrder.deliveryTime.Subtract(new TimeSpan(0, 1, 0, 0)).ToString("HH:mm"), currOrder.deliveryType);
                            cbOrders.Items.Add(Convert.ToString(currOrder.id));
                        }
                        else
                        {
                            dtvMain.Rows.Add(content.orderId, currDish.name, "Передан курьеру", currOrder.deliveryTime.Subtract(new TimeSpan(0, 1, 0, 0)).ToString("HH:mm"), currOrder.deliveryType);
                        }
                    }

                    object[] items = cbOrders.Items.OfType<String>().Distinct().ToArray();
                    cbOrders.Items.Clear();
                    cbOrders.Items.AddRange(items);
                    progress = cbOrders.Items.Count * 10;

                    if (progress < 100)
                    {
                        pgWorkload.Value = progress;
                    }
                    else
                    {
                        pgWorkload.Value = 100;
                        notification_form.msgNotification = "Высокая загруженность!";
                        notification_form.lbNotifLeft = 35;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                }
            }
        }

        public string Transliter(string input)
        {
            string source = input;
            foreach (KeyValuePair<string, string> pair in words)
            {
                source = source.Replace(pair.Value, pair.Key);
            }
            return source;
        }
    }
}
