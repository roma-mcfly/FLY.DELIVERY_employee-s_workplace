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

namespace DB_FoodDelivery
{
    public partial class Autorisation : Form
    {
        FoodDeliveryEntities context = new FoodDeliveryEntities();
        Notification notification_form = new Notification();

        bool moveLeft = true;
        int timePassView = 10;

        public Autorisation()
        {
            InitializeComponent();
            tbLogin.Text = "введите логин";
            tbLoginRec.Text = "введите логин";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool goodEnter = false;

            using (var db = new FoodDeliveryEntities())
            {
                Staff check = db.Staff.Where(p => p.login == tbLogin.Text).Where(p => p.password == tbPassword.Text).FirstOrDefault();

                if (check != null)
                {
                    if (check.position == "restMan")
                    {
                        goodEnter = true;
                        MainFormRestorator main_formRs = new MainFormRestorator();
                        main_formRs.AuthorizedStaff = check;
                        main_formRs.Show();
                    }
                    else if (check.position == "courier")
                    {
                        int startTime = 0;
                        int finTime = 0;

                        if (check.persInfo == "00:00 - 10:00")
                        {
                            startTime = 24;
                            finTime = 10;
                        }
                        if (check.persInfo == "10:00 - 18:00")
                        {
                            startTime = 10;
                            finTime = 18;
                        }
                        if (check.persInfo == "18:00 - 00:00")
                        {
                            startTime = 18;
                            finTime = 24;
                        }

                        if (DateTime.Now.TimeOfDay.IsBetween(new TimeSpan(startTime, 0, 0), new TimeSpan(finTime, 0, 0)))
                        {
                            goodEnter = true;
                            MainFormCourier main_formCou = new MainFormCourier();
                            main_formCou.AuthorizedStaff = check;
                            main_formCou.Show();                         
                        }
                        else
                        {
                            goodEnter = false;
                            notification_form.msgNotification = "Ваша смена ещё не началась!";
                            notification_form.lbNotifLeft = 30;
                            notification_form.lbNotifTop = 78;
                            notification_form.Show();
                        }

                    }
                    else if (check.position == "admin")
                    {
                        goodEnter = true;
                        MainFormAdmin main_formAdm = new MainFormAdmin();
                        main_formAdm.AuthorizedStaff = check;
                        main_formAdm.Show();
                    }

                    if (goodEnter)
                    {
                        this.Hide();
                        notification_form.msgNotification = "Вы успешно вошли!";
                        notification_form.lbNotifLeft = 77;
                        notification_form.lbNotifTop = 78;
                        notification_form.Show();
                    }
                }
                else
                {
                    lbNotifications.Visible = true;
                    lbNotifications.Text = "Логин или пароль не совпадают!";
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbFP_Click(object sender, EventArgs e)
        {
            tmrReSize.Enabled = true;
        }

        private void lbToRegistr_Click(object sender, EventArgs e)
        {
            this.Hide();
            PositionSelection position_form = new PositionSelection();
            position_form.Show();
        }

        private void btnRecovery_Click(object sender, EventArgs e)
        {
            if (IsUserExist())
            {
                Staff findStaff = context.Staff.Where(p => p.login == tbLoginRec.Text).FirstOrDefault();
                this.Hide();
                Varification varification = new Varification();
                varification.NewStaff = findStaff;
                varification.isRecovery = true;
                varification.RandomKey = ToSendRecMail(findStaff.email, findStaff.name);
                varification.Recipient = findStaff.email;
                varification.Show();
            }
        }

        Boolean IsUserExist()
        {
            using (var db = new FoodDeliveryEntities())
            {
                Staff check = db.Staff.Where(p => p.login == tbLoginRec.Text).FirstOrDefault();
                if (check != null)
                {
                    return true;
                }
                else
                {
                    notification_form.msgNotification = "Такого пользователя нет!";
                    notification_form.lbNotifLeft = 55;
                    notification_form.lbNotifTop = 78;
                    notification_form.Show();
                    return false;
                }
            }
        }

        public string ToSendRecMail(string recipient, string name)
        {
            Registration registration_form = new Registration();

            MailAddress Recipient = new MailAddress(recipient);
            MailMessage msg = new MailMessage(registration_form.Sender, Recipient);

            string randomKey = registration_form.RandomKey();

            msg.Subject = "Код для восстановления";
            msg.Body = $"<h2>Здравствуйте {name} </h2>" +
                       $"<h3> Ваш секретный пароль: {randomKey} </h4>";

            msg.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.mail.ru", 587);
            smtpClient.Credentials = new NetworkCredential("rm_volkovich@mail.ru", "Prekol1827");
            smtpClient.EnableSsl = true;
            smtpClient.Send(msg);

            return randomKey;
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            tmrPassView.Enabled = true;
            tbPassword.UseSystemPasswordChar = true;
        }

        private void tmrPassView_Tick(object sender, EventArgs e)
        {
            timePassView -= 1;
            if (timePassView == 0)
            {
                tbPassword.UseSystemPasswordChar = false;
                tmrPassView.Enabled = false;
                timePassView = 10;
            }
        }

        private void btnReMove_Click_1(object sender, EventArgs e)
        {
            tmrReSize.Enabled = true;
        }

        private void tmrReSize_Tick(object sender, EventArgs e)
        {
            if (moveLeft)
            {
                this.Width += 10;
                if (this.Width >= 829)
                {
                    tmrReSize.Enabled = false;
                    moveLeft = false;
                }
            }

            if (moveLeft == false)
            {
                this.Width -= 3;
                if (this.Width <= 419)
                {
                    tmrReSize.Enabled = false;
                    moveLeft = true;
                }
            }
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "введите логин")
            {
                tbLogin.Text = "";
            }
        }

        private void tbLoginRec_Click(object sender, EventArgs e)
        {
            if (tbLoginRec.Text == "введите логин")
            {
                tbLoginRec.Text = "";
            }
        }

       
    }
}
