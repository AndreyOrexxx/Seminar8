// Задача 58 
 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
 
// Зададим матрицы, которые можно перемножить. Т.е. колличество столбцов первой равно колличеству строк второй. 
 
Console.WriteLine($"Введите размеры матриц и диапазон случайных значений: "); 
 
int m = InputNumbers("Введите число строк первой матрицы: "); 
int n = InputNumbers("Введите число столбцов первой матрицы (и строк второй):"); 
int p = InputNumbers("Введите число столбцов второй матрицы: "); 
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до "); 
 
int[,] firstMartrix  = new int[m, n]; 
CreateArrey(firstMartrix); 
Console.WriteLine($"Первая матрица:"); 
PrintArrey(firstMartrix); 
 
int[,] secomdMartrix = new int[n, p]; 
CreateArrey(secomdMartrix); 
Console.WriteLine($"Вторая матрица:"); 
PrintArrey(secomdMartrix); 
 
int[,] resultMatrix = new int[p, m]; 
 
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix); 
Console.WriteLine($"Произведение первой и второй матриц:"); 
PrintArrey(resultMatrix); 
 
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix) 
{ 
    for (int i = 0; i < resultMatrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < resultMatrix.GetLength(1); j++) 
        { 
            int sum = 0; 
            for (int k = 0; k < firstMartrix.GetLength(1); k++) 
            { 
                sum += firstMartrix[i, k] * secomdMartrix[k, j]; 
            } 
            resultMatrix[i, j] = sum; 
        } 
    } 
} 
 
int InputNumbers(string input) 
{ 
    Console.Write(input); 
    int output = Convert.ToInt32(Console.ReadLine()); 
    return output; 
} 
 
void CreateArrey(int[,] arrey) 
{ 
    for (int i = 0; i < arrey.GetLength(0); i++) 
    { 
        for (int j = 0; j < arrey.GetLength(1); j ++) 
        { 
            arrey[i, j] = new Random().Next(range); 
        } 
    } 
} 
 
void PrintArrey(int[,] arrey) 
{ 
    for (int i = 0; i < arrey.GetLength(0); i++) 
    { 
        for (int j = 0; j < arrey.GetLength(1); j ++) 
        { 
            Console.Write(arrey[i, j] + " "); 
        } 
        Console.WriteLine(); 
    } 
}