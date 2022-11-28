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
