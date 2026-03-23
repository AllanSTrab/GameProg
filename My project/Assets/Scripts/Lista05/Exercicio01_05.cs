using UnityEngine;

public class Exercicio01_05 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
        /*1. Verificação de Número Positivo, Negativo ou Zero
Crie um script que receba um número inteiro e informe:
• Se é maior que 0 → "Número positivo"
• Se é menor que 0 → "Número negativo"
• Caso contrário → "Zero"
         */
        if (numero == 0)
        {
            print("Esse numero é 0");
        }
        else if(numero < 0)
        {
            print("Esse numero é negativo");
        }
        else
        {
            print("Esse numero é positivo");
        }
    }

}
