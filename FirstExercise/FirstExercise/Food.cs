using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class Food : ICloneable
    {
        public Food(string name, int energy, int price, int amount)
        {
            this.name = name;
            this.energy = energy;
            this.price = price;
            this.amount = amount;
        }

        public String name { get; set; }
        public int energy { get; set; }
        public int price { get; set; }
        public int amount { get; set; }

        public object Clone()
        {
            Food clonedFood = this.MemberwiseClone() as Food;
            return clonedFood;
        }
    }
}
