// See https://aka.ms/new-console-template for more information
using System.Net;
using System.Runtime.Intrinsics.Arm;

int num1;
int num2;
int num3;
Console.WriteLine("Digite três números , diferentes :");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());
if (num1 < num2 && num2 < num3)
{
    Console.WriteLine("A ordem crescente dos números é: " +num1+","+num2+","+num3 );
}

else if (num1 < num3 && num3 < num2)
{
    Console.WriteLine("A ordem crescente dos números é: " +num1+","+num3+","+num2);
}

else if (num2 < num1 && num1 < num3)
{
    Console.WriteLine("A ordem crescente dos números é: " + num2 + "," + num1 + "," + num3);
}

else if (num2 < num3 && num3 < num1)
{
    Console.WriteLine("A ordem crescente dos números é: " + num2 + "," + num3 + "," + num1);
}

else if (num3 < num1 && num1 < num2)
{
    Console.WriteLine("A ordem crescente dos números é: " + num3 + "," + num1 + "," + num2);
}

else if (num3 < num2 && num2 < num1)
{
    Console.WriteLine("A ordem crescente dos números é: " + num3 + "," + num2 + "," + num1);
}