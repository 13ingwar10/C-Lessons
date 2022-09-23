void Zadacha64() {
    Console.WriteLine("Задача 64. Задайте значения M и N. Напишите рекурсионный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.");
    Console.WriteLine("Введите число М от 0 до 100:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N от 0 до 100:");
    int n = Convert.ToInt32(Console.ReadLine());

    while (n > m) {
        Console.WriteLine("Ошибка! Число N < M");
        Console.WriteLine("Введите число М от 0 до 100:");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N от 0 до 100:");
        n = Convert.ToInt32(Console.ReadLine());       
    }
    
    PrintNumbers(m,n);
    Console.WriteLine();   
}

void Zadacha66() {
    Console.WriteLine("Задача 66. Задайте значения M и N. Напишите рекурсионный метод, который найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("Введите число М от 0 до 100:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N от 0 до 100:");
    int n = Convert.ToInt32(Console.ReadLine());

    while (n > m) {
        Console.WriteLine("Ошибка! Число N < M");
        Console.WriteLine("Введите число М от 0 до 100:");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число N от 0 до 100:");
        n = Convert.ToInt32(Console.ReadLine());       
    }

    Console.WriteLine("Сумма элементов диапазона равна " + SumOfNumbers(m, n));
    Console.WriteLine(); 
}

void Zadacha68() {
    Console.WriteLine("Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    
    Console.WriteLine("Введите число М от 0 до 4:");
    int m = Convert.ToInt32(Console.ReadLine());
    while (m < 0 || m > 4) {
        Console.WriteLine("Ошибка! Введите число М от 0 до 4:");
        m = Convert.ToInt32(Console.ReadLine());
    }
    
    Console.WriteLine("Введите число N от 0 до 4:");
    int n = Convert.ToInt32(Console.ReadLine());
    while (n < 0 || n > 4) {
        Console.WriteLine("Ошибка! Введите число N от 0 до 4:");
        n = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Значение функции Аккермана = " + A(m, n));
}

int A(int m, int n) {
    if (m == 0) return n++;
    if (m > 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return A(m, n);
}

void PrintNumbers(int m, int n) {
    if (m > n) return;
    if (m%3 == 0) {
        Console.Write(m + " ");
        m = m + 3;
    } else m++;
    PrintNumbers(m,n);
}

int SumOfNumbers(int m, int n, int sum = 0, int counter = 0) {
    if (m+counter > n) return sum;
    sum += m + counter;
    counter++;
    return SumOfNumbers(m, n, sum, counter);
}

Zadacha64();
Zadacha66();
Zadacha68();