using System.Numerics;

namespace teste_target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "eu quero entrar na tArget";
            int contA = 0;

            for (int i = 0; i < texto.Length; i++) //o for vai percorrer o texto
            {
                if (texto[i] == 'a' || texto[i] == 'A')//se "a" ou "A" for encontrado, vai ser incrementado no contA
           
                    contA++;
               
            }

            Console.WriteLine($"A letra 'A' apareceu um total de {contA} vezes na string");
        }
    }
}
