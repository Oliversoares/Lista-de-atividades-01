// See https://aka.ms/new-console-template for more information
int num;
Console.WriteLine("Digite um número maior que ZERO : ");
num = int.Parse(Console.ReadLine());
int contador = 1;
while (contador <= num)
{
    Console.WriteLine($"{contador}");
    contador++;
}