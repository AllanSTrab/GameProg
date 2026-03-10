using JetBrains.Annotations;
using System.Data.SqlTypes;
using System.Drawing;
using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] float salario = 1000f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*10) Aumento Percentual
Crie uma variável salario = 1000f.
Aumente 10 % no salário e mostre o valor final.
Dica:
        salario + (salario * 0.10f)*/
        print("Você conseguiu um aumento agora seu salária está em: " + (salario + (salario * 0.10f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
