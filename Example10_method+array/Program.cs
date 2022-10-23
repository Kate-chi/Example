int[] array = {2, 9, 56, 95, 95, 4, 8};

int n = array.Length;
int index = 0;

int find = 95;

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
