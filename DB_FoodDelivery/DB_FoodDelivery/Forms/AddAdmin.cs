using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_FoodDelivery
{
    public partial class AddAdmin : Form
    {
        string dishImg = "";
        FoodDeliveryEntities context = new FoodDeliveryEntities();
        Notification notification_form = new Notification();

        public AddAdmin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSelImg_Click(object sender, EventArgs e)
        {
            dishImg = Open_Dialog();
        }

        public string Open_Dialog()
        {
            string imgAdress = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "jpeg|*.jpeg| png|*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                imgAdress = fileDialog.FileName;
            }

            imgAdress = imgAdress.Substring(imgAdress.IndexOf(@"\img"));

            char slash = Convert.ToChar(@"\");

            imgAdress = imgAdress.Replace(slash, '/');


            return imgAdress;
        }

        Boolean IsFilled(string mode)
        {
            if (mode == "rest")
            {
                if ((tb1.Text == "") || (tb2.Text == "") || (tb3.Text == "") || (tb4.Text == "") || (tb5.Text == "") || (comboB1.Text == ""))
                {
                    notification_form.msgNotification = "Заполните все поля!";
                    notification_form.lbNotifLeft = 75;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (mode == "dish")
            {
                if ((tb1.Text == "") || (tb2.Text == "") || (tb3.Text == "") || (tb4.Text == "") || (cbRest.Text == ""))
                {
                    notification_form.msgNotification = "Заполните все поля!";
                    notification_form.lbNotifLeft = 75;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (mode == "staff")
            {
                if ((tb1.Text == "") || (tb2.Text == "") || (tb3.Text == "") || (tb4.Text == "") || (tb5.Text == "") || (tb6.Text == "") || (comboB1.Text == ""))
                {
                    notification_form.msgNotification = "Заполните все поля!";
                    notification_form.lbNotifLeft = 75;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        Boolean IsCorrect(string mode)
        {
            int newname;
            int name;
            int desc;
            int price;
            int weight;

            if (mode == "rest")
            {
                if (int.TryParse(tb1.Text, out newname) || int.TryParse(tb2.Text, out name) || int.TryParse(tb3.Text, out desc) || int.TryParse(tb5.Text, out desc))
                {
                    notification_form.msgNotification = "Не корректные данные!";
                    notification_form.lbNotifLeft = 60;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                    return false;
                }
                else
                {
                    if (dishImg == "")
                    {
                        notification_form.msgNotification = "Выберите фото!";
                        notification_form.lbNotifLeft = 90;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else if (mode == "dish")
            {
                if (int.TryParse(tb1.Text, out name) || !int.TryParse(tb2.Text, out desc) || int.TryParse(tb3.Text, out price) || !int.TryParse(tb4.Text, out weight))
                {
                    notification_form.msgNotification = "Не корректные данные!";
                    notification_form.lbNotifLeft = 60;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                    return false;
                }
                else
                {
                    if (dishImg == "")
                    {
                        notification_form.msgNotification = "Выберите фото!";
                        notification_form.lbNotifLeft = 90;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else if (mode == "staff")
            {
                if (int.TryParse(tb1.Text, out name) || int.TryParse(tb2.Text, out desc))
                {
                    notification_form.msgNotification = "Не корректные данные!";
                    notification_form.lbNotifLeft = 60;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                    return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool IsUserExist()
        {
            using (var db = new FoodDeliveryEntities())
            {
                Staff check = db.Staff.Where(p => p.login == tb3.Text).FirstOrDefault();
                if (check != null)
                {
                    notification_form.msgNotification = "Данный логин уже существует!";
                    notification_form.lbNotifLeft = 20;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool IsMailExist()
        {
            using (var db = new FoodDeliveryEntities())
            {
                Staff check = db.Staff.Where(p => p.email == tb5.Text).FirstOrDefault();
                if (check != null)
                {
                    notification_form.msgNotification = "Пользователь с такой почтой \n " +
                                                        "            уже существует!";
                    notification_form.lbNotifLeft = 27;
                    notification_form.lbNotifTop = 65;
                    notification_form.Show();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        static bool IsValidMailAddress(string mailAddress)
        {
            return Regex.IsMatch(mailAddress, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (lb7.Text == "Категория")
            {
                if (IsFilled("rest") == true)
                {
                    if (IsCorrect("rest") == true)
                    {
                        var a = context.Restaurant.Max(c => c.id);
                        int category = 0;

                        if (comboB1.Text == "Суши")
                        {
                            category = 1;
                        }
                        else if (comboB1.Text == "Пицца")
                        {
                            category = 2;
                        }
                        else if (comboB1.Text == "Бургеры")
                        {
                            category = 3;
                        }
                        else if (comboB1.Text == "Другое")
                        {
                            category = 4;
                        }

                        var newRest = new Restaurant { id = a + 1, name = tb1.Text, shortDesc = tb2.Text, longDesc = tb3.Text, workingTime = tb4.Text, address = tb5.Text, FoodCategoryid = category, isFavourite = cb1.Checked, img = dishImg };
                        context.Restaurant.Add(newRest);
                        context.SaveChanges();
                        this.Close();

                        notification_form.msgNotification = "Ресторан успешно добавлен!";
                        notification_form.lbNotifLeft = 31;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                }
            }
            else if (lb2.Text == "Вес")
            {
                if (IsFilled("dish") == true)
                {
                    if (IsCorrect("dish") == true)
                    {
                        var a = context.Dish.Max(c => c.id);
                        int weight = Convert.ToInt32(tb2.Text);
                        int price = Convert.ToInt32(tb4.Text);
                        Restaurant currRest = context.Restaurant.Where(r => r.name == cbRest.Text).FirstOrDefault();
                        var newDish = new Dish { id = a + 1, name = tb1.Text, weight = weight, shortDesc = tb3.Text, restaurantID = currRest.id, price = price, img = dishImg };
                        context.Dish.Add(newDish);
                        context.SaveChanges();
                        this.Close();

                        notification_form.msgNotification = "Блюдо успешно добавлено!";
                        notification_form.lbNotifLeft = 32;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                }
            }
            else if (lb1.Text == "Имя сотрудника")
            {
                if (IsFilled("staff") == true)
                {
                    if (IsCorrect("staff") == true)
                    {
                        //if (IsUserExist() == false)
                        //    {
                        //    if (IsEmailExist() == false)
                        //    {
                        string position = "";
                        if (comboB1.Text == "ресторатор")
                        {
                            position = "restMan";
                        }
                        else
                        {
                            position = "courier";
                        }

                        var a = context.Staff.Max(c => c.Id);
                        var newStaff = new Staff { Id = a + 1, name = tb1.Text, surname = tb2.Text, login = tb3.Text, password = tb4.Text, email = tb5.Text, persInfo = tb6.Text, position = position };
                        context.Staff.Add(newStaff);
                        context.SaveChanges();
                        this.Close();

                        notification_form.msgNotification = "Сотрудник успешно добавлен!";
                        notification_form.lbNotifLeft = 24;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                }
            }
        }
                //    }
                //}
            }
        }

