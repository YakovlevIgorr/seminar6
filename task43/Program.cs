// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



Console.WriteLine("Введите количество чисел ");
int number = Convert.ToInt32(Console.ReadLine());
int [] arry = new int[number];

void fillArry()// 
{
    for(int i = 0;i < arry.Length; i++)
{
    Console.WriteLine("Введите число " + (i + 1) + " ");
    int numbers = Convert.ToInt32(Console.ReadLine());
    arry[i] = numbers;
}
}

int countPositive(int [] array)
{
    int count = 0;
    for(int k = 0; k < array.Length; k++)
    {
        if(array[k] > 0) count ++;
    }
    return count;
}

void printArray(int [] totalArray)
{
    System.Console.WriteLine($"[{string.Join(",",arry)}] --> {countPositive(arry)}");
}

fillArry();
printArray(arry);