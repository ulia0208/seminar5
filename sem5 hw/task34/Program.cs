//Задайть массив, заполненный случайными положительными трехзначными числами. Программа показывает колличество четных чисел в массиве

Console.Clear();

int num = new Random().Next(5,100);
int[]  myArray=new int[num];

void CreateNewArray(int[] array)
{
    for (int i=0; i<num; i++)
    {
        array[i]=new Random().Next(-100, 100);   
    }
}


CreateNewArray(myArray);

Console.WriteLine("чисел в массиве - " +num);
Console.WriteLine($"Заданный случайным образом массив: [{String.Join(", ",  myArray)}]");



int SelectArray(int[] array, int number)
{
    int j=0;
    int k=0;

    while (j<number)
    {
         if (array[j]%2==0)
        {  
            k++;
            
        }
        j++;
    }
    return k;
}



Console.WriteLine($"четных чисел = {SelectArray(myArray, num)}");
    //////////////

