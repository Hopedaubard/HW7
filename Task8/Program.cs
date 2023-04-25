// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Main();

void Main()
{
    int N = GetRandNumber();
    Console.WriteLine("Случайное число: " + N);
    if (N < 1)

    {
        int num = 0;
        while (num > N)
        {
            Console.Write(num + " ");
            num = num - 2;
        }
    }
    else
    if (N > 1)
    {
        int num = 2;
        while (num < N)
        {
            Console.Write(num + " ");
            num = num + 2;
        }
    }
}

int GetRandNumber()
{
    int rand = new Random().Next(-100, 101);
    return rand;
}