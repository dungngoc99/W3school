using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TestProject2
{
    public class WareHouseTest
    {
        public RetailWareHouse sut; //System Under Test
        public WareHouseTest()
        {
            
        }


        [SetUp]
        public void Setup()
        {
            sut = new RetailWareHouse();
            sut.Import(10);
        }

        [TestCase(new int[] { 1, 5, 7 })]
        [TestCase(new int[] { 2, 3, 8 })]
        public void When_ImportData_Given_ImportQuantity_Then_IncreaseQuantityOfWareHouse(int[] importQuantity)
        {
            foreach(var q in importQuantity)
            {
                sut.Import(q);
            }

            var expected = importQuantity.Sum() + 10;


            Assert.AreEqual(expected, sut.Quantity);


            //var wareHouse = new BaseWareHouse();
            //wareHouse = new RetailWareHouse();


            //var wareHouse2 = new RetailWareHouse();
            //wareHouse2 = new BaseWareHouse();

            var hs = new List<BaseWareHouse>();

            hs.Add(new RetailWareHouse());
            hs.Add(new RetailWareHouse2());

            foreach(var h in hs)
            {
                h.Import(1);
            }
        }
    }
}