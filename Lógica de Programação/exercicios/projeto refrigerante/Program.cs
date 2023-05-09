// coca cola / pepsi / fanta / monster
// crie um menu de opções e peça para o usuário escolher uma das opçõesa depender da opção, exiba uma mensagem se gostaria de acrescentar gelose sim, exiba uma mensagem que a bebida em questão será com adicional de gelocaso contrário, a bebida é sem gelo adicional

Console.WriteLine(@$"
escolha uma das opções e digite o número correspondente abaixo

1 = coca-cola
2 = pepsi
3 = fanta
4 = monster
");

int refrigerante = int.Parse(Console.ReadLine());

Console.WriteLine(@$"
C = com gelo
S = sem gelo
"); 
char varGelo = char.Parse(Console.ReadLine().ToUpper());

switch (refrigerante)
{
    case 1:
        switch (varGelo)
        {
            case 'C':
            Console.WriteLine($"Escolhido: coca-cola com gelo");
                break;

            case 'S':
            Console.WriteLine($"escolhido: coca-cola sem gelo");
            
                break;
            
            default:
            Console.WriteLine($"Escolha inválida");
                break;
        }
        
        
        break;
    case 2:
        switch (varGelo)
        {
            case 'C':
            Console.WriteLine($"Escolhido: pepsi com gelo");
                break;

            case 'S':
            Console.WriteLine($"escolhido: pepsi sem gelo");
            
                break;
            
            default:
            Console.WriteLine($"Escolha inválida");
                break;
        }
        
        
        break;

    case 3:
        switch (varGelo)
        {
            case 'C':
            Console.WriteLine($"Escolhido: fanta com gelo");
                break;

            case 'S':
            Console.WriteLine($"escolhido: fanta sem gelo");
            
                break;
            
            default:
            Console.WriteLine($"Escolha inválida");
                break;
        }
        
        
        break;
    case 4:
        switch (varGelo)
        {
            case 'C':
            Console.WriteLine($"Escolhido: monster com gelo");
                break;

            case 'S':
            Console.WriteLine($"escolhido: monster sem gelo");
            
                break;
            
            default:
            Console.WriteLine($"Escolha inválida");
                break;
        }
        
        
        break;

    default:
        Console.WriteLine($"escolha inválida");

    break 
}

