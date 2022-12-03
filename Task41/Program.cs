//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


using static System.Console;
Clear();

Write("Введите количество чисел: ");
int NumberOfNumbers = int.Parse(ReadLine()!);
int count = 0;
for (int i = 0; i < NumberOfNumbers; i++) 
{
    Write($"Введите число {i + 1}: ");
    int TheNumberEntered = int.Parse(ReadLine()!);
    if (TheNumberEntered > 0)
        count += 1;
}
Console.WriteLine($"Чисел больше 0: {count}");