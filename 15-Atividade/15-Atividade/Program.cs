// See https://aka.ms/new-console-template for more information
int num;
num = 2000;
int contador = 1000;
while (contador <= num)
{
    Console.WriteLine($"{contador}");
    Console.WriteLine($" se dividido por 11 tem resto 5 :{contador % 11 == 5}");
    contador++;
}
