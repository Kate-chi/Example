int[] arr = {3, 7, 8, 4, 6, 2, 5, 7, 4, 1};

void PrintArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SortArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        int maxPos = i;

        for(int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] > arr[maxPos])
            {
                maxPos = j;
            }
        }
        int temp = arr[i];
        arr[i] = arr[maxPos];
        arr[maxPos] = temp;
    }
}


PrintArr(arr);
SortArr(arr);
PrintArr(arr);
