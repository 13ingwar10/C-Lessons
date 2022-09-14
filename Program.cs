int Zadacha25(int number, int degree) {

    // Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
    int result = number;

    for (int i = 1; i < degree; i++) {
        result *= number;
    }

    return result;
}

int Zadacha27(int number) {

    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    int sum = 0;
    while (number > 0) {
        sum = sum+number%10;
        number = number/10;
    }

    return sum;
}

void Zadacha29() {
    int length = 8;
    int[] arr = new int[length];
    Random rand = new Random();

    
    Console.WriteLine("Выведем стартовый массив:");
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = rand.Next(-100, 101);
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();

    Console.WriteLine("Выведем отсортированный массив:");
    int min = arr[0];
    int bar = arr[0];
    int index = 0;

    for (int i = 0; i < arr.Length - 1; i++) {
        min = arr[i];
        bar = arr[i];
        index = i;
        for (int j = i + 1; j < arr.Length; j++) {
            if (Math.Abs(arr[j]) < Math.Abs(min)) {
                min = arr[j];
                index = j;
            }
        }
        arr[i] = min;
        arr[index] = bar;
    }

    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]}, ");
    }

}


Console.WriteLine("Начинаем выполнение задачи №25 - Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.");
Console.WriteLine("Введите число A");
int number = Convert.ToInt32(Console.ReadLine());
while (number <=0) {
    Console.WriteLine("Ошибка! Вы должны ввести натуральное число");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите степень B");
int degree = Convert.ToInt32(Console.ReadLine());
while (degree <=0) {
    Console.WriteLine("Ошибка! Вы должны ввести натуральное число");
    degree = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Ответ на задачу №25 = " + Zadacha25(number, degree));
Console.WriteLine();

Console.WriteLine("Начинаем выполенение задачи №27 - Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
Zadacha27(number1);
Console.WriteLine("Ответ на задачу №27 = " + Zadacha27(number1));
Console.WriteLine();

Console.WriteLine("Начинаем выполенение задачи №29 - Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.");
Zadacha29();