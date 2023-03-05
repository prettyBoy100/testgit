// See https://aka.ms/new-console-template for more information

using GitProject;

Console.WriteLine("введите число которое будет возведенно в степень");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("введите степень в которую будет возведенно число");
int p = int.Parse(Console.ReadLine());

Console.WriteLine($"{a} * {a} = {Logic.Power(a, p)}");


