using System;

class Program
{
    static void Main()
    {
        string chave = "Cript24!";
        int chave_tamanho = chave.Length;

        for (int j = 0; j < chave_tamanho; j++)
        {
            bool letraEncontrada = false;

            for (int i = 0; i <= 127; i++)
            {
                char caractereAtual = (char)i;
                Console.WriteLine($" Testando '{caractereAtual}");

               if (caractereAtual == chave[j])
                {
                    Console.WriteLine($"Encontrou'{chave[j]}");
                    letraEncontrada = true;
                    break; 
                }
            }

           
            if (!letraEncontrada)
            {
                Console.WriteLine($"Chave '{chave}' não encontrada completamente na tabela ASCII.");
                return;
            }
        }

        Console.WriteLine($"Chave '{chave}' encontrada com sucesso.");
    }
}