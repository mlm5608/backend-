namespace exemplo_1
{
    public class Personagem
    {
        // atributos
        // NOME, IDADE, ARMADURA, IA
        public string nome;
        public int idade;
        public string armadura;
        public string ia;

        public void Atacar(){
            Console.WriteLine($"O personagem atacou!");
        }
        public void Defender(){
            Console.WriteLine($"O personagem defendeu!");
        }
        public void RestaurarArmadura(){
            Console.WriteLine($"Armadura restaurada!!");
        }
    }
}