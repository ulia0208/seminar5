// Задать одномерный массив, заполненый случайными числами. найти сумму элементов, стоящих на нечетных позициях
int num = new Random().Next(3,100);
int[] myArray=new int [num];


int j=1;
int sum=0;

for(int i=0;i<num;i++)
{
    myArray[i]=new Random().Next(-10,10);
}

while(j<num)
{
    sum=sum+myArray[j];
    j=j+2;
}
Console.WriteLine(sum); 
Console.WriteLine(string.Join(", ", myArray));
