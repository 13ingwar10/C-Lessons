/*
void Zadacha41() {
    Console.WriteLine("Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    int[] arr = CreateArray();
    PrintArray(arr);
    Console.WriteLine($"В вашем массиве {CountPositive(arr)} чисел больше 0");
    Console.WriteLine();
}

void Zadacha43() {
    Console.WriteLine("Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
    Console.WriteLine("Задайте через Enter коэффициенты b и k для первой прямой");
    double[] FirstStraight = CreateStraights();
    Console.WriteLine("Задайте через Enter коэффициенты b и k для второй прямой");
    double[] SecondStraight = CreateStraights();
    SolveEquation(FirstStraight, SecondStraight);
}

void SolveEquation(double[] arr1, double[] arr2){
    if (arr1[0] == arr2[0]) {
        Console.WriteLine("Эти прямые - параллельны");
    } else {
    double[] ArrayXY = new double[2];
    ArrayXY[0] = (arr2[1] - arr1[1]) / (arr1[0] - arr2[0]);
    ArrayXY[1] = arr1[0]*ArrayXY[0]+arr1[1];
    Console.WriteLine($"Прямые пересекутся в точке:({ArrayXY[0]};{ArrayXY[1]})");
    }
}

double[] CreateStraights() {
    double[] arr = new double[2];
    for (int i = 2; i > 0; i--) {
        arr[i-1] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

int[] CreateArray(){
    Console.WriteLine("Сколько чисел вы хотите ввести (укажите число не больше 10)?");
    int size = Convert.ToInt32(Console.ReadLine());
    while (size > 10) {
        Console.WriteLine("Ошибка! Введите число не больше 10:");
            size = Convert.ToInt32(Console.ReadLine());
    }
    int[] arr = new int[size];
    Console.WriteLine($"Отлично! Введите через Enter {size} чисел");
    for (int i = 0; i < size; i++) {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"Готово! Массив из {size} чисел сформирован:");
    return arr;
}

int CountPositive(int[] array) {
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) counter++;
    }
    return counter;
}

void PrintArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]}  ");
    }
    Console.WriteLine();
}

Zadacha41();
Zadacha43();
*/

void Zadacha47() {
    Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
    PrintArrayDouble(CreateUserArray());
    Console.WriteLine();
}

void Zadacha50() {
    Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    var rand = new Random();
    int[,] array = new int[rand.Next(0, 10),rand.Next(0, 10)];
    FillArray(array);
    CheckPosition(array);
    Console.WriteLine(); 
}

void Zadacha52() {
    Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    var rand = new Random();
    int[,] array = new int[rand.Next(2, 10),rand.Next(2, 10)];
    FillArray(array);
    CountAverage(array);
    Console.WriteLine(); 
}

void CountAverage(int[,] array) {
    int sum = 0;
    double average = 0;
    for (int i =0; i < array.GetLength(1); i++) {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++) {
            sum += array[j,i];
        }
        average = (double)sum/array.GetLength(0);
        Console.WriteLine(sum);
        Console.WriteLine($"Среднее арифметическое элементов столбца №{i+1} = {Math.Round(average, 2)}");
    }
    PrintArrayInt(array);    
}

void CheckPosition(int[,] array) {
    Console.WriteLine("Укажите номер строки:");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите номер столбца:");
    int column = Convert.ToInt32(Console.ReadLine());

    if  (row > array.GetLength(0)
            || column > array.GetLength(1)) {
                Console.WriteLine("Такого элемента нет в массиве, был сформирован такой массив:");
                PrintArrayInt(array);
        } else {
            Console.WriteLine("Значение этого элемента = " + array[row - 1, column - 1]);
            Console.WriteLine("был сформирован такой массив:");
            PrintArrayInt(array);            
        }
}

int[,] FillArray(int[,] array) {
    //Заполняем двумерный массив случайными числами от -10 до 10
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = rand.Next(0,21) - 10;
        }
    }
    
    return array;
}

double[,] CreateUserArray() {
    Console.WriteLine("Задайте число m - количество строк массива");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Задайте число n - количество колонок массива");
    int n = Convert.ToInt32(Console.ReadLine());

    //Фомируем массив вещественных чисел в диапазоне (-10; 10)
    Random rand = new Random();
    double[,] array = new double[m,n];
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            array[i,j] = rand.NextDouble()*15-10;
        }
    }  
    return array;  
}

void PrintArrayDouble(double[,] array) {
    Console.WriteLine("Выводим массив:");
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(Math.Round(array[i,j], 2) + "\t");
        }
        Console.WriteLine();
    }  
}

void PrintArrayInt(int[,] array) {
    Console.WriteLine("Выводим массив:");
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }  
}

Zadacha47();
Zadacha50();
Zadacha52();