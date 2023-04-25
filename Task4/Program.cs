// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Main();

void Main()
{
    int num_1 = GetRandNumber();
    int num_2 = GetRandNumber();
    int num_3 = GetRandNumber();
    Console.Write(num_1 + ", ");
    Console.Write(num_2 + ", ");
    Console.Write(num_3 + " ");
    Console.Write("-> " + FindMaxNumBetwThree(num_1, num_2, num_3));

}

int GetRandNumber()
{
    int rand = new Random().Next(0, 100);
    return rand;
}

int FindMaxNumBetwThree(int a, int b, int c)
{
    int max = -1;
    if (a >= b && a >= c)
    {
        max = a;
        //Console.WriteLine("max = " + max);
    }
    if (b >= a && b >= c)
    {
        max = b;
        //Console.WriteLine("max = " + max);
    }
    if (c >= a && c >= b)
    {
        max = c;
        //Console.WriteLine("max = " + max);
    }
    else if (max == -1)
    {
        Console.WriteLine("Логическа ошибка!");
    }

    return max;
}