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
            initializeStats(50, 300, 3000);
        }

        private void initializeStats(float hunger, int money, int energyNeeded)
        {
            InitializeComponent();
            instance = this;         

            Stats.EnergyNeeded = energyNeeded;
            Stats.HungerPercentage = hunger;
            Stats.MoneyAmount = money;
            Stats.EnergyLevel = energyNeeded * (100 - hunger) / 100;
            Stats.availableFood = new FoodList();
            Stats.boughtFood = new FoodList();
            Stats.availableFood.Add(new Food("cucumber", 100, 4, 25));
            Stats.availableFood.Add(new Food("hamburger", 1200, 20, 5));
            Stats.availableFood.Add(new Food("chicken nuggets", 250, 10, 37));

            label2.Text = Stats.HungerPercentage.ToString() + "%";
            label3.Text = "$" + Stats.MoneyAmount.ToString();
        }

        public void updateStats()
        {
            label2.Text = Stats.HungerPercentage.ToString() + "%";
            label3.Text = "$" + Stats.MoneyAmount.ToString();
        }

        private void OpenBuyingForm(object sender, EventArgs e)
        {
            BuyingForm buyingForm = new BuyingForm();
            buyingForm.Show();
        }

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
