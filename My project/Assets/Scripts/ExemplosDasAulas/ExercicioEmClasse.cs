using UnityEngine;

public class ExercicioEmClasse : MonoBehaviour
{
    [SerializeField]string aluno;
    [SerializeField]float nota1;
    [SerializeField]float nota2;
    [SerializeField]float media;
    void Start()
    {
        print("Aluno: " +  aluno);
        print("Prova 1: " + nota1);
        print("Prova 2: " + nota2);
        media = (nota1 + nota2) / 2;
        print(aluno + " Sua média é: " + media);
        print(aluno + " Você foi aprovado(a)? " + (media >= 6));
        //bool aprovado = media >= 6.0f;
        //print(aluno + " Você foi aprovado(a)? " +  aprovado);
        //print(aluno + " Você foi aprovado(a)? " +  (((nota1+nota2)/2)>=6));
    }

    void Update()
    {
        
    }
}
