using UnityEngine;

public class Exercicio10_05 : MonoBehaviour
{
    [SerializeField] int vidaJogador;
    [SerializeField] int vidaInimigo;
    void Start()
    {
        /*10. Sistema de Combate Simples
Crie variáveis:
• vidaJogador
• vidaInimigo
Verifique:
• Se ambos > 0 → "Combate em andamento"
• Se jogador <= 0 → "Jogador derrotado"
• Se inimigo <= 0 → "Inimigo derrotado"
         */
        if (vidaJogador > 0 && vidaInimigo > 0)
        {
            print("Combate em andamento");
        }
        else if(vidaInimigo <= 0 && vidaJogador <= 0)
        {
            print("Combate empatado");
        }
        else if (vidaJogador <= 0)
        {
            print("Jogador derrotado");
        }
        else
        {
            print("Inimigo derrotado");
        }
    }

}
