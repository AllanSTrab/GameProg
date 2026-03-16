using UnityEngine;

public class Condicional02 : MonoBehaviour
{
    public int vida = 100;

    void Start()
    {
        if (vida > 0)
        {
            print("Personagem está em jogo");
        }
        else
        {
            print("Fim de jogo");
        }
        
    }

}
