using UnityEngine;

public class Exercicio06_05 : MonoBehaviour
{
    [SerializeField] int moedas;
    [SerializeField] int custoItem;
    void Start()
    {
        /*6. Sistema de Compra no Jogo
Crie variáveis:
• moedas (int)
• custoItem (int)
Verifique:
• Se moedas >= custoItem → "Compra realizada"
• Senão → "Moedas insuficientes" 
         */
        if (moedas >= custoItem)
        {
            print("Compra realizada");
        }
        else
        {
            print("Moedas insuficientes");
        }
    }

}
