Console.WriteLine("Введите длинну массива") ;
int n = Convert.ToInt32(Console.ReadLine());

  String[] array = new string[n];
  List<string> Limit = new List<string>();
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine($"Введите значение");
    string count=Console.ReadLine();
    array[i] = count;
if (count.Length <=3)
    {
      Limit.Add(count);
    }
    
  }
  Console.WriteLine();
  String[] Arry = new string[Limit.Count];
  for (int i = 0; i < Arry.Length; i++)
  {
    Arry[i] = Limit[i];
    Console.Write($"{Arry[i]}/");
  }

  Console.WriteLine();
/*List<string> Limit = new List<string>();
for (int i = 0; i < n; i++)
  {
   
    string count = array[i];
    if (count.Length >=3)
    {
      Limit = new List<string>() {count};
    }

    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();*/