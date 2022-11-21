// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void SearchIntersection(double b1, double k1, double b2, double k2)
{
    if (b1 / k1 == b2 / k2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        if (k1 == k2 && b1 != b2)
        {
            Console.WriteLine("Прямые не пересекаются");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x - b1;
            Console.WriteLine($"Прямые пересекаются в точке : Х({x}), Y({y})");
        }
    }
}
Console.WriteLine("Для прямых Y = k*X + b");
Console.WriteLine("Введите коэффициент b1 :");
double B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1 :");
double K1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2 :");
double B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2 :");
double K2 = Convert.ToInt32(Console.ReadLine());

SearchIntersection(B1, K1, B2, K2);
Console.ReadKey();
