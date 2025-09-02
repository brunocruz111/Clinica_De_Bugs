// See https://aka.ms/new-console-template for more information
Console.WriteLine("Por favor, digite seu primeiro nome:")
string primeiroNome = Console.ReadLine();
Console.WriteLine("Agora, digite sua idade:");
int idade = Console.ReadLine();
Console.WriteLine("Por fim, digite sua altura em metros (ex: 1,80):");
float altura = float.Parse(Console.ReadLine());
Console.writeline($"Resumo do Cadastro: Nome: {PrimeiroNome}, Idade: {idade}
anos, Altura: {altura}m.")