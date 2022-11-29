Console.WriteLine("Введите длинну массива") ; 
int n = Convert.ToInt32(Console.ReadLine());

  String[] array = new string[n];
 
  int j = 0;
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine($"Введите значение");
    string? count=Convert.ToString(Console.ReadLine());
    array[i] = count; 
if (count.Length <=3)
    {
          j++;
    }
  }
  Console.WriteLine($"Заданный массив:");
  for (int i = 0; i < n; i++)
  {
      Console.Write($" {array[i]} /");

  }
    String[] Arry = new string[j];
    Console.WriteLine();
   
    Console.WriteLine($"Искомый массив:");
if (j==0)
   {
    Console.Write($"не может быть создан");
   }
for (int i = 0; i < j; i++)
{
    if (array[i].Length<=3)
    {Arry[i] = array[i];
    Console.Write($" {Arry[i]}/ ");
    }
}
