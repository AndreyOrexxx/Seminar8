// Задача 60 
 
// Сформируйте трехмерный массив из не повторяющихся чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
 
Console.WriteLine($"Введите размер массива X x Y x Z:"); 
 
int x = InputNumbers("Введите X: "); 
int y = InputNumbers("Введите Y: "); 
int z = InputNumbers("Введите Z: "); 
Console.WriteLine(); 
 
int[,,] arrey3D = new int[x, y, z]; 
CreateArrey(arrey3D); 
PrintArrey(arrey3D); 
 
int InputNumbers(string input) 
{ 
    Console.Write(input); 
    int output = Convert.ToInt32(Console.ReadLine()); 
    return output; 
} 
void PrintArrey (int[,,] arrey3D) 
{ 
    for (int i = 0; i < arrey3D.GetLength(0); i++) 
    { 
        for (int j = 0; j < arrey3D.GetLength(1); j++) 
        { 
            Console.Write($"X({i}) Y({j}) "); 
            for (int k = 0; k < arrey3D.GetLength(2); k++) 
            { 
                Console.Write($"Z({k}) = {arrey3D[i, j, k]}; "); 
            } 
            Console.WriteLine(); 
        } 
        Console.WriteLine(); 
    } 
} 
 
void CreateArrey (int[,,] arrey3D) 
{ 
    int[] temp = new int[arrey3D.GetLength(0) * arrey3D.GetLength(1) * arrey3D.GetLength(2)]; 
    int number; 
    for (int i = 0; i < temp.GetLength(0); i++) 
    { 
        temp[i] = new Random().Next(10, 100); 
        number = temp[i]; 
        if (i >= 1) 
        { 
            for (int j = 0; j < i; j++) 
            { 
                while (temp[i] == temp[j]) 
                { 
                    temp[i] = new Random().Next(10, 100); 
                    j = 0; 
                    number = temp[i]; 
                } 
                number = temp[i]; 
            } 
        } 
    } 
    int count = 0; 
    for (int x =0; x < arrey3D.GetLength(0); x++) 
    { 
        for (int y = 0; y < arrey3D.GetLength(1); y++) 
        { 
            for (int z = 0; z < arrey3D.GetLength(2); z++) 
            { 
                arrey3D[x, y, z] = temp[count]; 
                count++; 
            } 
        } 
    } 
}
