// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Main();

void Main()
{
    int number = Promt("Введите чсло, входящее в диапазон типа int: ");
    // третьей цифры нет в том случае, если число двухзначное
    if (number < 100 && number > -100)
    {
        Console.WriteLine("Число двухзначное, в нём нет третьей цифры");
    }
    else
    {
        FindThirdDigit(number);
    }
}

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return Math.Abs(result);
}

int FindThirdDigit(int num)
{
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine("Третья цифра введённого числа: " + num);
    }
    return num;
}