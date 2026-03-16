using UnityEngine;

public class Exercicio04_Lista01 : MonoBehaviour
{
    int moedas = 50;
    int personagens = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*4) Divisão de Recursos
O jogador tem 50 moedas e precisa dividir entre 5 personagens.
Calcule quantas moedas cada um recebe.
Use o operador */
        print("você dividiu suas moedas com amigos, de " + moedas + " moedas, agora esta com " + (moedas / personagens));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
