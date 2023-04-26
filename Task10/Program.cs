// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Main();

void Main()
{
    int number = GetRandNumThrSign();
    int midDigit = (number / 10) % 10;
    Console.WriteLine("Found second digit:" + midDigit);
}

int GetRandNumThrSign()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Random number: " + rand);
    return rand;
}