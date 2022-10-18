/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
// Вводим координаты точки А (x,y,z)
Console.WriteLine("Введите координаты первой точки: ");
    double[] dot1=new double[3];
    Console.Write("X: ");
    dot1[0]=double.Parse(Console.ReadLine());
    Console.Write("Y: ");
    dot1[1] = double.Parse(Console.ReadLine());
    Console.Write("Z: ");
    dot1[2] = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
    double[] dot2 = new double[3];
    Console.Write("X:");
    dot2[0] = double.Parse(Console.ReadLine());
    Console.Write("Y:");
    dot2[1] = double.Parse(Console.ReadLine());
    Console.Write("Z:");
    dot2[2] = double.Parse(Console.ReadLine());

double x = Math.Pow((dot2[0] - dot1[0]), 2);
double y = Math.Pow((dot2[1] - dot1[1]), 2);
double z = Math.Pow((dot2[2] - dot1[2]), 2);
Console.WriteLine ($" Расстояние между точками А и В в 3D пространстве = {Math.Round(Math.Sqrt(x + y + z), 2)}");