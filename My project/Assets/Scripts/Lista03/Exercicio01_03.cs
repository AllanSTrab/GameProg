using UnityEngine;

public class Exercicio01_03 : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;

    
    void Start()
    {
        /*
         * 1. Crie um programa que:
a. Receba dois números
b. Mostre qual deles é maior.
         */
        print("Número 1: " + a);
        print("Número 2: " + b);
        if (a > b)
        {
            print("O número " + a + " é maior");
        }
        else
        {
            print("O número " + b + " é maior");
        }
    }

}
