using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_FoodDelivery
{
    public partial class Add : Form
    {
        FoodDeliveryEntities context = new FoodDeliveryEntities();
        Notification notification_form = new Notification();
        int idRest = 0;
        string dishImg = "";
        bool changeMode = false;

        public Add()
        {
            InitializeComponent();
        }

        public int idCurrRest
        {
            set
            {
                idRest = value;
            }
            get
            {
                return idRest;
            }
        }

        public string headingText
        {
            set
            {
                lbText.Text = value;
            }
            get
            {
                return lbText.Text;
            }
        }

        public bool isChange
        {
            set
            {
                changeMode = value;
                cbNewName.Visible = changeMode;
            }
            get
            {
                return changeMode;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = context.Dish.Max(c => c.id);

            if (isChange == false)
            {
                if (IsFilled(false) == true)
                {
                    if (IsDishExist(tbName.Text) == false)
                    {
                        if (IsCorrect(false) == true)
                        {
                            var newDish = new Dish { id = a + 1, name = tbName.Text, availability = false, shortDesc = tbDesc.Text, price = Convert.ToInt32(tbPrice.Text), restaurantID = idCurrRest, weight = Convert.ToInt32(tbWeight.Text), img = dishImg };
                            context.Dish.Add(newDish);
                            notification_form.msgNotification = "Блюдо было успешно добавлено!";
                            notification_form.lbNotifLeft = 10;
                            notification_form.lbNotifTop = 78;
                            this.Close();
                            notification_form.Show();
                        }
                    }
                    else
                    {
                        tbName.Text = "";
                    }
                }
            }
            else
            {
                if (IsFilled(true) == true)
                {
                    if (IsDishExist(tbNewName.Text) == false)
                    {
                        if (IsCorrect(true) == true)
                        {
                            if (cbNewName.Checked == false)
                            {
                                ChangeDish(cbName.Text);
                            }
                            else
                            {
                                ChangeDish(tbNewName.Text);
                            }
                        }
                    }
                    else
                    {
                        tbNewName.Text = "";
                    }
                }
            }
            context.SaveChanges();
        }


        private void ChangeDish(string newName)
        {
            Dish changeDish = context.Dish
                                        .Where(c => c.name == cbName.Text)
                                        .FirstOrDefault();
            if ((changeDish != null) && (IsFilled(true) == true))
            {
                changeDish.name = newName;
                changeDish.price = Convert.ToInt32(tbPrice.Text);
                changeDish.weight = Convert.ToInt32(tbWeight.Text);
                changeDish.shortDesc = tbDesc.Text;

                notification_form.msgNotification = "Блюдо было успешно изменено!";
                notification_form.lbNotifLeft = 15;
                notification_form.lbNotifTop = 78;
                this.Close();
                notification_form.Show();
            }
            else
            {
                notification_form.msgNotification = "Такого блюда нет!";
                notification_form.lbNotifLeft = 80;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        Boolean IsDishExist(string name)
        {
            using (var db = new FoodDeliveryEntities())
            {
                Dish check = db.Dish.Where(p => p.name == name).FirstOrDefault();
                if (check != null)
                {
                    notification_form.msgNotification = "Такое блюдо уже существует!";
                    notification_form.lbNotifLeft = 25;
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

        Boolean IsFilled(bool mode)
        {
            if (mode == true)
            {
                if (cbNewName.Checked == true)
                {
                    if ((cbName.Text == "") || (tbDesc.Text == "") || (tbPrice.Text == "") || (tbWeight.Text == "") || (tbNewName.Text == ""))
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
                    if ((cbName.Text == "") || (tbDesc.Text == "") || (tbPrice.Text == "") || (tbWeight.Text == ""))
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
            }
            else
            {
                if ((tbName.Text == "") || (tbDesc.Text == "") || (tbPrice.Text == "") || (tbWeight.Text == ""))
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
        }

        Boolean IsCorrect(bool mode)
        {
            int newname;
            int name;
            int desc;
            int price;
            int weight;

            if (mode == true)
            {
                if (int.TryParse(tbNewName.Text, out newname) || int.TryParse(tbName.Text, out name) || int.TryParse(tbDesc.Text, out desc) || (!int.TryParse(tbPrice.Text, out price)) || (!int.TryParse(tbWeight.Text, out weight)))
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
            else
            {
                if (int.TryParse(tbName.Text, out name) || int.TryParse(tbDesc.Text, out desc) || (!int.TryParse(tbPrice.Text, out price)) || (!int.TryParse(tbWeight.Text, out weight)))
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

            try
            {
                imgAdress = imgAdress.Substring(imgAdress.IndexOf(@"\img"));
            }
            catch { }

            char slash = Convert.ToChar(@"\");

            imgAdress = imgAdress.Replace(slash, '/');


            return imgAdress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dishImg = Open_Dialog();
        }

        private void cbNewName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNewName.Checked)
            {
                lbNewName.Visible = true;
                tbNewName.Visible = true;
            }
            else
            {
                lbNewName.Visible = false;
                tbNewName.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (isChange == true)
            {
                cbName.Visible = true;
                tbName.Visible = false;
                using (var db = new FoodDeliveryEntities())
                {
                    foreach (var item in context.Dish.Where(r => r.restaurantID == idCurrRest).ToList())
                    {
                        cbName.Items.Add(item.name);
                    }
                }
            }
            else
            {
                cbName.Visible = false;
                tbName.Visible = true;
            }
        }
    }
}
