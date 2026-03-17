using UnityEngine;

public class Exercicio09_02 : MonoBehaviour
{
    [SerializeField] private int moedas = 50;
    void Start()
    {
        /*9. Sistema de moedas
Crie [SerializeField] private int moedas = 50;
Se moedas >= 100, exiba "Pode comprar item".
         */
        if(moedas >= 100)
        {
            print("Pode comprar item");
        }
        else
        {
            print("Ta pobre");
        }
    }

}
