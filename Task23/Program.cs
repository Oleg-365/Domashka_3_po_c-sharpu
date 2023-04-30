//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int n = Promt("Введите число N: ");
NumberTable(n);

int Promt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    int numN = Convert.ToInt32(value);
    return Math.Abs(numN);
}

void NumberTable(int n)
{
    int currentNumber = 1;
    int cube = 1;
    while (currentNumber <= n)
    {
        cube = currentNumber * currentNumber * currentNumber;
        Console.WriteLine(cube);
        currentNumber++;
    }
}