using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!
            var campoMinadoAux = new CampoMinado();
            String stringTratada;

            int cont = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int y = 1; y < 10; y++)
                {
                    campoMinadoAux.Abrir(i, y);                       
                }
            }

            stringTratada = campoMinadoAux.Tabuleiro.Replace("\r", "").Replace("\n", "");
            

            for(int i = 1; i < 10; i++)
            {
                for (int y = 1; y < 10; y++)
                {
                    if (!stringTratada[cont].ToString().Contains('*'))
                    {
                        campoMinado.Abrir(i, y);
                    }
                    cont++;
                }
            }
            Console.WriteLine("\nResultado\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);
            Console.WriteLine("\nStatus do jogo: " + campoMinado.JogoStatus);
        }
    }
}
