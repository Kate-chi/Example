string[,] table = new string [2, 5];

for(int row = 0; row < 2; row++)
{
    for(int col = 0; col < 5; col++)
    {
        //Console.Write($"+{table[row, col]}+");
    }
}

int[,] matrix = new int[3, 3];

PrintArr(matrix);

Console.WriteLine();

FillArr(matrix);
PrintArr(matrix);


void PrintArr(int[,] mart)
{
    for(int row = 0; row < matrix.GetLength(0); row++)
    {
        for(int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
    Console.WriteLine();    
    }
}

void FillArr(int [,] matr)
{
    for(int row = 0; row < matr.GetLength(0); row++)
    {
        for(int col = 0; col < matr.GetLength(1); col++)
        {
            matr[row, col] = new Random().Next(1, 10);
        }
    }
}

