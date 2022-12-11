Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int a = N / 10000;
Console.WriteLine(a);
int b = (N / 1000) % 10;
Console.WriteLine(b);
int c = (N / 100) % 10;
Console.WriteLine(c);
int d = (N / 10) % 10;
Console.WriteLine(d);
int e = N % 10;
Console.WriteLine(e);
if(a == e && b == d)
{
    Console.WriteLine("является палиндромом");
}
else 
{
    Console.WriteLine("не палиндром");
}

