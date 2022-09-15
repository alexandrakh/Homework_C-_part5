//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int size = 8;
int[] array = FillArray(size);
System.Console.WriteLine("[{0}]", string.Join(",", array));
System.Console.WriteLine($"Сумма нечетных чисел в массиве равна: {GetSumNechet(array)}");
int[] FillArray(int size)
{
    int [] array =new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(1,20);   
    }
    return array;
}

int GetSumNechet(int[]array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 1)
        {
            sum+=array[i];
        }
    }
    return sum;
}


