// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void NewArray(int[] array)
{
    for (int i=0;i<array.Length;i++)
    {

        array[i]= new Random().Next(-10000,10000);
    }
}


string ReleaseArray (int[] array, int number)
{
    for (int i =0; i<array.Length;i++)
    {
        if (array[i]==number)
        return "yes";
    }
    return "no";
} 


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Myarray = new int[n];
NewArray(Myarray);
Console.WriteLine($"Начальнаый массив: [{string.Join(", ", Myarray)}]");
Console.Write("Введите число, которое Вы хотите найти: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"{ReleaseArray(Myarray, m)}");
