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
    public partial class DeleteForm : Form
    {
        Notification notification_form = new Notification();
        FoodDeliveryEntities context = new FoodDeliveryEntities();
        public DeleteForm()
        {
            InitializeComponent();
        }


        public string headingText
        {
            set
            {
                lbName.Text = value;
            }
            get
            {
                return lbName.Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbDelete.Text != "")
            {
                Dish delDish = context.Dish.Where(c => c.name == cbDelete.Text).FirstOrDefault();

                context.Dish.Remove(delDish);
                context.SaveChanges();
                notification_form.msgNotification = "Блюдо было удалено!";
                notification_form.lbNotifLeft = 67;
                notification_form.lbNotifTop = 78;
                this.Close();
                notification_form.Show();
            }
            else
            {
                notification_form.msgNotification = "Выберите название!";
                notification_form.lbNotifLeft = 70;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}
