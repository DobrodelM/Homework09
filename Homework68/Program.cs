/*
Задача 68:
Задайте значения M и N.
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int getUserInt(string message)
{
    Console.Write(message);
    int userInt = Convert.ToInt32(Console.ReadLine());
    return userInt;
}
int AkkerFunc(int number1, int number2)
{

    if (number1 == 0)
    {
        return number2 + 1;
    }
    else if (number2 == 0 && number1 > 0)
    {
        return AkkerFunc(number1 - 1, 1);
    }
    else
    {
        return AkkerFunc(number1 - 1, AkkerFunc(number1, number2 - 1));
    }
}
int m = getUserInt("Введите число m ");
int n = getUserInt("Введите число n ");
int akkFunc = AkkerFunc(m, n);
Console.WriteLine($"Функция Аккермана А({m},{n}) равна {akkFunc}");
