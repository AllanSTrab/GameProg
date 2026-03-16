    using UnityEngine;

public class Exercicio03_03 : MonoBehaviour
{
    [SerializeField] int numero;
    [SerializeField] int sobra;
    
    void Start()
    {
        /*2. Faça um programa que:
a. Receba a idade
b. Verifique se a pessoa é maior de idade (18+).
         */
        sobra = numero % 2;
        if (sobra == 0)
        {
            print("Esse número é par");
        }
        else
        {
            print("Esse número é ímpar");
        }
    }


}
