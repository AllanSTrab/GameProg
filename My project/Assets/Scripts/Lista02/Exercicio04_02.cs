using UnityEngine;

public class Exercicio04_02 : MonoBehaviour
{
    public float velocidade = 5f;
    void Start()
    {
        /*4. Verificação de velocidade
Crie private float velocidade = 5f;
Se velocidade > 10, exiba "Muito rápido!", senão "Velocidade normal".
         */
        if (velocidade > 10)
        {
            print("Muito Rápido!");
        }
        else 
        {
            print("Velocidade normal");
        }
    }

}
