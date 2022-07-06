// Программа для поиска расстояния между двумя точками в 3D пространстве.

double distance3D (int dot11, int dot12, int dot13, int dot21, int dot22, int dot23)
{
    double square1 = Math.Pow ((dot21-dot11), 2);
    double square2 = Math.Pow ((dot22-dot12), 2);
    double square3 = Math.Pow ((dot23-dot13), 2);
    double distance = Math.Round ( (Math.Sqrt (square1 + square2 + square3)), 2);      //Можно записать всё в одну строку (без отдельного возведения в квадраты), но так более читаемо.
    return distance;
}

Console.WriteLine("Введите координаты первой точки по трём осям:");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки по трём осям:");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между двумя введёнными точками: " + distance3D(x1, y1, z1, x2, y2, z2));