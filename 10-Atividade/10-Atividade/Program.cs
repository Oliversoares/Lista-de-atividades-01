// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int anoAtual ;
int anoNascimento;
int idade;
Console.Write("Digite o ano atual: ");
anoAtual = int.Parse(Console.ReadLine());

Console.Write("Digite o ano de nascimento: ");
anoNascimento = int.Parse(Console.ReadLine());

idade = anoAtual - anoNascimento;

Console.WriteLine($"\nIdade: {idade} anos");

if (idade < 16)
{
    Console.WriteLine("Você NÃO é obrigado a votar.");
}
else if ((idade >= 16 && idade < 18) || idade > 70)
{
    Console.WriteLine("Seu voto é FACULTATIVO.");
}
else
{
    Console.WriteLine("Seu voto é OBRIGATÓRIO.");
}
