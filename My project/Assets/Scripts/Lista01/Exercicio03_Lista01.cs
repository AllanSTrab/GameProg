using UnityEngine;

public class Exercicio03_Lista01 : MonoBehaviour
{
    int Pontos = 10;
    int Multiplicador = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*3) Multiplicação de Pontos
Crie uma variável pontos com valor 10.
Crie uma variável multiplicador com valor 3.
Calcule a pontuação final e mostre no Console.
Use o operador */

        print("você triplicou seus pontos." + " De " + Pontos + " Pontos agora está com: " + (Pontos *  Multiplicador));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
