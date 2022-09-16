void Zadacha41() {
    Console.WriteLine("Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    int[] arr = CreateArray();
    PrintArray(arr);
    Console.WriteLine($"В вашем массиве {CountPositive(arr)} чисел больше 0");
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
    double[] ArrayXY = new double[2];
    ArrayXY[0] = (arr2[1] - arr1[1]) / (arr1[0] - arr2[0]);
    ArrayXY[1] = arr1[0]*ArrayXY[0]+arr1[1];
    Console.WriteLine($"Прямые пересекутся в точке:({ArrayXY[0]};{ArrayXY[1]})");
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