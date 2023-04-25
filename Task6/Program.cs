// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Main();

void Main()
{
    int num = GetRandNumber();
    Console.WriteLine(num);
    if (num % 2 == 0)
    {
        Console.WriteLine("Число чётное");
    }
    else
    {
        Console.WriteLine("Число нечётное");
    }
}

int GetRandNumber()
{
    int rand = new Random().Next(-100, 101);
    return rand;
}
