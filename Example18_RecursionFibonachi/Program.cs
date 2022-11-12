for(int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonachi(i));
}

int Fibonachi(int number)
{
    if(number == 1 || number == 2)
    {
        return 1;
    }
    else
    {
        return Fibonachi(number - 1) + Fibonachi(number - 2);
    }
}