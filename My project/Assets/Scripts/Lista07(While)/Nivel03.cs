using UnityEngine;

public class Nivel03 : MonoBehaviour
{
    int n = 0;
    int soma = 0;
    int a = 0;
    int b = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*8. Crie um while que some números de 1 até 100 e mostre o total final.
9. Faça um sistema que pare quando encontrar um número específico:
• Comece em 0
• Vá somando +1
• Se o número for 7, pare o loop (break)
10. Crie um loop que:
• Vai de 1 até 20
• Se o número for par, imprime "Par"
• Se for ímpar, imprime "Ímpar"
         */
        while(n <= 100)
        {
            soma += n;
            n++;
        }
        print("O total é " + soma);
        print("Fim 01");
        while(true)
        {
            a++;
            print(a);
            if(a == 7)
            {
                break;
            }
        }
        print("Fim 02");
        while(b < 20)
        {
            if(b % 2 == 0)
            {
                print("Par");
            }
            else
            {
                print("Impar");
            }
            b++;
        }
    }
}
