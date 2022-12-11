// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел 
// от 1 до N.

Console.WriteLine("введите число _");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= Math.Abs(N); i++)
{
  Console.WriteLine(Math.Pow(i*(N/Math.Abs(N)), 3));  
}

