using UnityEngine;

public class Exercicio08 : MonoBehaviour
{
    public int vida = 100;
    public int dano;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*8) Sistema de Dano Dinâmico
Crie:
• public int vida = 100;
• public int dano;
No Start(), diminua a vida pelo dano informado no Inspector e mostre o
resultado.
         */
        print("voce tomou " + dano + " de dano agora você está com: " + (vida - dano));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
