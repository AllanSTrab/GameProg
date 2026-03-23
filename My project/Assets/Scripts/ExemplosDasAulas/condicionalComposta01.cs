using UnityEngine;

public class condicionalComposta01 : MonoBehaviour
{
    [SerializeField] string classePersonagem;
    void Start()
    {
        if (classePersonagem == null)
        {
            print("informe a classe");
        }
        else if (classePersonagem == "1")
        {
            print("Você escolheu o mago");
        }
        else if (classePersonagem == "2") 
        {
            print("Você escolheu o arqueiro");
        }
        else if (classePersonagem == "3")
        {
            print("Você escolheu o Bárbaro");
        }
        else
        {
            print("Classe não encontrada");
        }
    }

}
