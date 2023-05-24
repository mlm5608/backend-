using projeto_celular;

Celular cell = new Celular();
bool cellLigado = true;
do
{
    Console.WriteLine(@$"
1 - Ligar
2 - Desligar
3 - Fazer ligação
4 - Enviar mensagem
");
    string resposta = Console.ReadLine()!;

    switch (resposta)
    {
        case "1":
            cell.Ligar();
            break;
        case "2":
            cell.Desligar();
            cellLigado = false;
            break;
        case "3":
            cell.FazerLigação();
            break;
        case "4":
            cell.EnviarMensagem();
            break;
        default:
            Console.WriteLine($"Resposta inválida!");
            break;
    }
} while (cellLigado != false);
Console.Clear();