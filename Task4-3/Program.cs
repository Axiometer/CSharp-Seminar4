// Напишите программу, которая задаёт массив из любого количсества элементов и выводит их на экран. Сделать через функции

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int length = GetValue("Введите количество элементов массива: ");
int min = GetValue("Введите минимальное возможное число в массиве: ");
int max = GetValue("Введите максимальное возможное число в массиве: ");

bool CheckNumbers(int min, int max, int length)
{
    if (max <= min || length == 0)
    {
        Console.WriteLine("Максимальное значение должно быть больше минимального, а количество элементов в массиве не может быть равно 0");
        return false;
    }
    return true;
}

int[] SetArray(int length)
{
    int[] tempArr = new int[length];
    for (int i = 0; i < length; i++)
        tempArr[i] = new Random().Next(min, max);
    
    return tempArr;
}

void WriteArrayToConsole(int[] intArray)
{
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write(intArray[i]);
        if (i != intArray.Length-1)
            Console.Write(", ");
    }
}

if (CheckNumbers(min, max, length))
{
    Console.Write("Получившийся массив: ");
    WriteArrayToConsole(SetArray(length));
}