// Задача 62 
 
// Заполните спирально массив 4 х 4. 
 
// Для заполнения массива 4 х 4 понадобится 16 элементов. 
 
// Например, на выходе получается вот такой массив: 
// 1 2 3 4 
// 12 13 14 5 
// 11 16 15 6 
// 10 9 8 7 
 
Console.WriteLine($"Введите числа, для заполнения массива: "); 
int a = InputNumbers("Введите 1 число: "); 
int b = InputNumbers("Введите 2 число: "); 
int c = InputNumbers("Введите 3 число: "); 
int d = InputNumbers("Введите 4 число: "); 
int e = InputNumbers("Введите 5 число: "); 
int f = InputNumbers("Введите 6 число: "); 
int g = InputNumbers("Введите 7 число: "); 
int h = InputNumbers("Введите 8 число: "); 
int l = InputNumbers("Введите 9 число: "); 
int q = InputNumbers("Введите 10 число: "); 
int w = InputNumbers("Введите 11 число: "); 
int r = InputNumbers("Введите 12 число: "); 
int t = InputNumbers("Введите 13 число: "); 
int y = InputNumbers("Введите 14 число: "); 
int u = InputNumbers("Введите 15 число: "); 
int o = InputNumbers("Введите 16 число: "); 
 
int InputNumbers(string input) 
{ 
 Console.Write(input); 
 int output = Convert.ToInt32(Console.ReadLine()); 
 return output; 
} 
 
int s = 1; 
 
int[,] arrey = new int[4, 4]; 
 
void FillArrey(int[,] arrey) 
{ 
    for (int i = 0; i < 4; i++) 
    { 
        arrey[0, i] = s; 
        s++; 
    } 
    for (int j = 1; j < 4; j++) 
    { 
        arrey[j, 4 - 1] = s; 
        s++; 
    } 
    for (int i = 4 - 2; i >= 0; i--) 
    { 
        arrey[4 - 1, i] = s; 
        s++; 
    } 
    for (int j = 4 - 2; j > 0; j++) 
    { 
        arrey[j, 0] = s; 
        s++; 
    } 
    for (int i = 4 - 3; i > 0; i++) 
    { 
        arrey[4 - 2, i] = s; 
        s++; 
    } 
    for (int j = 4 - 3; j > 1; j--) 
    { 
        arrey[j, 1] = s; 
        s++; 
    } 
    for (int i = 4 - 4; i > 1; i--) 
    { 
        arrey[4 - 3, i] = s; 
        s++; 
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
 
FillArrey(arrey); 
PrintArrey(arrey);
