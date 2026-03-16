using UnityEngine;

public class Exercicio08_Lista01 : MonoBehaviour
{
    public int vida = 100;
    int dano;
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
        print("sua vida atual é " + vida);

        dano = Random.Range(1, 21); //1 a 20, o 21 não conta

        print("voce tomou " + dano + " de dano");

        print("agora sua vida é " + (vida - dano));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
