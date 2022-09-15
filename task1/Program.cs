//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int size = 8;
int[] array = FillArray(size);
System.Console.WriteLine("[{0}]", string.Join(",", array));
System.Console.WriteLine($"Количество четных числе в массиве равно: {GetCountChet(array)}");

int[] FillArray(int size)
{
    int [] array =new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(100,999);   
    }
    return array;
}

int GetCountChet(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 ==0)
        {
            count+=1;
            
        }
    }
    return count;
}
