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
   String[] Arry = new string[j];
for (int i = 0; i < j; i++)
{
    if (array[i].Length<=3)
    {Arry[i] = array[i];
    Console.Write($"{Arry[i]}/");}
}
