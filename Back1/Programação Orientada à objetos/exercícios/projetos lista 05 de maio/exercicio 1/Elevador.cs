namespace exercicio_1
{
    public class Elevador
    {
        private int capacidade;
        private int totalAndares;
        private int andarDestino;
        private int andarAtual = 0;
        private int numeroPessoas = 0;
        public void  Inicializa()
        {
            Console.WriteLine($"quantas pessoas cabem no elevador?");
            capacidade = int.Parse(Console.ReadLine()!);
            
            Console.WriteLine($"quantos andares tem o prédio?(desconsiderando o térreo)");
            totalAndares = int.Parse(Console.ReadLine()!);
        }

        public void Entrar()
        {
            if (numeroPessoas == capacidade)
            {
                Console.WriteLine($"Elevador cheio!");
            }
            else
            {
                numeroPessoas++;
                Console.WriteLine($"Uma pessoa entrou no elevador");
            }
        }
        public void Sair()
        {
            if (numeroPessoas == 0)
            {
                Console.WriteLine($"Não tem ninguém para sair! Você está vendo fantasmas");
            }
            else
            {
                numeroPessoas--;
                Console.WriteLine($"Uma pessoa saiu do elevador!");
            }
        }
        public void Subir()
        {
            if (andarAtual == totalAndares)
            {
                Console.WriteLine($"Você está no útimo andar!");
            }
            else
            {
                andarAtual++;
                Console.WriteLine($"Você subiu um andar!");
            }
            Console.WriteLine(@$"
Andar: {andarAtual}
Pessoas: {numeroPessoas}
            ");
            
        }
        public void Descer()
        {
            if(andarAtual == 0)
            {
                Console.WriteLine($"Você está no andar mais baixo!");
            }
            else
            {
                andarAtual--;
                Console.WriteLine($"Você desceu um andar!");
            }
            Console.WriteLine(@$"
Andar: {andarAtual}
Pessoas: {numeroPessoas}
            ");
        }
    }
}