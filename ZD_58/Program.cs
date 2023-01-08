int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }

        Console.WriteLine("");
    }
}

int size = InputInt("Введите размер матриц: ");
int[,] matrixX = new int[size, size];
int[,] matrixY = new int[size, size];
ArrayRandomNumbers(matrixX);
ArrayRandomNumbers(matrixY);
int[,] matrixZ = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixZ[i, j] = matrixZ[i, j] + (matrixX[i, k] * matrixY[k, j]);
        }
    }
}
Console.WriteLine("Первая матрица: ");
PrintArray(matrixX);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(matrixY);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintArray(matrixZ);
