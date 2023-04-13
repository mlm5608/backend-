//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda

bool teste = false;

while (teste == false)
{

    Console.WriteLine($"digite sua renda mensal: (quando quiser parar é so digitar enter)");
    float renda = float.Parse(Console.ReadLine()!);

    static float Impost(float renda, int x)
    {
        return (renda * x) / 100;
    }

    if (renda <= 1500)
    {
        Console.WriteLine($"Você está isento de imposto !");
    }

    else if ((renda > 1500) && (renda <= 3500))
    {
        float imposto = Impost(renda, 20);
        Console.WriteLine($"O valor a pagar de imposto é:{imposto} reais");
    }

    else if ((renda > 3500) && (renda <= 6000))
    {
        float imposto = Impost(renda, 25);
        Console.WriteLine($"O valor a pagar de imposto é:{imposto} reais");
    }

    else if (renda > 6000)
    {
        float imposto = Impost(renda, 35);
        Console.WriteLine($"O valor a pagar de imposto é:{imposto} reais");
    }
    else
    {
        teste = true;
    }
}

