using System;

namespace _4.ConditionExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------Booleans ------------//
            bool isCSharpFun = true;
            bool isFishFly = false;
            Console.WriteLine(isCSharpFun);//true
            Console.WriteLine(isFishFly);//false
            Console.WriteLine(Environment.NewLine);

            //-----------Booleans to comparision-----------//
            int x = 10;
            int y = 9;
            Console.WriteLine($"Is x > y ? {x > y}");//true
            Console.WriteLine($"Is x = 10? {x == y}");//false
            Console.WriteLine(Environment.NewLine);

            //---------Short hand if...else---------//
            // variable = (condition) ? expressionTrue : expressionFalse
            int time = 20;
            string result = (time < 18) ? "Good day" : "Good evening"; 
            Console.WriteLine(result); //Good evening
            Console.WriteLine(Environment.NewLine);

            //--------Switch case------------//
            //break: will out of the expression when the answer was founded
            //default: to specifies some code to run if these is no case match
            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Today is Friday");
                    break;
                case 7:
                    Console.WriteLine("Today is Satuday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the weekend");
                    break;              
            }
            Console.WriteLine(Environment.NewLine);

            //---------------While loop---------------//
            //Nếu (đk) thì (kq)
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            } //0 1 2 3 4

            //------------- Do... while --------//
            int k = 0;
            do {
                Console.WriteLine(k);
                k++;
            }
            while (k < 1); //0
            Console.WriteLine(Environment.NewLine);

            //--------------For ---------------//
            for (int a= 0; a <=10; a += 2)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine(Environment.NewLine);

            //--------------Nested loop-------------//
            for (int m = 1; m <= 2; ++m)
            {
                Console.WriteLine($"Outer: {m}");
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"Inner: {j}");
                }
            }// 1 1 2 3 2 1 2 3
            Console.WriteLine(Environment.NewLine);

            //-------------countinue------------//
            //Skip the answer when it match the keyword
            for (int n = 0; n <=5; n++)
            { if (n == 3) 
                {
                    continue; 
                }
                Console.WriteLine(n); 
            } //0 1 2 4 5
            Console.WriteLine(Environment.NewLine);

            Console.Read();

        }
    }
}
