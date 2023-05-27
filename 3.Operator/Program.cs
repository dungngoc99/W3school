using System;

namespace _3.Operator
{
    class Program
    {
        static void Main(string[] args)
        {   //-------------Nối chuỗi------------------//
            string txt = "sgshshbgfshbgfhgfh";
            Console.WriteLine(txt.ToUpper()); //In hoa
            Console.WriteLine(txt.ToLower()); //Viết thường
            Console.WriteLine(Environment.NewLine);
            string firstName = "Dung ";
            string lastName = "Trinh";
            //C1. Nối chuỗi bằng concat
            string name = string.Concat(firstName,lastName);
            Console.WriteLine(name);
            //C2. Nối chuỗi bằng phép "+"
            Console.WriteLine(firstName + lastName);
            //C3. Nối chuỗi gọn:
            Console.WriteLine($"My fullname is: {firstName}{lastName}");
            Console.WriteLine(Environment.NewLine);

            //--------------Access strings--------------//
            string greeting = "Hello";
            Console.WriteLine(greeting[0]); //H
            Console.WriteLine(greeting.IndexOf("l")); //2
            Console.WriteLine(Environment.NewLine);

            //-----------------Substring-----------------//
            //fullname
            string user = "Dung Trinh";
            //location of the letter T
            int charPos = user.IndexOf("T");
            //Get substring to return a new string, begin from value of IndexOf
            Console.WriteLine(user.Substring(charPos)); //Trinh
            Console.WriteLine(Environment.NewLine);

            //-----------Kí tự đặc biệt----------//
            //string text = "I'm used to call "Dungheo" in my family"; -> Sai
            //Dùng \'text\' để được 'text'
            //Dùng \"text\'" để được "text"
            //Dùng \\text\\ để được \text\
            Console.WriteLine("I'm used to called \"Dungheo\" in my family"); //I'm used to call "Dungheo" in my family
            Console.WriteLine("I'm used to called \'Dungheo\' in my family"); //I'm used to call 'Dungheo' in my family
            Console.WriteLine("I'm used to called \\Dungheo\\ in my family"); //I'm used to call \Dungheo\ in my family
            Console.WriteLine("It's all right"); //It's all right




        }
    }
}
