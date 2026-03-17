using UnityEngine;

public class Exercicio08_02 : MonoBehaviour
{
    [SerializeField]int nivelJogador = 5;
    int nivelInimigo = 8;
    void Start()
    {
        /*8. Comparação de níveis
Crie int nivelJogador = 5; e int nivelInimigo = 8;
Se jogador >= inimigo, exiba "Pode lutar", senão "Muito perigoso".
         */
        if(nivelJogador >= nivelInimigo)
        {
            print("Pode lutar");
        }
        else
        {
            print("Muito perigoso");
        }
    }

}
