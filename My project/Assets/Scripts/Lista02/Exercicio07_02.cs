using UnityEngine;

public class Exercicio07_02 : MonoBehaviour
{
    [SerializeField]bool temChave = false;
    void Start()
    {
        /*7. Porta aberta
Crie bool temChave = false;
Se temChave == true, exiba "Porta aberta" senão "Porta trancada".
         */
        if(temChave == true)
        {
            print("Porta aberta");
        }
        else
        {
            print("Porta trancada");
        }
    }

}
