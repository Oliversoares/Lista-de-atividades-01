// See https://aka.ms/new-console-template for more information
int num, resultado, valor;
Console.WriteLine("Digite um número para multiplicação: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine("Até que valor irá a multiplicação ? ");
valor = int.Parse(Console.ReadLine());
int contador = 1;
while (contador <= valor ) 
{
    resultado = contador * num;
    Console.WriteLine($"{num} X {contador} = {resultado}");
    contador++;
}