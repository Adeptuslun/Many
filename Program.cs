Console.WriteLine("Введите длинну массива") ;
int n = Convert.ToInt32(Console.ReadLine());

  String[] array = new string[n];
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine("Введите значение") ;
    string count=Console.ReadLine();
    array[i] = count;

    Console.Write($"{array[i]} ");
  }
List<string> Limit = new List<string>();
for (int i = 0; i < n; i++)
  {
   
    string count = array[i];
    if (count.Length >=3)
    {
      Limit = new List<string>() {count};
    }

    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();