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
    public partial class DeleteAdmin : Form
    {
        Notification notification_form = new Notification();
        FoodDeliveryEntities context = new FoodDeliveryEntities();

        public DeleteAdmin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Boolean IsCbFilled()
        {
            if (cbDelete.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsCbFilled() == false)
            {
                notification_form.msgNotification = "Выберите значение!";
                notification_form.lbNotifLeft = 75;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
            if ((lbText.Text == "Выберите название \n ресторана:") && (IsCbFilled() == true))
            {
                Restaurant delRest = context.Restaurant.Where(c => c.name == cbDelete.Text).FirstOrDefault();
                context.Restaurant.Remove(delRest);
                context.SaveChanges();
                this.Hide();

                notification_form.msgNotification = "Ресторан успешно удален!";
                notification_form.lbNotifLeft = 41;
                notification_form.lbNotifTop = 78;
                this.Close();
                notification_form.Show();
            }
            if ((lbText.Text == "Выберите название \n блюда:") && (IsCbFilled() == true))
            {
                Dish delDish = context.Dish.Where(c => c.name == cbDelete.Text).FirstOrDefault();
                context.Dish.Remove(delDish);
                context.SaveChanges();
                this.Hide();

                notification_form.msgNotification = "Блюдо успешно удалено!";
                notification_form.lbNotifLeft = 43;
                notification_form.lbNotifTop = 78;
                this.Close();
                notification_form.Show();
            }
            if ((lbText.Text == "Выберите логин \n сотрудника:") && (IsCbFilled() == true))
            {
                Staff delStaff = context.Staff.Where(c => c.login == cbDelete.Text).FirstOrDefault();
                context.Staff.Remove(delStaff);
                context.SaveChanges();
                this.Hide();

                notification_form.msgNotification = "Сотрудник успешно удалён!";
                notification_form.lbNotifLeft = 38;
                notification_form.lbNotifTop = 78;
                this.Close();
                notification_form.Show();
            }            
        }
    }
}
