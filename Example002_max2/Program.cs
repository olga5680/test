Console.Clear();
Console.Write("Введите 3 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > b & a > c)
    Console.Write("max: " + a);
else if (b > a & b > c)
    Console.Write("max: " + b);
else 
    Console.WriteLine("max: " + c);

