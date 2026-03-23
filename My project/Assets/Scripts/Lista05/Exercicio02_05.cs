using UnityEngine;

public class Exercicio02_05 : MonoBehaviour
{
    [SerializeField] float a, b, c;
    void Start()
    {
        /*2. Comparação de Três Números
Declare três variáveis float e mostre qual delas é a maior.
         */
        if (a>b && a > c)
        {
            print("O numero " + a + " é o maior");
        }
        else if (b > c && b>a)
        {
            print("O numero " + b + " é o maior");
        }
        else
        {
            print("O numero " + c + " é o maior");
        }
    }

}
