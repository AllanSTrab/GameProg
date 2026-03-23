using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Video;

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
     string Aluno;
     int Idade;
     float Nota;

    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;

    [SerializeField]int x = 200;
    [SerializeField]int y = 50;

    void Start()
    {   /*As chaves é onde mostra onde começa e finaliza a função
        //void start é o que acontece no primeiro frame do código(Depois disso não será mais executado depois)
        O start existe em todo objeto da cena*/
        print("exemplos ops Aritmeticos");
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

        // operadores relacionais, detalhes no script ExOperadores
        print("exemplos ops Relacionais");
        
        print("x= " + x);
        print("y= " + y);
        print("x == y? " + (x == y)); 
        print("x != y? " + (x != y)); 
        print("x > y? " + (x > y)); 
        print("x < y? " + (x < y)); 
        print("x >= y? " + (x >= y)); 
        print("x <= y? " + (x <= y));


        // Operadores Lógicos
        //para mais variaveis
        // && (and), retorna vdd se ambas forem vdd
        // || (or), retorna vdd se uma for vdd
        // ! (not), inverte o resultado da comparação,  se for vdd inverte para falso
        print("exemplos de ops lógicos");
        bool combinação01 = a == b;
        bool combinação02 = a == c;
        bool combMaior = a > b;
        print ("igual é igual ao diferente? " + (combinação01 && combinação02));
        print("diferente é igual ao maior? " + (combinação02 && combMaior));
        print("( ͡° ͜ʖ ͡°)");
        print("diferente é '-' ao maior? " + (combinação01 || combMaior));
        print("igual é '-' ao diferente? " + (combinação01 && combinação02));

        //condicionais

        if (a == b)
        {
            print(a + b);
        }
        else
        {
            print("arpargos");
        }
        // if(Condição) [se for True] roda --> {Código}
        // else(Caso condição = false)

        if (a == c) { }
        else if (a == b) { }
        else { }
        
    }

    void Update()
    {
        //void update é o que acontece em todos os outros frames
    }
}
