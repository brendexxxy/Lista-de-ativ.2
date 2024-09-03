/*---------------------------------------------------------------------
Questão 2: Sistema de Pontuação em Batalha
* Contextualização: Em um jogo de RPG, o jogador ganha pontos após derrotar inimigos em uma
batalha. A pontuação máxima é de 100 pontos, e é determinada pela quantidade de inimigos
derrotados, a duração da batalha e se o jogador sofreu danos crítico.
* Comando: Crie um programa que calcule a pontuação final do jogador. O programa deve
receber o número de inimigos derrotados, a duração da batalha em minutos e se o jogador
sofreu danos crítico (sim ou não). A pontuação é calculada da seguinte forma:
* 10 pontos para cada inimigo derrotado;
* Subtraia 10 pontos se a batalha durar mais de 5 minutos;
* Subtraia 10 pontos se o jogador sofreu dano crítico;
@Lista: 02 - Condicionais
@Autor: brenda kelly 
@Data: 01/09/2024
---------------------------------------------------------------------*/
using System;

class Program
{
    public static void Main()
    {
        int inimigosDerrotados, duracaoBatalha, totaisPontos, pontosFinais;
        string sofreuDanoCritico;

        Console.WriteLine("Número de inimigos derrotados:");
        int.TryParse(Console.ReadLine(), out inimigosDerrotados);
      
        Console.WriteLine("Duração da batalha em minutos:");
        int.TryParse(Console.ReadLine(), out duracaoBatalha);
        
        Console.WriteLine("Sofreu dano crítico (sim/não):");
        sofreuDanoCritico = Console.ReadLine();
        
        totaisPontos = inimigosDerrotados * 10;
        
        if (duracaoBatalha > 5)
        {
           pontosFinais = totaisPontos - 10;
           Console.WriteLine($"O resultado final: {pontosFinais}");
           
           if (pontosFinais > 100)
           {
               Console.WriteLine("O resultado final é igual a: 100");
           }
        }
        
        if (sofreuDanoCritico == "sim")
        {
            pontosFinais = totaisPontos - 10;
            Console.WriteLine($"O resultado final: {pontosFinais}");
            
            if (pontosFinais > 100)
            {
                Console.WriteLine("O resultado final é igual a: 100");
            }
        }
        
        if (totaisPontos > 100)
        {
            Console.WriteLine("O resultado final é igual a: 100");
        }
        else
        {
            Console.WriteLine($"O resultado final é igual a: {totaisPontos}");
        }
    }    
}