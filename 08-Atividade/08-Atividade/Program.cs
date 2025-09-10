// See https://aka.ms/new-console-template for more information
int quant; 
Console.WriteLine("Quanta maçãs você vai comprar ?");
quant = int.Parse(Console.ReadLine());
if (quant >= 12)
{
    Console.WriteLine($"O valor a pagar é de: " + quant*1);
}
else 
{
    Console.WriteLine($"O valor a pagar é de: " + quant * 1.3);
}