// See https://aka.ms/new-console-template for more information
int nota1;
int nota2;
int media;
Console.WriteLine("Digite suas notas:");
nota1 = int.Parse(Console.ReadLine());
nota2 = int.Parse(Console.ReadLine());
media = nota1 + nota2;
if (media / 2 >= 6) 
{
    Console.WriteLine("APROVADO , média satisfatoria");
}
else
{
    Console.WriteLine("REPROVADO , média insuficiente");
}