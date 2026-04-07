using UnityEngine;

public class Nivel01 : MonoBehaviour
{
    [SerializeField]int numero = 0;
    [SerializeField]int numero2 = 11;
    [SerializeField] int numero3 = 0;
    void Start()
    {
        /*1. Crie um while que imprima números de 0 até 10 no console.
2. Faça um while que conte de 10 até 0 (contagem regressiva).
3. Crie uma variável energia = 5
Use while para diminuir a energia até chegar em 0, exibindo o valor.
4. Faça um while que mostre apenas números pares de 0 a 20. 
         */
        while(numero < 10)
        {
            numero++;
            print(numero);
        }
        print("Fim 01.");
        while(numero2 > 0)
        {
            numero2--;
            print(numero2);
        }
        print("Fim 02");
        int energia = 5;
        while(energia > 0)
        {
            energia--;
            print(energia + " De energia");
        }
        print("Fim 03");
        print("Numeros Pares");
        while(numero3 <= 20)
        {
            if(numero3 % 2 == 0)
            {
                print(numero3);
            }
            numero3++;
        }
    }

}
