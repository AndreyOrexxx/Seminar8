// Задача 56 
 
// Задайти прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
 
Console.WriteLine("Введите размер массива m x n и диапазон случайных чисел:"); 
int m = InputNumbers("Введите m: "); 
int n = InputNumbers("Введите n: "); 
int range = InputNumbers("Введите диапазон от 1 до "); 
 
int[,] arrey = new int[m, n]; 
 
void CreateArrey(int[,] arrey) 
{ 
    for (int i = 0; i < arrey.GetLength(0); i++) 
    { 
        for (int j = 0; j < arrey.GetLength(1); j++) 
        { 
            arrey[i, j] = new Random().Next(range);         
        } 
    } 
} 
 
void PrintArrey(int[,] arrey) 
{ 
    for (int i = 0; i < arrey.GetLength(0); i++) 
    { 
        for (int j = 0; j < arrey.GetLength(1); j++) 
        { 
            Console.Write(arrey[i, j] + " "); 
        } 
        Console.WriteLine(); 
    } 
} 
 
CreateArrey(arrey); 
PrintArrey(arrey); 
 
int minSumLine = 0; 
int sumLine = SumLineElements(arrey, 0); 
for (int i = 0; i < arrey.GetLength(0); i++) 
{ 
    int tempSumLine = SumLineElements(arrey, i); 
    if (sumLine > tempSumLine) 
    { 
     sumLine = tempSumLine; 
     minSumLine = i;  
    } 
} 
 
Console.WriteLine($"{minSumLine + 1} - строка с наименьшей суммой элементов "); 
 
int SumLineElements(int[,] arrey, int i) 
{ 
 int sumLine = arrey[i, 0]; 
 for (int j = 0; j < arrey.GetLength(1); j++) 
 { 
    sumLine += arrey[i, j]; 
 } 
 return sumLine; 
} 
 
int InputNumbers(string input) 
{ 
    Console.Write(input); 
    int output = Convert.ToInt32(Console.ReadLine()); 
    return output; 
}
