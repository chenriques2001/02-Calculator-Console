
using Calculadora;

var calculadora = new CalculadoraBasica();
while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== Calculadora ===");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine();
    Console.Write("Escolha uma operação: ");

    var operacaoEscolhida = Console.ReadLine();
    if (operacaoEscolhida == null || operacaoEscolhida == "0")
        return;

    Operacao operacao;
    switch (operacaoEscolhida)
    {
        case "1":
            operacao = Operacao.Somar;
            break;
        case "2":
            operacao = Operacao.Subtrair;
            break;
        case "3":
            operacao = Operacao.Multiplicar;
            break;
        case "4":
            operacao = Operacao.Dividir;
            break;
        default:
            Console.WriteLine("Opção inválida. Escokhe um número de 0 a 4");
            continue;
    }

    Console.WriteLine();    
    var n1 = LerNumero("Insira o primeiro número: ");
    var n2 = LerNumero("Insira o segundo número: ");

    try
    {
        var resultado = calculadora.Calcular(operacao, n1, n2);
        Console.WriteLine();
        Console.WriteLine($"Resultado: {resultado}");
    }
    catch(DivideByZeroException de)
    {
        Console.WriteLine();
        Console.WriteLine("Erro: "+ de.Message);
    }
}

static decimal LerNumero(string pergunta)
{
    while (true)
    {
        Console.Write(pergunta);
        var texto = Console.ReadLine();
        if (decimal.TryParse(texto, out decimal numero))
            return numero;

        Console.WriteLine("Valor inválido, tenta outra vez");
    }
}
