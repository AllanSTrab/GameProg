using UnityEngine;

public class Exercicio12_02 : MonoBehaviour
{
    [SerializeField]bool temArma = true;
    [SerializeField]bool temMunicao = false;
    void Start()
    {
        /*12. Verificação dupla (AND)
Crie bool temArma = true; e bool temMunicao = false;
Se ambos forem verdadeiros, exiba "Pode atirar"
         */
        if(temArma == true && temMunicao == true)
        {
            print("Pode Atirar");
        }
        else if (temArma == false && temMunicao == true)
        {
            print("Sem arma");
        }
        else if(temArma == true && temMunicao == false)
        {
            print("Sem munição");
        }
        else
        {
            print("Tem nada");
        }
    }

}
