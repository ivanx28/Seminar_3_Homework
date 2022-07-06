// Программа которая определяет является ли введённое пятизначное число палиндромом.
// простой способ, работающий только для пятизначного числа.

string checkPalindrom(int number)
{
    int num1 = number / 10000;
    int num2 = (number % 10000) / 1000;
    int num4 = (number % 100) / 10;
    int num5 = number % 10;
    
    if (num1 == num5 && num2 == num4)
        return "Введённое число является палиндромом";
    else
        return "Введённое числое не является палиндромом";
}

Console.WriteLine("Введите любое пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10000 && num <= 99999)
    {
    Console.WriteLine (checkPalindrom(num));
    }
else 
    {
    Console.WriteLine ("Вы ввели не пятизначное число");
    }