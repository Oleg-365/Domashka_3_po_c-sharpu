//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int Promt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    int numberN = Convert.ToInt32(value);
    return Math.Abs(numberN);
}

int n = Promt("Введите пятизначное число: ");

Palindrome(n);

int Palindrome(int n)
{
    int temp = n;
    int revers = 0;

    while (n > 0)
    {
        revers = (revers * 10) + (n % 10);
        n = (n / 10);
        Console.Write("Число с цифрой в обратном порядке: " + revers);
    }
    return n;
}


