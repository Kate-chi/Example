int[] arr = {7, 5, 8, 3, 8, 4, 4, 5, 1, 2};


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SortArr(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int minPos = i;

        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPos])
            {
                minPos = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

PrintArray(arr);
SortArr(arr);
PrintArray(arr);