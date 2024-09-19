﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

Stack<int> senhas = new Stack<int>();

Random random = new Random();

senhas.Push(123);
senhas.Push(548);
senhas.Push(178);
senhas.Push(489);
senhas.Push(925);
senhas.Push(0);

senhas.Pop();

Random aleatorio = new Random();
int tempoTotal = 0;
int tempoRestante = 0;

// Loop While para manter o jogo em execução
while (true)
{
    // Condição para iniciar o jogo (ENTER) ou sair (qualquer tecla)
    if (tempoRestante <= 0)
    {
        Console.WriteLine("Pressione a tecla [*ENTER*] para começar o jogo\n\n");
        Console.WriteLine("Pressione qualquer outra tecla para sair...");

        // Se a tecla apertada não for ENTER, o jogo é encerrado
        if (Console.ReadKey().Key != ConsoleKey.Enter)
        {
            return;
        }

        // Se o ENTER tiver sido apertado inicia o jogo
        foreach(object obj in senhas)
        {
            Console.WriteLine(obj);
        }

        if (senhas.Count > 0)
        {
            // Pop the top element and print it
            int poppedElement = senhas.Pop();
            Console.WriteLine("Popped element: " + poppedElement);
        }

        
    }
}

