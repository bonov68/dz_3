Console.WriteLine("Ведите первую А координату");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите вторую А координату");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите третью А координату");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите первую В координату");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите вторую В координату");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите третью В координату");
int z2 = Convert.ToInt32(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(Math.Round(length, 3));