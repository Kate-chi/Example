int Max(int a, int b, int c)
{
    int result = a;
    if(b > result) result = b;
    if(c > result) result = c;
    return result;
}

int x = 4;
int y = 86;
int z = 43;

int max = Max(x, y, z);

Console.WriteLine(max);
