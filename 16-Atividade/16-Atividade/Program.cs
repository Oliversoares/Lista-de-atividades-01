// See https://aka.ms/new-console-template for more information
int num,fat;
Console.WriteLine("Digite um número para calcular seu fatorial:");
num = int.Parse(Console.ReadLine());
if (num > 0)
{
    int contador = 1;
    fat = 1; 
    while (contador <= num)
    {
        fat = fat * contador;
        contador++;
    }
    Console.WriteLine($"Fatorial de {num}! é igual a: {fat}");

}
else if (num == 0)
{
    Console.WriteLine("O fatorial de zero é igual a 1");
}
if (num < 0 )
{
    Console.WriteLine("Números negativos não possuem fatorial ");
}