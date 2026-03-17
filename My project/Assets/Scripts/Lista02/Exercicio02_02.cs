using UnityEngine;
using UnityEngine.Video;

public class Exercicio02_02 : MonoBehaviour
{
    [SerializeField] private int dano = 10;
    public int vida = 100;
    public int vidaAtual;
    void Start()
    {
        /*2. Dano recebido
Crie uma variável [SerializeField] private int dano = 10; e subtraia de vida.
Se a vida ficar abaixo de 50, mostre "Cuidado!".
         */
        vidaAtual = vida - dano;
        if(vidaAtual >= 50)
        {
            print(vidaAtual);
        }
        else
        {
            print("Cuidado!");
        }
    }


}
