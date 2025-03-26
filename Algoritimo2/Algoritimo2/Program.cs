int idade = 10;
string nomeCliente = "Kaina Brum Habekost";
decimal  preco = 20M;
char letra = 'a';
var nomecompleto = "Kaina Brum Habekost";
var altura = 167;

Console.WriteLine("Digite seu nome:");
nomecompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem vindo" + nomecompleto);
Console.WriteLine();
Console.Write('Digite sua idade:');
var linha = Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("Idade informada" + idade);
if (idade < 18)
    Console.WriteLine("Voce não pode estar aqui !");

Console.ReadKey();