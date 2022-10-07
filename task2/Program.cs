Console.WriteLine("Введите три числа");
int a = int.Parse (Console.ReadLine()??"0");
int b = int.Parse (Console.ReadLine()??"0");
int c = int.Parse (Console.ReadLine()??"0");
int[] arr = new int[] { a, b, c };
int max = arr.Max();

Console.WriteLine(max);

Console.ReadKey();