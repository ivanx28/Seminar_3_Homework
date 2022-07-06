// Программа которая определяет является ли введённое число палиндромом.
// Также данная программа работает для числа из любого количества цифр.


int doubleNumber (int x)                //Данным метод переворачивает введённое число "задом наперёд".
{
    int num1 = 0;
    int numDouble = 0;
    while (x > 0)
    {
        num1 = x % 10;
        numDouble = numDouble*10+num1;
        x = x / 10;
    }
    return numDouble;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int numberDouble = doubleNumber(number);

if (number == numberDouble) Console.WriteLine("Введённое число является палиндромом");
else Console.WriteLine("Введённое число не является палиндромом");



