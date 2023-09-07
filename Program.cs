int length = Promt("Введите количество элементов");
int[] array;
array = InputArray(length);
PrintArray(array);
System.Console.WriteLine($"Количество чисел больше 0 {PositiveNum(array)}");


int Promt (string message)
{
    System.Console.WriteLine(message);
    string value = System.Console.ReadLine();
    int result =Convert.ToInt32(value);
    return result;
}


int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i< array.Length; i++ )
    {    
         array[i] = Promt($"Введите следующий элемент {i + 1}");
    }
   return array;
} 

void PrintArray(int[] array)
{
    foreach (int i in array) 
    {
        System.Console.Write($"{i} ");
    }
    System.Console.WriteLine();
} 

int PositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i< array.Length; i++ )
    {    
         if (array[i] > 0)
         {
            count++;
         }
    }
   return count;
} 


