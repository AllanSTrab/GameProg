using UnityEngine;

public class ExArrayVetor02 : MonoBehaviour
{
    /*5. Maior número do array
Crie um array com 10 números inteiros (valores definidos no código) e descubra qual é
o maior número.
     */
    int valorAnterior;
    [SerializeField] int[] num = new int[] { 1, 2, 3, 14, 5, 6, 7, 8, 9, 10 };
    
    void Start()
    {
        int NumMaior = num[0];

        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] > NumMaior)
            {
                NumMaior = num[i];
            }
        }
        print("O maior número é " + NumMaior);
    }
}
