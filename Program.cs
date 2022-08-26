void Zadacha19() {

    int[] array = new int[5];
    Random rand = new Random();
    int number = rand.Next(10000, 100000);
 //   int number = 53835;
    Console.WriteLine(number);

    array[0] = number/10000;
    array[1] = (number/1000)%10;
    array[3] = (number%100)/10;
    array[4] = number%10;

    if (array[0]==array[4] && array[1]==array[3]) {
        Console.WriteLine("Число - палиндром");
    } else Console.WriteLine("Число - не палиндром");

}

void Zadacha21() {
    double distance = 0;

    double[] dot_one = new double[3];
    double[] dot_two = new double[3];

    Random rand = new Random();

    for (int i=0; i<dot_one.Length; i++) {
        dot_one[i] = rand.Next(-99, 100);
        dot_two[i] = rand.Next(-99, 100);
    }

    Console.WriteLine($"Первая точка: {dot_one[0]}, {dot_one[1]}, {dot_one[2]}");
    Console.WriteLine($"Вторая точка: {dot_two[0]}, {dot_two[1]}, {dot_two[2]}");

    distance = Math.Pow((Math.Pow(dot_one[0]-dot_two[0],2) + Math.Pow(dot_one[1]-dot_two[1], 2) + Math.Pow(dot_one[2]-dot_two[2], 2)), 0.5);

    Console.WriteLine($"Расстояние между точками = {distance}");

}

void Zadacha23() {

    Random rand = new Random();
    int number = rand.Next(1, 10);
    int square = 0;

    Console.WriteLine($"Число: {number}");

    for (int i = 1; i<=number;i++) {
        if (i == number) {
            square = i*i*i;
            Console.WriteLine(square);
        } else {
            square = i*i*i;
            Console.Write($"{square}, ");
        }
    }
}

//Zadacha19();
//Zadacha21();
Zadacha23();
