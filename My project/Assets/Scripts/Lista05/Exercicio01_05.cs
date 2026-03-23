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

        //Ex: a porta esta fechada se sim pergunta se tem a chave, senão n precisa.
        /*
        if (numero == 0)
        {
            print(numero + " é zero");
        }
        else
        {
            if (numero > 0)
            {
                print(numero + " é positivo");
            }
            else
            {
                print(numero + " é negativo");
            }
        }
        */
    }

}
