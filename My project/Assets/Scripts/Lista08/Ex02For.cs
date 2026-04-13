using UnityEngine;

public class Ex02For : MonoBehaviour
{
    int soma = 0;
    void Start()
    {
        /*2. Soma de números
        Faça um script que some todos os números de 1 a 100 e mostre o resultado no Console.
        Desafio extra: mostre também a média desses números.
         */

        int x;

        for (x = 0; x <= 100; x++)
        {            
            soma = soma + x;
            print("A soma dos números de 1 a 100 são: " + soma);
        }
        print("A média é " + soma / x);
    }
}
