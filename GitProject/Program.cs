// See https://aka.ms/new-console-template for more information

using GitProject;

Console.WriteLine("введите число которое будет умножено на себя");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"{a} * {a} = {Logic.PowerOf2(a)}");

