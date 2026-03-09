using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class Teste: MonoBehaviour
{
    /* VARIÁVEIS: O acesso da váriavel padrão é privado
          Váriavel é um espaço de alocação de memória
          Texto+números(pré-definidos) = string, 
          Números = inteiro=int, quebrado=float
          O "[SerializeField]" transforma Váriaveis privadas para que possam ser manipuladas pela interface da Unity
     PRIMEIRA LINHA: Using UnityEngine, essa é a biblioteca do código(sempre vem primeiro)
     SEGUNDA LINHA: Classe herda o script depois dos dois pontos(ex: MonoBehaviour)
     OPERADORES: Matemático: Somar +, Subtração -, Multiplicação *, Divisão /, Módulo(Resto da Divisão, Número inteiro sem vírgula) % */
    [SerializeField] private string Aluno;
    [SerializeField] private int Idade;
    [SerializeField] private float Nota;

    [SerializeField] int a;
    [SerializeField] int b;

    void Start()
    {   /*As chaves é onde mostra onde começa e finaliza a função
        //void start é o que acontece no primeiro frame do código(Depois disso não será mais executado depois)
        O start existe em todo objeto da cena*/
        print("exemplos ops Matematico");
        int c = 0;
        c = a + b;
        print("Soma de a + b: " + c);
        // esse + soma uma string com outra variavel(Operador de somar)
        c = a - b;
        print("subtração de a - b: " + c);
        //Operador de subtração
        c = (a + b) / 2;
        print("Divisão de (a+b)/2: " + c);
        c = (a + b) % 2;
        print("sobrou: " + c);
        // operador de divisão e módulo

        print("exemplos ops Relacionais");
        int x = 200;
        int y = 50;
        print("x= " + x);
        print("y= " + y);
        print("x == y? " + (x == y));
        print("x != y? " + (x != y));
        print("x > y? " + (x > y));
        print("x < y? " + (x < y));
        print("x >= y? " + (x >= y));
        print("x <= y? " + (x <= y));

    }

    void Update()
    {
        //void update é o que acontece em todos os outros frames
    }
}
