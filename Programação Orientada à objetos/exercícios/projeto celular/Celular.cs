using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_celular
{
    public class Celular
    {
        // atributos
        public string cor = "Azul";
        public string modelo = "Galaxy A01";
        public string tamanho = "10 polegadas";
        public bool ligado = false;

        // métodos
        public void Ligar()
        {
            if (ligado == true )
            {
                Console.WriteLine($"o celular já está ligado!");
            }
            else
            {
                ligado = true;
                Console.WriteLine($"O celular está ligado agora!");
            }
        }
        public void Desligar()
        {
            if (ligado == false)
            {
                Console.WriteLine($"O celular já está desligado!");
            }
            else
            {
                ligado = false;
            }
        }
        public void FazerLigação()
        {
            if (ligado == true)
            {
                Console.WriteLine(@$"
Ligando...
Ligação concluída!
                ");
            }
            else
            {
                Console.WriteLine($"Celular desligado!!");
            }
        }
        public void EnviarMensagem()
        {
            if (ligado == true)
            {
                Console.WriteLine(@$"
Enviando mensagem ...
Mensagem enviada!
");
            }
        }
    }
}