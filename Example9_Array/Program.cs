int Max(int a, int b, int c)
{
    int result = a;
    if(b > result) result = b;
    if(c > result) result = c;
    return result;
}

int[] arr = {5, 9, 76};

int max = Max(arr[0], arr[1], arr[2]);

Console.WriteLine(max);