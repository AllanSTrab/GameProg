using UnityEngine;

public class Exercicio05_02 : MonoBehaviour
{
    [SerializeField] int energia = 30;
    void Start()
    {
        /*5. Sistema de energia
Crie [SerializeField] private int energia = 30;
Se energia for menor que 20, exiba "Sem energia suficiente"
         */
        if(energia < 20)
        {
            print("Sem energia sufiente");
        }
    }

}
