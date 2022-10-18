// Задать одномерный массив, заполненый случайными числами. найти сумму элементов, стоящих на нечетных позициях
int num = new Random().Next(3,100);
int[] myArray=new int [num];




void CreateAr(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        array[i]=new Random().Next(-100,100);
    }
}

CreateAr(myArray);

int SumAr(int[] array, int number)
{
    
    int sum=0;
    for(int j=1; j<array.Length; j=j+2)    
    {
        sum=sum+myArray[j];
        
    }  
    return sum;
}



Console.WriteLine($"сумма значений на нечетных позициях равна {SumAr(myArray, num)}"); 
Console.WriteLine(string.Join(", ", myArray));
