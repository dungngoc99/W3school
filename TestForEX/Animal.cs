using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForEX
{
    class Program
    {
        public abstract class Hero
        {
            public int health;
            public int mana;
            public int FullMana;
            public int FullHealth;

            public Hero(int health, int mana)
            {
                this.health = health;
                this.mana = mana;
                int MaxMana = mana;
                int MaxHealth = health;
            }

            public abstract void Cast(string skillName, Hero[] targets);

        }
        public class HeroA : Hero
        {
            public HeroA(int health, int mana) : base(health, mana)
            {
            }

            public override void Cast(string skillName, Hero[] targets)
            {
                switch (skillName)
                {
                    case "Q":
                        if (this.mana >= 2)
                        {
                            foreach (Hero i in targets)
                            {
                                i.health -= 15;
                                this.mana -= 2;
                            }
                        }
                        break;
                    case "W":
                        if (this.mana >= 3)
                        {
                            this.health = Math.Min(this.FullHealth, this.health + 10);
                            this.mana = Math.Min(this.FullMana, this.mana + 5);
                            this.mana -= 3;
                        }
                        break;
                    case "E":
                        if (this.mana >= 5)
                        {
                            targets[0].health -= 30;
                            this.mana -= 5;
                        }
                        break;
                    case "R":
                        if (this.mana >= 53)
                        {
                            foreach (Hero i in targets)
                            {
                                i.health -= 30;
                                this.mana -= 5;
                            }
                        }
                        break;
                }
            }
        }
        public class HeroB : Hero
        {
            public HeroB(int health, int mana) : base(health, mana)
            {
            }

            public override void Cast(string skillName, Hero[] targets)
            {
                switch (skillName)
                {
                    case "Q":
                        if (this.mana >= 2)
                        {
                            foreach (Hero i in targets)
                            {
                                i.health -= 20;
                                this.mana -= 3;
                            }
                        }
                        break;
                    case "W":
                        if (this.mana >= 3)
                        {
                            if(targets.Length >= 1)
                            {
                                targets[0].health -= 20;
                                this.mana -= 3;
                                if (targets.Length >= 2)
                                {
                                    targets[1].health -= 20;
                                }
                            }
                           
                        }
                        break;
                    case "E":
                        if (this.mana >= 5)
                        {
                            this.health = Math.Min(this.FullHealth, this.health + 20);
                            this.mana = Math.Min(this.FullMana, this.mana + 5);
                            this.mana -= 5;
                        }
                        break;
                    case "R":
                        if (this.mana >= 53)
                        {
                            targets[0].health -= 50;
                            this.mana = this.FullMana;
                        }
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            var Hero_A = new HeroA(100, 20);
            var Hero_B = new HeroB(80, 20);
        }
    }
}
    
