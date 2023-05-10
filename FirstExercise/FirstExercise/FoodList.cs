using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class FoodList : List<Food>
    {
        public void addProduct(Food foodToAdd, int amount)
        {
            foreach(Food f in this)
            {
                if(f.name == foodToAdd.name)
                {
                    f.amount+= amount;
                    return;
                }
            }
            foodToAdd.amount = amount;
            this.Add(foodToAdd);
        }

        public void removeProduct(Food foodToAdd, int amount)
        {
            foreach (Food f in this)
            {
                if (f.name == foodToAdd.name)
                {
                    //exception about negative amount
                    f.amount -= amount;
                    if(f.amount == 0)
                    {
                        this.Remove(f);
                    }
                    return;
                }
            }
            foodToAdd.amount = amount;
            this.Add(foodToAdd);
        }
    }
}
