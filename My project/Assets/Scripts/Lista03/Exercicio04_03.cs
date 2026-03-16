using UnityEngine;

public class Exercicio04_03 : MonoBehaviour
{
    [SerializeField] float a;
    [SerializeField] float b;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*4. Peça dois números e:
a. Verifique se eles são iguais ou diferentes.
         */
        if (a == b)
        {
            print("Os números " + a + " e " + b + " são iguais");
        }
        else 
        {
            print("Os números " + a + " e " + b + " são diferentes");
        }
    }

}
