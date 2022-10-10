//  Напишите программу, которая найдёт точку пересечения двух прямых,
//   заданных уравнениями 
//   y = k1 * x + b1,
//    y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] array = new Double[2, 2];
FillArray(array);
CrossPoint(array);

void FillArray(double[,] matrixArray)
{
    Console.Write("Задай коэффициент k1 = ");
    matrixArray[0, 0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задай коэффициент b1 = ");
    matrixArray[0, 1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задай коэффициент k2 = ");
    matrixArray[1, 0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задай коэффициент b2 = ");
    matrixArray[1, 1] = Convert.ToInt32(Console.ReadLine());
}

void CrossPoint(double[,] matrixArray)
{  
    double x = Math.Round((matrixArray[1, 1] - matrixArray[0, 1]) / (matrixArray[0, 0] - matrixArray[1, 0]), 2);
    double y = Math.Round(matrixArray[0, 0] * x + matrixArray[0, 1], 2);

    Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y})");
}


