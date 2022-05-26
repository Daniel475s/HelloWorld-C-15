using System;

namespace LearningCsharp
{
    class Program
    {
        static void Main(string[] args) 
        {

            int x = 10;
            decimal d = 1.32m; // Utilizado para calculos financeiros (Moeda)
            double d2 = 1.48; // Utilizado para calculos científicos e medições 
            float f = 16.87f; // Engines e jogos como o Unity devido a performance 

            int y = x + 2;

            string s = " Olá";
            s += " Mundo!";

            int[] a = new int[] {2,6,9};

            int result = 0;
           foreach (int number in a) 
            {
                result += number;
            }

            Test t = new Test();
            t.name = "Soares";
            string hello = t.SayHello();

            if (t.name == "Daniel")
            {
                Console.WriteLine("Verdadeiro");
            }
            else if (t.name == "Soares")
            {
                Console.WriteLine("Hey!");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            Console.WriteLine(hello);
            Console.ReadKey();
        }

    }

    class Test
    {
        public string name;

        public string SayHello()
        {
            return "Olá " + name;
        }
    }

}        