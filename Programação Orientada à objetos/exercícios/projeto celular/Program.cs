//Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano). Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.Só será possível executar tais métodos se o celular estiver ligado.

using projeto_celular;

Celular cell = new Celular();

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
} while (cell.ligado != false);

Console.Clear();