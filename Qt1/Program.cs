/*-------------------------------------------------------------------
Questão 1: Seleção de Armadura
* Contextualização: Em um jogo de RPG, cada classe de personagem (Guerreiro, Arqueiro, Mago)
possui requisitos diferentes para a escolha da armadura ideal. A armadura é considerada ideal
se a defesa oferecida for alta o suficiente para a classe e se a penalidade de agilidade for
aceitável.
* Comando:
Crie um programa que receba a classe do personagem, o valor de defesa da armadura e a
penalidade de agilidade. O programa deve informar se a armadura é adequada ou não para a
classe.
* Para o Guerreiro, a defesa deve ser maior que 50 e a penalidade de agilidade menor que 20.
* Para o Arqueiro, a defesa deve ser maior que 30 e a penalidade de agilidade menor que 10.
* Para o Mago, a defesa deve ser maior que 20 e a penalidade de agilidade menor que 40.
@Lista: 02 - Condicionais
@Autor: brenda kelly 
@Data: 01/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    static void Main()
    {
        string tipoClasse;
        int pontosDefesa, reducaoAgilidade;

        Console.WriteLine("Informe a classe do personagem: ");
        tipoClasse = Console.ReadLine();

        Console.WriteLine("Informe o valor da defesa: ");
        int.TryParse(Console.ReadLine(), out pontosDefesa);

        Console.WriteLine("Informe a penalidade de agilidade: ");
        int.TryParse(Console.ReadLine(), out reducaoAgilidade);

        if (tipoClasse == "guerreiro")
        {
            if (pontosDefesa > 50 && reducaoAgilidade < 20)
            {
                Console.WriteLine("Armadura adequada");
            }
        }
        else if (tipoClasse == "arqueiro")
        {
            if (pontosDefesa > 30 && reducaoAgilidade < 10)
            {
                Console.WriteLine("Armadura adequada");
            }
        }
        else if (tipoClasse == "mago")
        {
            if (pontosDefesa > 20 && reducaoAgilidade < 40)
            {
                Console.WriteLine("Armadura adequada");
            }
        }
        else
        {
            Console.WriteLine("Armadura inadequada");
        }
    }
}