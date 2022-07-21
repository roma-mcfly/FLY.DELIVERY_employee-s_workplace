using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace DB_FoodDelivery
{
    public partial class Registration : Form
    {
        FoodDeliveryEntities context = new FoodDeliveryEntities();
        Notification notification_form = new Notification();

        string staffPosition = "";
        string persInfo = "";
        int timePassView = 10;
        public MailAddress Sender = new MailAddress("rm_volkovich@mail.ru", "FoodDelivery.com");
        Dictionary<string, string> words = new Dictionary<string, string>();

        public Registration()
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
            tbName.Text = "введите имя";
            tbSurname.Text = "введите фамилию";
            tbLogin.Text = "введите логин";
            tbEmail.Text = "введите почту";
        }

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

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (IsUserExist())
            {
                return;
            }

            if ((tbName.Text == "введите имя") || (tbSurname.Text == "введите фамилию") || (tbLogin.Text == "введите логин") || (tbPassword.Text == "") || (tbDoublePassword.Text == "") || (tbEmail.Text == "введите почту") || (cbPersonalInfo.Text == ""))
            {
                notification_form.msgNotification = "Заполните все поля!";
                notification_form.lbNotifLeft = 75;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
                return;
            }

            if (IsEmailExist())
            {
                return;
            }

            if (IsValidMailAddress(tbEmail.Text) == false)
            {
                notification_form.msgNotification = "Не корректная почта!";
                notification_form.lbNotifLeft = 70;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
                return;
            }

            string symb = "ABCDEFGHIJKLMNOPRSTUVWXYZАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ123456789";

            string firstSymbPass = Convert.ToString(tbPassword.Text[0]);

            Regex reg = new Regex(@"^([^а-яА-Я]+)$");

            if ((firstSymbPass.IndexOfAny(symb.ToCharArray()) == -1) || (tbPassword.Text.Length < 8) || (tbPassword.Text[0] == '.') || (tbPassword.Text[0] == ',') || (tbPassword.Text[0] == '!') || (tbPassword.Text[0] == '?') || (tbPassword.Text[0] == ' ') || (!reg.IsMatch(tbPassword.Text)))
            {
                notification_form.msgNotification = "Не корректный пароль!";
                notification_form.lbNotifLeft = 60;
                notification_form.lbNotifTop = 78;
                notification_form.Show();
                return;
            }

            if (tbPassword.Text != tbDoublePassword.Text)
            {
                lbPasswordCheck.Visible = true;
                return;
            }

            string randomKey = ToSendMail(tbEmail.Text, tbName.Text);

            var a = context.Staff.Max(c => c.Id);

            if (staffPos == "restMan")
            {
                persInfo = Transliter(cbPersonalInfo.Text);
            }
            else
            {
                persInfo = cbPersonalInfo.Text;
            }

            var newStaff = new Staff { Id = a + 1, name = tbName.Text, surname = tbSurname.Text, login = tbLogin.Text, password = tbPassword.Text, email = tbEmail.Text, position = staffPos, persInfo = persInfo };

            Varification varification_form = new Varification();
            varification_form.recipName = tbName.Text;
            varification_form.Recipient = tbEmail.Text;
            varification_form.RandomKey = randomKey;
            varification_form.NewStaff = newStaff;
            varification_form.staffPos = staffPos;

            this.Hide();
            varification_form.Show();
        }

        public string ToSendMail(string recipient, string name)
        {
            MailAddress Recipient = new MailAddress(recipient);
            MailMessage msg = new MailMessage(Sender, Recipient);

            string randomKey = RandomKey();

            msg.Subject = "Код подтверждения";
            msg.Body = $"<h2>Здравствуйте {name} </h2>" +
                       $"<h3> Ваш секретный пароль: {randomKey} </h4>";

            msg.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient("smtp.mail.ru", 587);
            smtpClient.Credentials = new NetworkCredential("rm_volkovich@mail.ru", "Prekol1827");
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(msg);
            }
            catch 
            {
                //notification_form.msgNotification = "Такого адреса не существует!";
                //notification_form.lbNotifLeft = 25;
                //notification_form.lbNotifTop = 78;
                //notification_form.Show();
            }
            return randomKey;
        }

        public string RandomKey()
        {
            string abc = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890"; //набор символов
            int KeyLength = 7;
            string result = "";

            Random rnd = new Random();
            int lng = abc.Length;
            for (int i = 0; i < KeyLength; i++)
            { result += abc[rnd.Next(lng)]; }
            return result;
        }

        Boolean IsUserExist()
        {
            using (var db = new FoodDeliveryEntities())
            {
                Staff check = db.Staff.Where(p => p.login == tbLogin.Text).FirstOrDefault();
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

        Boolean IsEmailExist()
        {
            using (var db = new FoodDeliveryEntities())
            {
                Staff check = db.Staff.Where(p => p.email == tbEmail.Text).FirstOrDefault();
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

        private void btnBackAutorisation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorisation autorisation_form = new Autorisation();
            autorisation_form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            var a = context.Staff.Max(c => c.Id);

            if (staffPos == "courier")
            {
                lbPersInfo.Text = "Смена";
                cbPersonalInfo.Text = "выберите смену";
                cbPersonalInfo.Items.Add("00:00 - 10:00");
                cbPersonalInfo.Items.Add("10:00 - 18:00");
                cbPersonalInfo.Items.Add("18:00 - 00:00");
            }
            else if (staffPos == "restMan")
            {
                lbPersInfo.Text = "Ресторан";
                cbPersonalInfo.Text = "выберите ресторан";
                foreach (var item in context.Restaurant.ToList())
                {
                    cbPersonalInfo.Items.Add(item.name);
                }
            }
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

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            tmrPassView.Enabled = true;
            tbPassword.UseSystemPasswordChar = true;
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

        private void tbLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "введите логин")
            {
                tbLogin.Text = "";
            }
        }

        private void tbName_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "введите имя")
            {
                tbName.Text = "";
            }
        }

        private void tbSurname_Click(object sender, EventArgs e)
        {
            if (tbSurname.Text == "введите фамилию")
            {
                tbSurname.Text = "";
            }
        }

        private void tbEmail_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "введите почту")
            {
                tbEmail.Text = "";
            }
        }
    }
}
