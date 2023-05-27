using System;
using System.Linq;
namespace _5.Araray
{
    class Program
    {
        static void Main(string[] args)
        {   //------- Array---------//
            //Creat an array without specifying the size
            //string[] cars = { "volvo", "BMW", "Ford", "Mazda" };

            //Creat an array of 4 element, add the value later
            //int[] myNums = new int[4];
            //myNums = new int[4] { 1, 2, 3, 4 };

            //Creat an array of 4 element and add the value right way
            //int[] numbers = new int[4] { 10, 20, 30, 40 };

            //Creat an array , include the "new" keyword and not specifying the size
            //string[] colors = new string[] { "red", "green", "yellow" };


            //Count length of an array
            //Console.WriteLine(myNums.Length);

            //foreach in an array
            string[] cars = { "volvo", "BMW", "Ford", "Mazda" };
            foreach(string i in cars)
            {
                Console.WriteLine(i); //volvo BMW Ford Mazda
            }

            //Sort a string
            int[] colors = { 9, 2, 1, 5 };
            Array.Sort(colors);
            foreach(int i in colors)
            {
                Console.WriteLine(i); //1 2 5 9
            }
            Console.WriteLine(Environment.NewLine);
            //Use System.Linq:
            //To use method such as: Min, Max. Sum
            Console.WriteLine(colors.Max()); //9
            Console.WriteLine(colors.Min()); //1
            Console.WriteLine(colors.Sum()); //17
            Console.WriteLine(Environment.NewLine);

            //2-dimention array
            int[,] myNum = { { 1, 4, 5 }, { 3, 8, 7 },{ 6, 0, 9 } };

            //To access 2D array: arr[row, column]
            Console.WriteLine(myNum[2, 2]); //9
            Console.WriteLine(Environment.NewLine);

            //To change an element in 2D array: arr[column,row] = value;
            Console.WriteLine(myNum[1, 2] = 8);// 7 -> 8
            Console.WriteLine(Environment.NewLine);

            //Look through a 2D array
            int[,] numbers = { { 1, 4, 5 }, { 3, 8, 7 },{ 2, 5, 0 } };

            for (int i = 0; i< numbers.GetLength(0)/*=2*/; i++)
            {
                for(int j = 0; j<numbers.GetLength(1)/*=3*/; j++)
                {
                    Console.WriteLine(numbers[i, j]);//1 4 5 3 8 7

                }
            }
            Console.Read();
        }
    }
}
