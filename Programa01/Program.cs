//Random Number
string texto_personalizado = @"
█▀█ ▄▀█ █▄░█ █▀▄ █▀█ █▀▄▀█   █▄░█ █░█ █▀▄▀█ █▄▄ █▀▀ █▀█
█▀▄ █▀█ █░▀█ █▄▀ █▄█ █░▀░█   █░▀█ █▄█ █░▀░█ █▄█ ██▄ █▀▄
";


void inicio()
{
    Console.WriteLine(texto_personalizado);
    Console.WriteLine("Bem vindo! , tente acertar o número correto.(Entre 0 e 100)");
}

inicio();
Random aleatorio = new Random();
int numGerado = aleatorio.Next(1, 101);
//Console.WriteLine($"Resposta:{numGerado}");
do
{
    Console.Write("Faça seu chute:");
    int chute = int.Parse(Console.ReadLine()!);
    if (chute > numGerado)
    {
        Console.WriteLine("O número é menor que este valor!");
    }
    else if (chute < numGerado)
    {
        Console.WriteLine("O número é maior que este valor!");
    }
    else
    {
        Console.WriteLine("Parabéns você acertou!");
        break;
    }
} while (true);