using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Exercicio2 : MonoBehaviour
{
    int vida = 100;
    int dano = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*2) Subtração de Vida
        Crie uma variável vida com valor 100.
Crie uma variável dano com valor 25.
Subtraia o dano da vida e mostre o resultado.
Use o operador -.*/
        print("Você tomou dano sua vida é: " + (vida - dano));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
