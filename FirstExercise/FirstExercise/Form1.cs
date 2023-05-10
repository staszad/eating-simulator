using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstExercise
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            label2.Text = userStats.HungerPercentage.ToString() + "%";
            label3.Text = "$" + userStats.MoneyAmount.ToString();
        }

        public void updateStats()
        {
            label2.Text = userStats.HungerPercentage.ToString() + "%";
            label3.Text = "$" + userStats.MoneyAmount.ToString();
        }

        private void OpenBuyingForm(object sender, EventArgs e)
        {
            BuyingForm buyingForm = new BuyingForm();
            buyingForm.Show();
        }

        public Stats userStats = new Stats(50, 300, 3000);

        private void OpenBuyingForm(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BuyingForm buyingForm = new BuyingForm();
            buyingForm.Show();
        }

        private void OpenEatingForm(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EatingForm eatingForm = new EatingForm();
            eatingForm.Show();
        }
    }
}
