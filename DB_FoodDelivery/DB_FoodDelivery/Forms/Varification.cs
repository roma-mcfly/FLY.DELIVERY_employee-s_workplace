using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_FoodDelivery
{
    public partial class Varification : Form
    {
        FoodDeliveryEntities context = new FoodDeliveryEntities();
        Notification notification_form = new Notification();

        int time = 60;
        string name = "";
        string recipient = "";
        string randomKey = "";
        string staffPosition = "";
        bool recovery = false;
        Staff newStaff = new Staff();

        public string staffPos
        {
            set
            {
                staffPosition = value;
            }
            get
            {
                return staffPosition;
            }
        }

        public Varification()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if ((tbKey.Text == RandomKey) && (isRecovery != true))
            {
                context.Staff.Add(newStaff);
                context.SaveChanges();

                if (staffPos == "courier")
                {
                    int startTime = 0;
                    int finTime = 0;

                    if (newStaff.persInfo == "00:00 - 10:00")
                    {
                        startTime = 0;
                        finTime = 10;
                    }
                    if (newStaff.persInfo == "10:00 - 18:00")
                    {
                        startTime = 10;
                        finTime = 18;
                    }
                    if (newStaff.persInfo == "18:00 - 00:00")
                    {
                        startTime = 18;
                        finTime = 0;
                    }

                    if ((DateTime.Now.Hour < startTime) && (DateTime.Now.Hour > finTime))
                    {
                        this.Hide();
                        Autorisation autorisation_form = new Autorisation();
                        autorisation_form.Show();
                        notification_form.msgNotification = "Ваша смена ещё не началась!";
                        notification_form.lbNotifLeft = 30;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                    else
                    {
                        this.Hide();
                        MainFormCourier main_form = new MainFormCourier();
                        main_form.AuthorizedStaff = newStaff;
                        main_form.Show();

                        notification_form.msgNotification = "Вы успешно зарегестирированы!";
                        notification_form.lbNotifLeft = 10;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                }
                else
                {
                    this.Hide();
                    MainFormRestorator main_form = new MainFormRestorator();
                    main_form.AuthorizedStaff = newStaff;
                    main_form.Show();

                    notification_form.msgNotification = "Вы успешно зарегестирированы!";
                    notification_form.lbNotifLeft = 10;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                }
            }
            else if ((tbKey.Text == RandomKey) && (isRecovery))
            {
                notification_form.msgNotification = "Ваш пароль: " + newStaff.password;
                notification_form.lbNotifLeft = 58;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
            }
            else
            {
                tbKey.Text = "";
                SystemSounds.Beep.Play();
                lbUnCorrectKey.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Varification_Load(object sender, EventArgs e)
        {
            tmrTime.Enabled = true;
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time -= 1;
            lbMinutes.Text = Convert.ToString(time);
            if (time == 0)
            {
                lbHours.Visible = false;
                lbMinutes.Visible = false;
                btnReSend.Visible = true;
                tmrTime.Enabled = false;
            }
        }

        private void btnReSend_Click(object sender, EventArgs e)
        {
            if (isRecovery != true)
            {
                Registration registration_form = new Registration();
                RandomKey = registration_form.ToSendMail(Recipient, recipName);
                lbUnCorrectKey.Visible = false;
            }
            else if (isRecovery)
            {
                Autorisation autorisation_form = new Autorisation();
                RandomKey = autorisation_form.ToSendRecMail(Recipient, recipName);
                lbUnCorrectKey.Visible = false;
            }

            btnReSend.Visible = false;
            time = 60;
            lbHours.Visible = true;
            lbMinutes.Visible = true;
            tmrTime.Enabled = true;
        }

        public string Recipient
        {
            set
            {
                recipient = value;
            }
            get
            {
                return recipient;
            }
        }

        public string recipName
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string RandomKey
        {
            set
            {
                randomKey = value;
            }
            get
            {
                return randomKey;
            }
        }

        public Staff NewStaff
        {
            set
            {
                newStaff = value;
            }
            get
            {
                return newStaff;
            }
        }

        public bool isRecovery
        {
            set
            {
                recovery = value;
            }
            get
            {
                return recovery;
            }
        }

        private void btnBackAutorisation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorisation autorisation_form = new Autorisation();
            autorisation_form.Show();
        }


    }
}
