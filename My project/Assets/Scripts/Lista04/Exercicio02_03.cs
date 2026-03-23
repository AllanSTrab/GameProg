using UnityEngine;

public class Exercicio02_03 : MonoBehaviour
{
    [SerializeField] int idade;
    
    void Start()
    {
        /*
         2. Faça um programa que:
a. Receba a idade
b. Verifique se a pessoa é maior de idade (18+).
         */
        if (idade >= 18)
        {
            print("Você pode entrar");
        }
        else
        {
            print("Você é de menor, n poderás passar");
        }
    }


}
