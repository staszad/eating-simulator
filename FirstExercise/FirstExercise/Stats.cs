using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class Food
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
    }
    public class Stats
    {
        public Stats(float hunger, int money, int energy)
        {
            EnergyNeeded = energy;
            HungerPercentage = hunger;
            MoneyAmount = money;
            EnergyLevel = energy * hunger / 100;
            availableFood = new FoodList();
            boughtFood = new FoodList();
            availableFood.Add(new Food("cucumber", 100, 4, 25));
            availableFood.Add(new Food("hamburger", 1200, 20, 5));
            availableFood.Add(new Food("chicken nuggets", 250, 10, 37));
        }
        public float HungerPercentage { get; set; }
        public int MoneyAmount { get; set; }
        public float EnergyLevel { get; set; }
        public int EnergyNeeded { get; set; }
        public FoodList availableFood;
        public FoodList boughtFood;
    }
}
