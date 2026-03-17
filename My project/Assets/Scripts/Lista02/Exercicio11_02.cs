using UnityEngine;

public class Exercicio11_02 : MonoBehaviour
{
    [SerializeField] bool estaNoChao = true;
    void Start()
    {
        /*11. Sistema de pulo
Crie bool estaNoChao = true;
Se estiver no chão, exiba "Pode pular".
         */
        if(estaNoChao == true)
        {
            print("pode pular");
        }
    }

}
