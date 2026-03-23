using UnityEngine;

public class Exercicio03_05 : MonoBehaviour
{
    [SerializeField] int vida = 100;
    void Start()
    {
        /*3. Sistema de Vida do Jogador
Crie uma variável vida (int).
• Se vida > 0, mostre "Jogador vivo"
• Caso contrário, mostre "Game Over" 
         */
        if (vida > 0)
        {
            print("Jogador vivo");
        }
        else
        {
            print("Game Over");
        }
    }

}
