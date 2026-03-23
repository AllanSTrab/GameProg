using UnityEngine;

public class Exercicio10_02 : MonoBehaviour
{
    [SerializeField] float tempo = 120f;
    void Start()
    {
        /*
         * 10. Tempo de jogo
Crie float tempo = 120f;
Se tempo <= 0, exiba "Tempo esgotado"
         */
        if(tempo <= 0)
        {
            print("Tempo esgotado");
        }
    }

}
