using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public abstract class BaseWareHouse
    {
        public int Quantity { get; private set; }
        public void Import(int number)
        {
            this.Quantity += number;
            this.ExtraImport(number);
        }
        public void Export (int number)
        {
            this.Quantity -= number;
            this.ExtraExport(number);
        }

        public abstract void ExtraImport(int number);
        public abstract void ExtraExport(int number);
    }

    public class RetailWareHouse : BaseWareHouse
    {
        public override void ExtraExport(int number)
        {
           
        }

        public override void ExtraImport(int number)
        {
            //gui email cho thu kho
        }
    }

    public class RetailWareHouse2 : BaseWareHouse
    {
        public override void ExtraExport(int number)
        {
        }

        public override void ExtraImport(int number)
        {
            //gui email cho thu kho
        }
    }
}
