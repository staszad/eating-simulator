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

            Food foodToAddCopy = (Food) foodToAdd.Clone();
            foodToAddCopy.amount = amount;
            this.Add(foodToAddCopy);
        }

        public void removeProduct(Food foodToRemove, int amount)
        {
            foreach (Food f in this)
            {
                if (f.name == foodToRemove.name)
                {
                    f.amount -= amount;
                    if(f.amount == 0)
                    {
                        this.Remove(f);
                    }
                    return;
                }
            }
        }
    }
}
