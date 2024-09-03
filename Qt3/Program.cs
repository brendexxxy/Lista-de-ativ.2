/*-------------------------------------------------------------------
Questão 3: Loja de Poções
* Contextualização: Em uma loja de poções mágicas, o jogador pode comprar poções que
aumentam sua vida, mana ou resistência. O preço das poções é fixo: Vida custa 10 moedas,
Mana custa 15 moedas, e Resistência custa 20 moedas. Dependendo da classe do jogador, há
um desconto aplicável.
* Comando: Crie um programa que receba a classe do jogador (Guerreiro, Mago, Paladino), o tipo
de poção (Vida, Mana, Resistência), e a quantidade que deseja comprar. Calcule o preço total
das poções, aplicando o desconto correspondente:
* Guerreiro recebe 10% de desconto na compra de poções de Vida.
* Mago recebe 15% de desconto na compra de poções de Mana.
* Paladino recebe 20% de desconto na compra de poções de Resistência.
* Exiba o preço total com e sem desconto.
@Lista: 02 - Condicionais
@Autor: brenda kelly 
@Data: 01/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    public static void Main(string[] args)
    {
        string classePersonagem, tipoPocao;
        int quantidadePocoes, resultadoSemDesconto;
        double resultadoComDesconto;
        
        Console.WriteLine("Informe a classe do jogador (guerreiro, mago, paladino):");
        classePersonagem = Console.ReadLine();
        
        Console.WriteLine("Informe a poção que deseja comprar (Vida, Mana, Resistência):");
        tipoPocao = Console.ReadLine();
        
        Console.WriteLine("Informe a quantidade de poções:");
        int.TryParse(Console.ReadLine(), out quantidadePocoes);
        
        if (tipoPocao == "vida")
        {
            resultadoSemDesconto = 10 * quantidadePocoes;
            Console.WriteLine($"Resultado sem desconto: {resultadoSemDesconto}");
        }
        else if (tipoPocao == "mana")
        {
            resultadoSemDesconto = 15 * quantidadePocoes;
            Console.WriteLine($"Resultado sem desconto: {resultadoSemDesconto}");
        }
        else if (tipoPocao == "resistencia")
        {
            resultadoSemDesconto = 20 * quantidadePocoes;
            Console.WriteLine($"Resultado sem desconto: {resultadoSemDesconto}");
        }
        
        if (classePersonagem == "guerreiro" && tipoPocao == "vida")
        {
            resultadoSemDesconto = 10 * quantidadePocoes;
            resultadoComDesconto = resultadoSemDesconto - (resultadoSemDesconto * 0.1);
            Console.WriteLine($"Resultado sem desconto: {resultadoSemDesconto}");
            Console.WriteLine($"Resultado com desconto: {resultadoComDesconto}");
        }
        else if (classePersonagem == "mago" && tipoPocao == "mana")
        {
            resultadoSemDesconto = 15 * quantidadePocoes;
            resultadoComDesconto = resultadoSemDesconto - (resultadoSemDesconto * 0.15);
            Console.WriteLine($"Resultado sem desconto: {resultadoSemDesconto}");
            Console.WriteLine($"Resultado com desconto: {resultadoComDesconto}");
        }
        else if (classePersonagem == "paladino" && tipoPocao == "resistencia")
        {
            resultadoSemDesconto = 20 * quantidadePocoes;
            resultadoComDesconto = resultadoSemDesconto - (resultadoSemDesconto * 0.2);
            
            Console.WriteLine($"Resultado sem desconto: {resultadoSemDesconto}");
            
            Console.WriteLine($"Resultado com desconto: {resultadoComDesconto}");
        }
    }
}