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
    return numberN;
}

int n = Promt("Введите пятизначное число: ");

Palindrome(n);                                             //Вызов метода

int Palindrome(int n)                                       //Сам метод
{
    int temp = n;                                           // Ввод новой переменной temp
    int revers = 0;                                         // Ввод новой переменной revers

    while (n > 0)                                        //Переворачиваем число в обратном порядке
    {
        revers = (revers * 10) + (n % 10);
        n = (n / 10);
                                                          //Console.WriteLine("Число с цифрой в обратном порядке: " + revers);
    }
    if (temp==revers)                                       //Сравнение
        {
            Console.WriteLine("Это палиндром!");
        }
    else
        {
        Console.WriteLine("Это не палиндром!");
        }
    return n;
}

