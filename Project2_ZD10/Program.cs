//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int a=Convert.ToInt32(Console.ReadLine());
int amount = a.ToString().Length;

if (amount < 3 || amount > 3)
{
 Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
 Console.WriteLine(InCenter(a));
}

int InCenter(int b)
{
    
    int result = ((b / 10) % 10);
    return result;
}