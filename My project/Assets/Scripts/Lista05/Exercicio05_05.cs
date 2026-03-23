using UnityEngine;

public class Exercicio05_05 : MonoBehaviour
{
    [SerializeField] float velocidade;
    void Start()
    {
        /*5. Verificação de Velocidade
Crie uma variável velocidade (float):
• Se for maior que 10 → "Muito rápido"
• Entre 5 e 10 → "Velocidade média"
• Menor que 5 → "Muito lento" 
         */
        if ( velocidade > 10 )
        {
            print("Muito rapido");
        }
        else if ( velocidade <= 10 && velocidade >= 5)
        {
            print("Velocidade Media");
        }
        else
        {
            print("Muito lento");
        }
    }

}
