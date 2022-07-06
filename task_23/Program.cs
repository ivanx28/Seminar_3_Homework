// Программа, показывающая таблицу кубов от 1 до введённого числа N (включительно).

void cube (int number)
{
    double x = 1;
    int i = 1;
    while (i <= number)
        {
        x = Math.Pow(i, 3);
        Console.Write(x + "|");
        i++;
        }
}

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

cube(N);
Console.WriteLine();