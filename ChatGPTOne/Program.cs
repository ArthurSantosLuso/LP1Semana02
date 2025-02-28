using System;
using System.Threading;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                string resposta = "";

                // Pedir uma pergunta ao utilizador 
                Console.Write("Insira uma pergunta: ");
                string pergunta = Console.ReadLine();

                // Casos de respostas a perguntas 
                switch (pergunta)
                {
                    case "Quantos anos tens?":
                        resposta = "O suficiente para lhe responder todas as perguntas.";
                        break;

                    case "Qual a sensação de ser uma IA":
                        resposta = "A mesmsa que ser uma formiga, eu não sei.";
                        break;

                    case "Qual a melhor forma de fazer dinheiro?":
                        resposta = "Entre na politica e pege fundão eleitoral.";
                        break;

                    case "Porque o mundo é uma bola?":
                        resposta = "A terra é plana.";
                        break;
                }
            }
        }
    }
}
