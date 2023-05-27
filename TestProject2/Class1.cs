using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    class Hero
    {
        //public int ;


        public virtual void BtnQ() { }
        public virtual void BtnE() { }
        public virtual void BtnR() { }
        public virtual void BtnW() { }
        public void Cast(string skillName, string targets) 
        {
            

        }



    }

    class HeroA : Hero
    {
        //HeroA.Maxhealth = 100;
    }
    class Program
    {
        static void Main(string[]args)
        {         

        }
    }
       

        
}
