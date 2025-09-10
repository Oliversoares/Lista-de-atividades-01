// See https://aka.ms/new-console-template for more information
int num1;
int num2;
Console.WriteLine("Digite dois números , diferentes :");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("O maior número é:" +num1);
}
else
{
    Console.WriteLine("O maior número é:" + num2);
}