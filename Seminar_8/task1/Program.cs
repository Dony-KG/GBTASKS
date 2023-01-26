//  Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
void NewMatrix (int[,] inArray)
{   
    int [,] result = new int [inArray.GetLength(0), inArray.GetLength(1)];
    
    if (inArray.GetLength(0) != inArray.GetLength(1))
    {
        
        WriteLine ("Невозможно");
       
    } 
    
    else 
    {

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           result[j, i] = inArray [i, j]; 
        }
    }
    PrintMatrixArray(result);
    

    }
}