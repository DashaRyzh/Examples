// int[] arr = new int[10];

// int index = 0;
// while(index < 10)
// {
//     Console.Write($"{arr[index++]} ");

// }




// void DrawRectangle(int posX, int posY, int width, int height)
// {
//     int row = 0;
//     while(row < height)
//     {
//         Console.SetCursorPosition(posX, posY + row);
//         int count = 0;
//         while(count < width)
//         {
//             Console.Write("+");
//             count++;
//         }
//     row++;
//     }
// }
// Console.Clear();
// DrawRectangle(13, 5, 5, 5);

// Нужно написать программу решения квадратных уравнений
// Ax^2 + Bx + C = 0
// 1x^2 - 2x + 6 = 0
(double, double) Solve(double a, double b, double c)
{
    double d = b * b - 4 * a * c;
    Console.WriteLine(d);
    if (d < 0)
    {
        return (double.NaN, double.NaN);
        // Console.WriteLine("Действительных корней нет.");
    }
    else
    {
        double x1 = (-b + Math.Sqrt(d))/(2*a);
        double x2 = (-b - Math.Sqrt(d))/(2*a);
        return(x1, x2);
        // Console.WriteLine(x1);
        // Console.WriteLine(x2);
    }
}
Solve(1, -7, 6);
Solve(1, 0, 6);
Solve(1, 0, -4);
Solve(1, 2, -4);