Console.WriteLine("Введите первое число");
int a =int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число");
int b =int.Parse(Console.ReadLine() ?? "0");
if  (a == b) {Console.WriteLine("Числа равны");}
else if (a<b) { Console.WriteLine($"Число {a} меньшее, число {b} большее"); }
else { Console.WriteLine($"Число {b} меньшее, число {a} большее");}

Console.ReadKey();