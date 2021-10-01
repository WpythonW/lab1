using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пункт 1");   //пункт 1
            returning.func1(1, 4);
            Console.WriteLine("Возвращает значение, мы выводим:");
            Console.WriteLine(returning.func2(1, 4));

            Console.WriteLine("Пункт 2");   //пункт 2
            returning obect1 = new returning("Hi");
            obect1.say();

            Console.WriteLine("Пункт 3");   //пункт 3
            returning hello = new returning("hello");
            returning goodmorning = new returning("Good morning");
            hello.say();
            goodmorning.say();


        }

    }

    class returning
    {
        private string line = "";

        public returning(string S)
        {
            line = S;
        }

        public void say()
        {
            Console.WriteLine(line);
        }

        public static void func1(int a, int b)
        {
            Console.WriteLine("Выводит сумму, не возвращает значение:");
            Console.WriteLine(a + b);
        }

        public static int func2(int a, int b)
        {
            int res = a + b;
            return res;
        }
    }
}
