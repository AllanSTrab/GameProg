using UnityEngine;

public class Nivel02 : MonoBehaviour
{
    [SerializeField] int n = 0;
    [SerializeField] int vida = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*Nível 2 – Condições com if
5. Mostre números de 1 a 20, mas:
o Se for múltiplo de 3, escreva "Fizz"
o Caso contrário, mostre o número
6. Crie um sistema de vidas:
int vidas = 3;
• Enquanto vidas > 0, mostre "Jogador vivo"
• Quando chegar a 0, mostre "Game Over"
7. Simule um contador de moedas:
• Comece com 0 moedas
• Enquanto moedas < 10
• Some +1 por loop
• Se moedas == 5, mostre "Metade do caminho!" 
         */
        while (n <= 20)
        {
            if (n % 3 == 0)
            {
                print("Fizz");
            }
            else
            {
                print(n);
            }
            n++;
        }
        print("Fim 01");
        while (vida >= 0)
        {
            if (vida > 0)
            {
                print("Jogador vivo");
                print(vida);
            }
            else
            {
                print("Game Over");
            }
            vida--;
        }
        print("Fim 02");
        int moeda = 0;
        while(moeda <= 10)
        {
            print(moeda + " Moedas");
            if (moeda == 5)
            {
                print("Metade do caminho");
            }
            moeda++;
        }
    }
}
