using UnityEngine;

public class ExOperadores : MonoBehaviour
{
    //EX 1: [SerializeField] int a;
    //      [SerializeField] float b;
    //      [SerializeField] float c;
    //      private float resultadoFloat;
    //      private int resultadoInt;

    // Operadores Relacionais ==(igual) Sempre booleano(verdadeiro ou falso), ex: a=1 b=2 a==b falso
    // !=(Diferente), ex: a!=b verdadeiro
    // >(Maior), ex: a>b falso
    // <(Menor), ex: a<b verdadeiro
    // >=(Maior ou igual)(o igual sempre vem depois, ex: falso ou verdadeiro, a>=b falso, a<=b verdadeiro, c=2 b>=c verdadeiro
    // (v ou f, f ou v ou v ou v; para que o resultado seja Verdadeiro)
    void Start()
    {
        //Parte do EX 1: resultadoFloat = b+c;
        //  resultadoFloat = a+c;
        //  resultadoInt = b+c; (ímpossivel porque Int n recebe decimal só inteiro)
    }

    void Update()
    {
        
    }
}
