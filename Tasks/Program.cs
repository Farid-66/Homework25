using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            /*1-dən 100-ə qədər ədədləri console-da çap edin;*/

            /*for(byte i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }*/

            //-------



            //Task2
            /*1-dən 100-ə qədər tək ədədləri console-da çap edin;*/

            /*for (byte i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }*/

            //-------




            //Task3
            /*User tərəfindən daxil edilmiş ədədin 2 mislini(2 - yə vurmaq) console - da çap edin;*/

            /*int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a * 2);*/

            //-------


            //Task4

            /*for (byte i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/

            //-------


            //Task5

            /*int sum = 0;
            for (byte i = 1; i <= 10; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);*/

            //-------



            //Task6

            /*Console.WriteLine("r");
            int r = Convert.ToInt32(Console.ReadLine());
            double l = 2 * Math.PI * r;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("l=" + l +  " S=" + s);*/

            //-------



            //Task7

            /*Console.WriteLine("Input first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input operator");
            string ope = Console.ReadLine();
            Console.WriteLine("Input second number");
            int second = Convert.ToInt32(Console.ReadLine());

            switch (ope)
            {
                case "+":
                    int sum = first + second;
                    Console.WriteLine(first + "+" + second + "=" + sum);
                    break;
                case "-":
                    int dif = first - second;
                    Console.WriteLine(first + "-" + second + "=" + dif);
                    break;
                case "*":
                    int multi = first * second;
                    Console.WriteLine(first + "*" + second + "=" + multi);
                    break;
                case "/":
                    int div = first / second;
                    Console.WriteLine(first + "/" + second + "=" + div);
                    break;
            }*/


            //-------



            //Task8

            /*Console.WriteLine("Enter the desired width");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            string str = "";
            string str1 = Console.ReadLine();

            for(int i = 0; i < num; i++)
            {
                for(int j = num; j > i; j--)
                {
                    str += str1;
                }
                str += "\n";
            }
            Console.WriteLine(str);*/

            //------



            //Task9

            /*byte count = 0;

            for(byte i = 0; i < 3; i++)
            {
                Console.WriteLine("User");
                string user = Console.ReadLine();
                Console.WriteLine("Password");
                string pass = Console.ReadLine();
                

                if(user == "ferid" && pass == "12345")
                {
                    Console.WriteLine("Siz girish etdiniz");
                    break;
                }
                else
                {
                    count++;
                    Console.WriteLine("User yada password yanlişdir");
                }
                if (count==3)
                {
                    Console.WriteLine("Sizin giriş ücün icazeniz yoxdur");
                    break;
                }
                
            }*/
            
            //--------

        }
    }
}
