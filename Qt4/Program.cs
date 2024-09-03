/*-------------------------------------------------------------------
Questão 4: Decisão de Ataque Especial
* Contextualização: Durante uma batalha em um jogo de RPG, o jogador pode realizar um ataque
especial se tiver mana suficiente, se a vida do inimigo estiver baixa e se o nível do jogador for
alto o bastante.
* Comando: Crie um programa que determine se o jogador deve realizar um ataque especial. O
programa deve receber a quantidade de mana do jogador, a vida atual do inimigo em
porcentagem e o nível do jogador. As condições para realizar o ataque especial são:
* Mana maior que 30.
* Vida do inimigo menor que 50%.
* Nível do jogador maior que 5.
@Lista: 02 - Condicionais
@Autor: brenda kelly 
@Data: 01/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    public static void Main(string[] args)
    {
        int quantidadeMana, quantidadeVidaAdversario, nivelJogador;
        
        Console.WriteLine("Informe a quantidade de mana:");
        int.TryParse(Console.ReadLine(), out quantidadeMana);
        
        Console.WriteLine("Informe a quantidade de vida do adversário:");
        int.TryParse(Console.ReadLine(), out quantidadeVidaAdversario);
        
        Console.WriteLine("Informe o seu nível:");
        int.TryParse(Console.ReadLine(), out nivelJogador);
        
        if (quantidadeMana > 30 && quantidadeVidaAdversario < 50 && nivelJogador > 5)
        {
            Console.WriteLine("Ataque Especial realizado");
        }
        else if (quantidadeMana < 30 && quantidadeVidaAdversario < 50 && nivelJogador > 5)
        {
            Console.WriteLine("Mana insuficiente");
        }
        else if (quantidadeMana > 30 && quantidadeVidaAdversario > 50 && nivelJogador > 5)
        {
            Console.WriteLine("Vida do inimigo muito alta");
        }
        else if (quantidadeMana > 30 && quantidadeVidaAdversario < 50 && nivelJogador < 5)
        {
            Console.WriteLine("Nível insuficiente");
        }
    }
}