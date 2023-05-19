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
    public partial class BuyingForm : Form
    {
        public BuyingForm()
        {
            InitializeComponent();
            gridControl1.DataSource = Stats.availableFood ;
            foodAmountEdit.Properties.Mask.EditMask = "f0";
        }

        private void buyButtonClick(object sender, EventArgs e)
        {
            var availableFood = Stats.availableFood;
            var boughtFood = Stats.boughtFood;
            bool doesProductExist = false;
            foreach(Food f in availableFood)
            {
                if(f.name == foodNameEdit.Text)
                {
                    doesProductExist = true;
                    if(foodAmountEdit.Value < 0)
                    {
                        MessageBox.Show("The number must be positive!");
                    }
                    else if (f.amount < foodAmountEdit.Value)
                    {
                        MessageBox.Show("Too big amount! We don't have that many in our stock.");
                    } else if (f.price * Decimal.ToInt16(foodAmountEdit.Value) > Stats.MoneyAmount)
                    {
                        MessageBox.Show("That's too expensive for you, you poor shmock.");
                    } else
                    {
                        int amount = Decimal.ToInt16(foodAmountEdit.Value);
                        availableFood.removeProduct(f, amount);
                        boughtFood.addProduct(f, amount);
                        Stats.MoneyAmount -= f.price * amount;
                        Form1.instance.updateStats();
                        this.Close();
                        return;
                    }
                }
            }
            if(!doesProductExist) MessageBox.Show("The product does not exist!");
        }
    }
}
