using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("---------------------------------------");
Console.WriteLine("===== Teste de Smartphones DioWex =====");
Console.WriteLine("---------------------------------------");
Console.ResetColor();
Console.WriteLine("");

Console.WriteLine("[1] Informar número de celular para testes.");
Console.WriteLine("[2] NÃO Informar número de celular para testes, usar número padrão.");
Console.WriteLine();
Console.Write("Digite sua opção: ");

string numeroCelular = String.Empty;
string informarNumero = Console.ReadLine();

if (informarNumero == "1")
{
    Console.WriteLine();
    Console.Write("Digite o número do celular: ");
    numeroCelular = Console.ReadLine();
}
else if (informarNumero == "2")
{
    numeroCelular = "234-5678";
}
else
{
    throw new ArgumentException("Opção Inválida, é necessario escolher uma das opções para fazer os testes.\n" + "Tente novamente, digite o número [x] da opção ");
}

Console.Clear();

string[] celular = { "Nokia", "Iphone" };

Console.WriteLine("Aparelhos disponiveis para teste:");
Console.WriteLine("[1] " + celular[0]);
Console.WriteLine("[2] " + celular[1]);
Console.WriteLine();
Console.Write("Digite sua opção: ");

string aparelhoEscolhido = Console.ReadLine();

Smartphone smartphone;
if (aparelhoEscolhido == "1")
{
    smartphone = new Nokia(numero: numeroCelular, modelo: "Nokia", imei: "861536030196001", memoria: 64);
}
else if (aparelhoEscolhido == "2")
{
    smartphone = new Iphone(numero: numeroCelular, modelo: "Iphone", imei: "98561350321200", memoria: 128);
}
else
{
    throw new ArgumentException("Opção Inválida, é necessario escolher um dos aparelhos para fazer os testes.\n" + "Tente novamente, digite o número [x] do aparelho");
}

Console.Clear();

smartphone.ExibirDadosDoCelular();
smartphone.Ligar();
smartphone.ReceberLigacao();
smartphone.InstalarAplicativo("WhatsApp");
smartphone.InstalarAplicativo("Telegram");
Console.WriteLine("\n");

Console.WriteLine("Testes concluidos");
Console.WriteLine();
