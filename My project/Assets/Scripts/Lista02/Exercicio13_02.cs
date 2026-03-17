using UnityEngine;

public class Exercicio13_02 : MonoBehaviour
{
    [SerializeField] bool temChave = false;
    [SerializeField] bool portaDestravada = true;
    void Start()
    {
        /*13. Verificação alternativa (OR)
Crie bool temChave = false; e bool portaDestravada = true;
Se um dos dois for verdadeiro, exiba "Acesso permitido".
         */
        if (temChave == true || portaDestravada == true)
        {
            print("Acesso permitido");
        }
        else
        {
            print("Acesso Negado");
        }
    }

}
