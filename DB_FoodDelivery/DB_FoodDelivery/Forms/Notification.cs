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
    public partial class Notification : Form
    {
        string msg = "";
        int lbLeft = 104;
        int lbTop = 98;

        public string msgNotification
        {
            set
            {
                msg = value;
                lbNotification.Text = msg;
            }
            get
            {
                return msg;
            }
        }

        public int lbNotifLeft
        {
            set
            {
                lbLeft = value;
                lbNotification.Left = lbLeft;
            }
            get
            {
                return lbLeft;
            }
        }

        public int lbNotifTop
        {
            set
            {
                lbTop = value;
                lbNotification.Top = lbTop;
            }
            get
            {
                return lbTop;
            }
        }

        public Notification()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            lbNotification.Text = "";
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            lbNotification.Text = msg;
            lbNotification.Left = lbLeft;
            lbNotification.Top = lbTop;
        }
    }
}
