// // Задача 54 

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
 
Console.WriteLine($"Введите размер массива m x n и диапазон случайных значений: "); 
 
int m = InputNumbers("Введите m: "); 
int n = InputNumbers("Введите n: "); 
int range = InputNumbers("Введите диапазон от 1 до  "); 
 
int[,] arrey = new int[m, n]; 
 
void OrderArreyLines(int[,] arrey) 
{ 
    for (int i = 0; i < arrey.GetLength(0); i++) 
    { 
        for (int j = 0; j < arrey.GetLength(1); j++) 
        { 
            for (int k = 0; k < arrey.GetLength(1)-1; k++) 
            { 
                if (arrey[i, k] < arrey[i, k + 1]) 
                { 
                    int temp = arrey[i, k + 1]; 
                    arrey[i, k + 1] = arrey[i, k]; 
                    arrey[i, k] = temp; 
                }  
            } 
        } 
    } 
} 
 
int InputNumbers(string input) 
{ 
    Console.Write(input); 
    int output = Convert.ToInt32(Console.ReadLine()); 
    return output; 
} 
 
void CreateArray(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = new Random().Next(range); 
        } 
    } 
} 
 
void PrintArrey (int[,] arrey) 
{ 
    for (int i = 0; i < arrey.GetLength(0); i++) 
    { 
        for ( int j = 0; j < arrey.GetLength(1); j++) 
        { 
            Console.Write(arrey[i, j] + " "); 
        } 
        Console.WriteLine(); 
    } 
} 
 
CreateArray(arrey); 
PrintArrey(arrey); 
 
Console.WriteLine("Отсортированный массив: "); 
 
OrderArreyLines(arrey); 
PrintArrey(arrey);