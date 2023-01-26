//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
        array[i]=new Random().Next(100,1001);
    }
    return array;
}
int Check(int[] array, int min, int max)
{
    int count=0;
    for (int i=0; i<array.Length;i++ )
    {
        if(array[i]%2==0)
    {count+=1;           
    }
        }
return count;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
        Console.WriteLine();
  
}
Console.Write("Input a Length array");
int Length=Convert.ToInt32(Console.ReadLine());
int minimal=100;
int maximal=1000;
int [] array=CreateRandomArray(Length,minimal, maximal);
ShowArray(array);
int count=Check(array,100,1000);
Console.WriteLine($"количество элементов в данном интервале {count}");
*/
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
    }
        Console.WriteLine();
  
}
int Sumel(int[] array,int min, int max)
{
    int sum=0;
    for (int i=0; i<array.Length;i=i+2 )
    {
        
    sum=sum+array[i];           
    
        }
return sum;
}
Console.Write("Input a Length array");
int Length=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value");
int minimal=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value");
int maximal=Convert.ToInt32(Console.ReadLine());
int [] array=CreateRandomArray(Length,minimal, maximal);
ShowArray(array);
int result=Sumel(array,minimal,maximal);
Console.WriteLine($"Сумма элементов {result}");
*/
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*Random rnd = new Random();

Console.WriteLine("Enter the length of the array:");
int length = int.Parse(Console.ReadLine());

double[] numbers = new double[length];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.NextDouble() * 100;
}

Console.WriteLine("Original array: " + string.Join(", ", numbers));

double min = numbers.Min();
double max = numbers.Max();

double difference = max - min;

Console.WriteLine("Difference between max and min element: " + difference);
*/