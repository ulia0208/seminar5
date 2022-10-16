//Задайть массив, заполненный случайными положительными трехзначными числами. Программа показывает колличество четных чисел в массиве

Console.Clear();

int num = new Random().Next(5,30);
int[]  myArray=new int[num];

for (int i=0; i<num; i++)
{
    myArray[i]=new Random().Next(100, 1000);   
}

Console.WriteLine("чисел в массиве - " +num);
Console.WriteLine($"Заданный случайным образом массив: [{String.Join(", ",  myArray)}]");

int j=0;
int k=0;

while (j<num)
{
    if (myArray[j]%2==0)
    {  
        k++;
    }
    j++;
}

Console.WriteLine("четных чисел = "+k);
    //////////////

