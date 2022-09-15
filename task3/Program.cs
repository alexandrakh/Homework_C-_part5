//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.
//[3 7 22 2 78] -> 76

int size = 10;
double[] array = FillArray(size);
System.Console.WriteLine("[{0}]", string.Join(",", array));
double min, max;
FindMaxMin(array, out min, out max);
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {GetSum(max, min)}");

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}
void FindMaxMin(double[] array, out double min, out double max)
{

    max = array[0];
    min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
}
double GetSum(double max, double min)
{
    double sum = max - min;
    return sum;
}
