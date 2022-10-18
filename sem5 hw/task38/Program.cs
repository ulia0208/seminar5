// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным членом массива.

int num = new Random().Next(4,100);

double[] myArray=new double[num];

Console.WriteLine("число элементов "+num);


void CreatAr(double[] array)
{
    for (int i =0; i<array.Length; i++)
    {
        array[i]=new Random().Next(-100,100);
    
    }    
}

CreatAr(myArray);
double maximum=myArray[0];
for (int j=1;j<myArray.Length;j++)
{ 
    
    if (myArray[j]>maximum)
    {
        maximum=myArray[j];        
    }
} 
double minimum=myArray[0];
for (int j=1;j<myArray.Length;j++)
{ 
    
    if (myArray[j]<minimum)
    {
        minimum=myArray[j];        
    }
} 

Console.WriteLine($"Заданный случайным образом массив: [{String.Join(", ",  myArray)}]");
Console.WriteLine(maximum);
Console.WriteLine(minimum);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {maximum - minimum}");