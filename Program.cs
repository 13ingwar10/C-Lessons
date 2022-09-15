void Zadacha34() {
    Console.WriteLine("Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");
    Console.WriteLine("Формируем массив:");
    int[] array = new int[10];
    FillArray(array, 100, 1000);
    PrintArray(array);
    CountEven(array);
    Console.WriteLine();
}

void Zadacha36() {
    Console.WriteLine("Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("Формируем массив:");
    int[] array = new int[10];
    FillArray(array, 0, 10);
    PrintArray(array);
    SumUneven(array);
    Console.WriteLine();
}

void Zadacha38() {
    Console.WriteLine("Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    Console.WriteLine("Формируем массив:");
    double[] array = new double[10];
    FillArrayDouble(array);
    PrintArrayDouble(array);
    Sum(array);
    Console.WriteLine();
}

void FillArrayDouble(double[] arr) {
    // Массив заполняется числами double от -10 до 10. Параметр k определяет будет элемент массива со знаком "+" или "-", поскольку NextDouble выдает только положительные числа.
    Random rand = new Random();
    int k;
    for (int i = 0; i < arr.Length; i++) {
        k = 0;
        while (k == 0) {
            k = rand.Next(-1, 2);
        }
        arr[i] = rand.NextDouble()*10*k;
    }
}

void Sum(double[] arr){
    double substraction = arr[0] + arr[arr.Length-1];
    Console.WriteLine($"Cумма первого и последнего элементов массива = {Math.Round(substraction, 2)}");
}

void PrintArrayDouble(double[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{Math.Round(arr[i], 2)}; ");
    }
    Console.Write("\b\b");
    Console.WriteLine();
}

void SumUneven(int[] arr) {
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i+2) {
        sum += arr[i];
    }
    Console.WriteLine($"Сумма чисел на нечетных позициях массива = {sum}");
}

void CountEven(int[] arr) {
    int counter = 0;
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i]%2 == 0){
            counter +=1;
        }
    }
    Console.WriteLine($"В заданном массиве четных чисел = {counter}");
}

void FillArray(int[] arr, int min = -100, int max = 101) {
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = rand.Next(min, max);
    }
}

void PrintArray(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b");
    Console.WriteLine();
}

Zadacha34();
Zadacha36();
Zadacha38();