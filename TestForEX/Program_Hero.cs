using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForEX
{
    class Program_Hero
    {
        public abstract class Hero
        {
            public int Health { get; set; }
            public int Mana { get; set; }
            public int FullMana { get; private set; }
            public int FullHealth { get; private set; }


            public Hero(int health, int mana)
            {
                this.Health = health;
                this.Mana = mana;
                this.FullHealth = health;
                this.FullMana = mana;
            }
            public abstract int ManaQ();
            public abstract int ManaW();
            public abstract int ManaE();
            public abstract int ManaR();
            public abstract void ActionQ(Hero[] targets);
            public abstract void ActionW(Hero[] targets);
            public abstract void ActionE(Hero[] targets);
            public abstract void ActionR(Hero[] targets);

            public void Cast(string skillName, Hero[] targets)
            {
                int mana;
                switch (skillName)
                {
                    case "Q":
                        {
                            mana = this.ManaQ();
                        }
                        break;
                    case "W":
                        {
                            mana = this.ManaW();
                        }
                        break;
                    case "E":
                        {
                            mana = this.ManaE();
                        }
                        break;
                    case "R":
                        {
                            mana = this.ManaQ();
                        }
                        break;
                    default:
                        return;
                }
                if (this.Mana > mana)
                {
                    this.Mana -= mana;
                    switch (skillName)
                    {
                        case "Q":
                            {
                                ActionQ(targets);
                            }
                            break;
                        case "W":
                            {
                                ActionW(targets);
                            }
                            break;
                        case "E":
                            {
                                ActionE(targets);
                            }
                            break;
                        case "R":
                            {
                                ActionR(targets);
                            }
                            break;
                    }
                }


            }

        }
        public class HeroA : Hero
        {
            public HeroA() : base(100, 20) { }


            public override int ManaQ()
            {
                return 2;

            }
            public override void ActionQ(Hero[] targets)
            {
                foreach (Hero i in targets)
                {
                    i.Health -= 15;
                }
            }

            public override int ManaW()
            {
                return 3;
            }
            public override void ActionW(Hero[] targets)
            {
                this.Health = Math.Max(this.FullHealth, this.Health + 10);
                this.Mana = Math.Max(this.FullMana, this.Mana + 5);
            }

            public override int ManaE()
            {
                return 5;
            }
            public override void ActionE(Hero[] targets)
            {
                targets[0].Health -= 30;
            }

            public override int ManaR()
            {
                return 5;
            }

            public override void ActionR(Hero[] targets)
            {
                foreach (Hero i in targets) { i.Health -= 30; }
            }
        }
        public class HeroB : Hero
        {
            public HeroB() : base(80, 20) { }

            public override int ManaQ()
            {
                return 3;
            }
            public override void ActionQ(Hero[] targets)
            {
                foreach (Hero i in targets)
                {
                    i.Health -= 20;
                }
            }

            public override int ManaW()
            {
                return 3;
            }
            public override void ActionW(Hero[] targets)
            {
                if (targets.Length >= 1)
                {
                    targets[0].Health -= 10;
                    if (targets.Length >= 2)
                    {
                        targets[1].Health -= 10;
                    }

                }
            }

            public override int ManaE()
            {
                return 5;
            }
            public override void ActionE(Hero[] targets)
            {
                this.Health = Math.Max(this.Health + 20, this.FullHealth);
                this.Mana = Math.Max(this.Mana + 5, this.FullMana);
            }

            public override int ManaR()
            {
                return 0;
            }

            public override void ActionR(Hero[] targets)
            {
                targets[0].Health -= 50;
                this.Mana = this.FullMana;
            }
        }
        static void Main(string[] args)
        {
        }

    }

}



