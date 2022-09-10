// Двумерные массивы
// string[,]table = new string[2,3]; - так будет задана таблица строк

// table - наименование массива,
// [,] -указание на двумерность,
// 2 это количество строк, 3 - количество столбцов

// int[,] matrix = new int[5,8]; 
// - таблица чисел(матрица) из 5 строк и 8 столбцов

string[,] table = new string[2,5]; // строки от 0 до 1, столбцы от 0 до 4
//String.Empty - инициализация для строк
//table[0,0] table[0,1] table[0,2] ... table[0,4] 
//table[1,0] table[1,1] table[1,2] ... table[1,4]
// table[1,2]="слово";
// for(int rows = 0; rows<2; rows++)
// {
//     for(int columns = 0; columns<5; columns++) 
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }

int[,] matrix = new int[3,4];
void PrintArray(int[,] matr)
{
for(int i = 0; i < matrix.GetLength(0); i++) // 0 это количество строк
{
   for(int j = 0; j<matrix.GetLength(1); j++) // 1 это количество столбцов
   {
    Console.Write($" {matrix[i, j]} ");
   }
   Console.WriteLine();
}
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j<matrix.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);