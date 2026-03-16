using UnityEngine;

public class Condicional : MonoBehaviour
{
    [SerializeField] string aluno;
    [SerializeField] float nota1;
    [SerializeField] float nota2;

    void Start()
    {
        float media = (nota1 + nota2) / 2;

        print("Sua média é: " + media);

        if (media >= 6.0f)
        {
            print(aluno + " Você foi aprovado");
        }
        else
        {
            print(aluno + " Você foi reprovado");
        }

    }

}
