Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Факториал {number} = {Factorial(number)}");


int Factorial(int num)
{
    if(num == 0 || num == 1)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
}