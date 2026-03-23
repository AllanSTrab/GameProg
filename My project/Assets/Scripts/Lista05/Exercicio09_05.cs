using UnityEngine;

public class Exercicio09_05 : MonoBehaviour
{
    [SerializeField] bool temChave;
    [SerializeField] int nivel;
    void Start()
    {
        /*9. Acesso a Área Restrita
Crie variáveis:
• temChave (bool)
• nivel (int)
Permita acesso apenas se:
• temChave == true e nivel >= 5
         */
        if (temChave == true && nivel >= 5)
        {
            print("Acesso permitido");
        }
        else
        {
            print("Acesso negado");
        }
    }

}
