using UnityEngine;

public class Exercicio03_02 : MonoBehaviour
{
    public int pontos;
    void Start()
    {
        /*3. Sistema de pontuação
Crie public int pontos;
Se pontos forem maiores que 100, mostre "Você venceu!"
         */
        if ( pontos >= 100)
        {
            print("Você venceu!");
        }
    }

}
