using JetBrains.Annotations;
using UnityEngine;

public class Exercicio04_05 : MonoBehaviour
{
    [SerializeField] int pontuacao;
    void Start()
    {
        /*4. Sistema de Pontuação
Com base em uma variável pontuacao:
• >= 100 → "Rank S"
• >= 70 → "Rank A"
• >= 50 → "Rank B"
• Senão → "Rank C" 
         */
        if (pontuacao >= 100)
        {
            print("Rank S");
        }
        else if (pontuacao >= 70)
        {
            print("Rank A");
        }
        else if (pontuacao >= 50)
        {
            print("Rank B");
        }
        else
        {
            print("Rank C");
        }
    }

}
