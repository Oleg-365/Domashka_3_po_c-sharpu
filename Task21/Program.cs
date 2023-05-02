//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int Promt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine()!);
    int coord = Convert.ToInt32(value);
    return coord;
}

int x1 = Promt("Введите координату Xa: ");
int y1 = Promt("Введите координату Ya: ");
int z1 = Promt("Введите координату Za: ");

int x2 = Promt("Введите координату Xb: ");
int y2 = Promt("Введите координату Yb: ");
int z2 = Promt("Введите координату Zb: ");


FindLength(x1, y1, z1, x2, y2, z2);

double FindLength(int xa, int ya, int za, int xb, int yb, int zb)
{
    double result = Convert.ToDouble(Math.Round(Math.Sqrt(((xb-xa)*(xb-xa))+((yb-ya)*(yb-ya))+((zb-za)*(zb-za))),3));
    Console.Write(result);
    return result;
}

