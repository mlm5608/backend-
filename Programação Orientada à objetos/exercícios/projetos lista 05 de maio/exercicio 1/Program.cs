// 1. Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os seguintes métodos:

// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);

// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);

// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);

// Subir : para subir um andar (não deve subir se já estiver no último andar);

// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).

using exercicio_1;

Elevador elevador = new Elevador();
bool loop = true;

elevador.Inicializa();
do
{
    Console.WriteLine(@$"
Escolha 1 opção:

1 - Entrar (1 pessoa por vez)
2 - Sair (1 pessoa por vez)
3 - Subir (1 andar por vez)
4 - Descer (1 andar por vez)
0 - Encerrar 
");
    string resposta = Console.ReadLine()!;

    switch (resposta)
    {
        case "1":
            Console.Clear();
            elevador.Entrar();
            break;

        case "2":
            Console.Clear();
            elevador.Sair();
            break;

        case "3":
            Console.Clear();
            elevador.Subir();
            break;
        case "4":
            Console.Clear();
            elevador.Descer();
            break;
        case "0":
            Console.Clear();
            loop = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Resposta inválida");
            break;
    }
} while (loop != false);