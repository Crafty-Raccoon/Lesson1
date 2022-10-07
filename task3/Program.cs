Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
if (a % 2 == 0) { Console.WriteLine($"Число {a} чётное"); }
else { Console.WriteLine($"Число {a} нечётное"); }


Console.ReadKey();