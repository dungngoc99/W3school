using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForEX
{
    class Program_Animal
    {
        public abstract class Animal
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public abstract int Speed();
            public abstract int InitialCalories();
            int Calories = 0;
            int Distance = 0;

            public int Eat()
            {
                return this.Calories = this.Calories + this.GetCaloriesPerEat() + this.InitialCalories();
            }

            public int TotalCaloriesAfterAll()
            {
                return this.Calories = this.Eat() - this.GetBurnCaloPerTime();
            }

            public Animal(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
            public int Run()
            {
                if (TotalCaloriesAfterAll() >= 0)
                {
                    if(this.Age>=30 && this.Age <= 40)
                    {
                        return this.Distance += this.Speed() - 1;
                    }
                    if (this.Age > 40)
                    {
                        return this.Distance += this.Speed() - 2;
                    }
                    else
                    {
                        return this.Distance;
                    }
                }
                else
                {
                    return this.Distance;
                }
                
            }

            public abstract int GetBurnCaloPerTime();

           

            public abstract int GetCaloriesPerEat();

        }
        public class Dog : Animal
        {
            public string Spieces { get; set; }
            public Dog(string name, int age, string spieces) : base(name, age)
            {
                this.Spieces = spieces;
            }
            public override int InitialCalories()
            {
                return 0;
            }
            public override int Speed ()
            {
                switch (this.Spieces)
                {
                    case "corgi":
                        return 5;
                    case "chihuahua":
                        return 6;
                    default:
                        return 0;
                }
            }
            public override int GetBurnCaloPerTime()
            {
                switch (this.Spieces)
                {
                    case "corgi":
                        return 5;
                    case "chihuahua":
                        return 6;
                    default:
                        return 0;
                }
            }
            public override int GetCaloriesPerEat()
            {
                return 10;
            }
        }
        public class Human : Animal
        {
            public string Spieces { get; set; }
            public Human(string name, int age, string spieces) : base(name, age)
            {
                this.Spieces = spieces;
            }
            public override int InitialCalories()
            {
                return 5;
            }
            public override int Speed()
            {
                switch (this.Spieces)
                {
                    case "africa":
                        return 10;
                    case "asian":
                        return 7;
                    default:
                        return 0;
                }
            }
            public override int GetBurnCaloPerTime()
            {
                switch (this.Spieces)
                {
                    case "africa":
                        return 10;
                    case "asian":
                        return 7;
                    default:
                        return 0;
                }
            }
            public override int GetCaloriesPerEat()
            {
                return 5;
            }
        }
    }
}
