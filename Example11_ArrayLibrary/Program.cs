void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;

    while(index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int len = col.Length;
    int position = 0;

    while(position < len)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collect, int find)
{
    int leng = collect.Length;
    int ind = 0;
    int position = -1;

    while(ind < leng)
    {
        if(collect[ind] == find)
        {
            position = ind;
        }
        ind++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine(IndexOf(array, 99));