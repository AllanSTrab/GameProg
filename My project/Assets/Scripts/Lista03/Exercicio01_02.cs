using UnityEngine;

public class Exercicio01_02 : MonoBehaviour
{
    public int vida = 100;
    void Start()
    {
        /*1. Vida do personagem
Crie um script com uma variável public int vida = 100;.
Use um if para verificar: se a vida for menor ou igual a 0, exiba "Game Over" no
console
         */
        if (vida <= 0)
        {
            print("game over!");
        }
    }


}
