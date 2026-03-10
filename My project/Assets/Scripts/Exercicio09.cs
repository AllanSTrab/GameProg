using UnityEngine;

public class Exercicio09 : MonoBehaviour
{
    [SerializeField] float A;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*9) Dobro e Metade
Crie uma variável numero.
Mostre:
• O dobro do número.
• A metade do número
         */
        print("O dobro do número " + A + " é = " + (A * 2));
        print("A metade do número " + A + " é = " + (A / 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
