void Zadacha54() {
    Console.WriteLine("Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    var rand = new Random();
    int[,] array = new int[rand.Next(2, 10),rand.Next(2, 10)];
    FillArray(array);
    PrintArrayInt(array);
    Console.WriteLine("Сортируем элементы строк max -> min");  
    SortMaxToMin(array);
    PrintArrayInt(array);
    Console.WriteLine();   
}

void Zadacha56() {
    Console.WriteLine("Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    var rand = new Random();
    int[,] array = new int[rand.Next(2, 10),rand.Next(2, 10)]; 
    FillArray(array);
    Console.WriteLine("Был сформирован следующий массив:");
    PrintArrayInt(array);   
    FindLessLine(FindSumsOfLines(array));
    Console.WriteLine();  
}

void Zadacha58() {
    Console.WriteLine("Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.");
    Console.WriteLine("Введите число Х от 2 до 10. Будет сформирован массив размерности X*X");
    int size = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[size,size];
    FillSpiral(array);
    PrintArrayInt(array);
    Console.WriteLine();  
}

void FillSpiral(int[,] array) {
    int x = 0;
    int y = 0;

    array[x,y] = 1;
    for (int counter = 2; counter < array.GetLength(0)*array.GetLength(1)+1; counter++) {
        if (StepRight(array, x, y) == true) {
            y++;
            array[x,y] = counter;
        } else if (StepDown(array, x, y) == true) {
            x++;
            array[x,y] = counter;
        } else if (StepLeft(array, x, y) == true) {
            y--;
            array[x,y] = counter;
        } else {
            array[x - 1, y] = counter;
            x--;
            while (array[x - 1, y] == 0) {
                x--;
                counter++;
                array[x,y] = counter;
            }
        }
    }    
}

bool StepRight(int[,]array, int x, int y) {
    if (y + 1 < array.GetLength(1) && array[x, y + 1] == 0) return true;
    else return false;
}

bool StepDown(int[,]array, int x, int y) {
    if (x + 1 < array.GetLength(0) && array[x + 1, y] == 0) return true;
    else return false;
}

bool StepLeft(int[,]array, int x, int y) {
    if (y - 1 >= 0 && array[x, y - 1] == 0) return true;
    else return false;
}

int[] FindSumsOfLines(int[,] array) {
    int[] sums = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) {
            sum += array[i,j];
        }
        sums[i] = sum;
    }
    return sums;
}

void FindLessLine(int[] array) {
    int min = array[0];
    int position = 0;
    for (int i = 1;i < array.Length; i++ ) {
        if (array[i] < min) {
            min = array[i];
            position = i;
        }            
    }
    Console.WriteLine($"Наименьшая сумма элементов в строке №{position + 1} = {array[position]}");
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

void PrintArrayInt(int[,] array) {
    Console.WriteLine("Выводим массив:");
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }  
}

int[,] SortMaxToMin(int[,] array) {
    int[] line = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            line[j] = array[i,j];
        }
        SortLine(line);
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = line[j];
        }
    }
    return array;
}

int[] SortLine(int[] array) {
    int max = array[0];
    int temp = array[0];
    int position = 0;
    for (int i = 0; i < array.Length; i++) {
        max = array[i];
        temp = array[i];
        position = i;
        for (int j = i + 1;j < array.Length; j++ ) {
            if (array[j] > max) {
                max = array[j];
                position = j;
            }            
        }
        array[i] = max;
        array[position] = temp;
    }
    return array;
}

Zadacha54();
Zadacha56();
Zadacha58();