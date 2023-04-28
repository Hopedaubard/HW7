// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Main();

void Main()
{
    int weekDayNum = Promt("Введите число, обозначающее день недели: ");
    bool checkDay = ValideWeekDay(weekDayNum);
    if (checkDay == true)
    {
        CheckWeekEnd(weekDayNum);
    }
    else
    {
        Console.WriteLine("Это не день недели");
    }
}

bool ValideWeekDay(int num)
{

    if (num > 0 && num <= 7)
    {
        return true;
    }
    else
    {
        return false;
    }

}

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void CheckWeekEnd(int weekDay)
{
    if (weekDay == 6 || weekDay == 7)
    {
        Console.WriteLine("Отдыхай, выходной!");
    }
    else
        Console.WriteLine("Работаем, скоро выходные!");
}