using UnityEngine;

public class Repetição06 : MonoBehaviour
{
    int qntDePares = 0;
    int qntDeTentativas = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        while (qntDePares < 6)
        {
            int n = Random.Range(1, 100);
            qntDeTentativas++;
            if (n % 2 == 0)
            {
                qntDePares++;
                print("Número par: " + n + " | Quantidade de pares: " + qntDePares);
            }
        }
        print("Quantidade de tentativas: " + qntDeTentativas);
    }
}
