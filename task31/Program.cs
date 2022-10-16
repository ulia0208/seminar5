// task 31

void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      array[i] = new Random().Next(-9, 10);
}


int SummaPositiveNumbers(int[] array)
{
   int summaP = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > 0)
         summaP = summaP + array[i]; // summaP += array[i];
   }

   return summaP;
}


int SummaNegativeNumbers(int[] array)
{
   int summaN = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] < 0)
         summaN = summaN + array[i]; // summaP += array[i];
   }

   return summaN;
}


Console.Clear();
int[] array = new int[12];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма положительных элементов равна: {SummaPositiveNumbers(array)}");
Console.WriteLine($"Сумма отрицательных элементов равна: {SummaNegativeNumbers(array)}");