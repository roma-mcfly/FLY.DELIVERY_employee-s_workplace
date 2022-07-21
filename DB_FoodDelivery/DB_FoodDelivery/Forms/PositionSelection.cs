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
    public partial class PositionSelection : Form
    {
        public PositionSelection()
        {
            InitializeComponent();
        }

        private void btnBackAutorisation_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorisation autorisation_form = new Autorisation();
            autorisation_form.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration_form = new Registration();
            if (cbPosition.Text == "ресторатор")
            {
                registration_form.staffPos = "restMan";
            }
            else
            {
                registration_form.staffPos = "courier";
            }
            registration_form.Show();
        }
    }
}
