/* Задача 64:
Задайте значение N.
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write(message);
    Console.ResetColor();
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
int StartIndex = getUserInt("Введите число N = ");

string printRange(int number)
{
    if (number != 0)

        return $"{number}, " + printRange(number - 1);

    else
        return String.Empty;
}
Console.WriteLine(printRange(StartIndex));
