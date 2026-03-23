using System.Security.Cryptography;
using UnityEngine;

public class CondicionalEncadeado : MonoBehaviour
{
    int dadoJogador1;
    int dadoJogador2;

    int placarJogador1;
    int placarJogador2;
    void Update()
    {
        if (Input.anyKeyDown)
        {
            //Valida a partida
            if (placarJogador1 <= 3 || placarJogador2 <= 3)
            {
                //gera os numeros dos dados do jogador aleatóriamente
                dadoJogador1 = Random.Range(1, 21);
                dadoJogador2 = Random.Range(1, 21);

                //verifica o resultado da rodada
                if (dadoJogador1 == dadoJogador2)
                {
                    print("Empate");
                }
                else
                {

                    if (dadoJogador1 > dadoJogador2)
                    {
                        placarJogador1 += 1;
                        print("jogador 1 venceu a rodada");
                    }
                    else
                    {
                        placarJogador2 += 1;
                        print("jogador 2 venceu a rodada");
                    }
                    print(placarJogador1);
                    print(placarJogador2);
                    print("----------------------");
                }
            }
            else
            {
                {
                    //termina a partida e verifica qm ganhou
                    if(placarJogador1 > placarJogador2)
                    {
                        print("Jogador 1 venceu");
                    }
                    else
                    {
                        print("Jogador 2 venceu");
                    }
                }
            }
        }
    }
}
