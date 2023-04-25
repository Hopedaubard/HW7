// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Main();

void Main()
{
    int num1 = GetRandNumber(); // Создаём первое случайное число
    int num2 = GetRandNumber(); // Создаём второе случайное число
    Console.WriteLine("1-е число: " + num1);
    Console.WriteLine("2-е число: " + num2);
    if (num1 > num2)
    {
        Console.WriteLine("Первое число больше второго");
    }
    else if (num2 > num1)
    {
        Console.WriteLine("Второе число больше первого");
    }
    else if (num1 == num2)
    {
        Console.WriteLine("Числа равны");
    }
}

int GetRandNumber()
{
    int rand = new Random().Next(0, 100);
    // Console.WriteLine(rand);
    return rand;
}
