//int n = int.Parse(Console.ReadLine());
//int num = 1;

//while (num <= n)
//{
//    Console.WriteLine(num);
//    num = 2 * num + 1;
//}


int num = int.Parse(Console.ReadLine());
while (num < 1 || num > 100)
{
    Console.WriteLine("Invalid number!");
    num = int.Parse(Console.ReadLine());
}
Console.WriteLine($"The number is {num}.");