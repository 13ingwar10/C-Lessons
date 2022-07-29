namespace Lesson_1
{
    class Homework
    {
        static void Main(string[] args)
        {
            //Решение задачи №2

            int a = 5;
            int b = 7;
            int max;

            if (a>b) 
                max = a;
            else 
                max = b;
            
            Console.WriteLine(max);

            //Решение задачи №4

            a = 2;
            b = 3;
            int c = 7;


            if (a>b)
                if (a>c)
                    max = a;
            else if (b>c)
                max = b;
            else max = c;

            Console.WriteLine(max);

            a=44;
            b=5;
            c=78;

                        if (a>b)
                if (a>c)
                    max = a;
            else if (b>c)
                max = b;
            else max = c;

            Console.WriteLine(max);

            a=22;
            b=3;
            c=9;

            if (a>b)
                if (a>c)
                    max = a;
            else if (b>c)
                max = b;
            else max = c;

            Console.WriteLine(max);

            //Решение задачи №6

            Console.Write("Введите число:");
            int number_1 = Convert.ToInt32(Console.ReadLine());
            if (number_1%2 == 0) {
                Console.WriteLine("Число чётное");
            }
            else {
                Console.WriteLine("Число нечётное");
            }

            //Решение задачи №8 (число на вход из задачи №6)

            int counter = 1;
            while (counter<number_1) {
                Console.Write(counter);
                Console.Write(", ");
                counter++;
            }
            Console.Write(number_1);
        }
    }
}
