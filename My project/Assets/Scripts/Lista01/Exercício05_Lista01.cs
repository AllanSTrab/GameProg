using UnityEngine;

public class Exercício05_Lista01 : MonoBehaviour
{
    int a = 17;
    int b = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*5) Resto da Divisão (Módulo)
Crie um código que mostre o resto da divisão de 17 por 4.
Use o operador %.*/
        print("a divisão de a/b é " + (a/b));
        print("e seu resto é " + (a % b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
