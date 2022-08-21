void Zadacha10 () {
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    int first = 0;
    int second = 0;

    Console.WriteLine(number);
    first = number/100;
    second = (number - first*100)/10;
    Console.WriteLine(second);
}

void Zadacha13() {
    Random rand = new Random();
    int number = rand.Next(10, 10000);
    Console.WriteLine(number);

// Делаем проверку на наличие третьей цифры и превращаем любое число в трехзначное
    if (number/100 == 0) {
        Console.WriteLine("Третьй цифры нет");
    } else {
        while (number > 999) {
            number = number/10;
        }

// Получаем третью цирфу числа
    int first = number/100;
    int second = number - first*100;
    int third = second%10;
    Console.WriteLine(third);
    }

}

void  Zadacha15() {
    Random rand = new Random();
    int number = rand.Next(1,8);
    Console.WriteLine(number);

    if (number>5) {
        Console.WriteLine("Выходной день");
    } else Console.WriteLine("Будний день");
}

//Zadacha10();
//Zadacha13();
Zadacha15();