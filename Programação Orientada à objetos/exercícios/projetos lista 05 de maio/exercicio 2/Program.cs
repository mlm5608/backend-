// 2.Você trabalha em uma empresa especialista em máquinas de fazer café e sua equipe é a responsável por desenvolver uma classe para o novo modelo de cafeteiras que irão fabricar. No modelo anterior das cafeteiras, os usuários podiam selecionar se era para ser adicionado açúcar ou não, mas a nova versão da Super CafeteiraTabajaras Plus++ deve ser capaz de receber a quantidade (em gramas) de açúcar a ser colocada no café. Mesmo com essa nova possibilidade, o usuário não será obrigado a informar quanto de açúcar deseja. Deve-se adicionar 10 gramas de açúcar por padrão caso nenhum valor seja informado.
// a. Para começar, crie a classe "MaquinaCafe" com um atributo chamado "acucarDisponivel", que será útil para saber a quantidade de açúcar disponível na máquina. Se o açúcar acabar, a máquina só permitirá cafezinhos sem açúcar, certo?
// b. Agora crie um método chamado "fazerCafe" na mesma classe. Esse método deve verificar se a quantidade de açúcar disponível na máquina é suficiente e, claro, fazer o café.
// c. Como o usuário não será obrigado a informar a quantidade de açúcar a ser adicionado no café, crie outro método com o nome "fazerCafe", que não recebe nenhum parâmetro. Isso é uma sobrecarga de métodos!

using exercicio_2;

MaquinaCafe maquina = new MaquinaCafe();

bool loop = true;


do
{
    Console.WriteLine(@$"
Olá vamos fazer seu café?

Gostaria com açúcar?
1- Sim
2- Não
0- Encerrar
");
    string resposta1 = Console.ReadLine()!;

    switch (resposta1)
    {
        case "1":
            Console.WriteLine($"Com quantos gramas? (Aperte qualquer tecla para adicionar o padrão: 10g)");
            string addString = Console.ReadLine()!;

            if (addString != "")
            {
                Console.WriteLine($"confirme a quantidade!");
                float addFloat = float.Parse(Console.ReadLine()!);

                maquina.FazerCafe(addFloat);

                Console.WriteLine($"Dentro de 2 minutinhos seu café estará pronto! aperte qualquer tecla para voltar ao inicio!");
                Console.ReadLine();

                Console.Clear();
            }
            else
            {
                maquina.FazerCafe();

                Console.WriteLine($"Dentro de 2 minutinhos seu café estará pronto! aperte qualquer tecla para voltar ao inicio!");
                Console.ReadLine();
                
                Console.Clear();
            }
            break;

        case "2":
            Console.Clear();
            Console.WriteLine($"Dentro de 2 minutinhos seu café estará pronto! aperte qualquer tecla para voltar ao inicio!");
            Console.ReadLine();
            Console.Clear();
            break;

        case "0":
            Console.Clear();
            loop = false;
            break;

        default:
            Console.Clear();
            Console.WriteLine($"resposta inválida");
            break;
    }

} while (loop != false);