using UnityEngine;

public class Exercicio08_05 : MonoBehaviour
{
    [SerializeField] int temp;
    void Start()
    {
        /*8. Sistema de Clima no Jogo
Crie uma variável temperatura:
• > 30 → "Clima quente"
• >= 15 → "Clima agradável"
• < 15 → "Clima frio" 
         */
        if (temp > 30)
        {
            print("Clima quente");
        }
        else if (temp >= 15)
        {
            print("Clima agradavel");
        }
        else
        {
            print("Clima frio");
        }
    }

}
