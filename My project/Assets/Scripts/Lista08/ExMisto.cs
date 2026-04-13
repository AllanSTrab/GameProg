using UnityEngine;

public class ExMisto : MonoBehaviour
{
    /*7. Contar números pares
Crie um array com 10 números inteiros e use um for para percorrer o vetor.
Conte quantos números são pares e mostre o resultado.
     */
    [SerializeField] int[] num = new int[] {1,2,3,4,5,6,7,8,9,10};
    int numPar = 0;
    void Start()
    {
        for (int i = 0; i < num.Length; i++)
        {
            if(num[i] % 2 == 0)
            {
                numPar++;
            }
        }
        print("Há " + numPar + " Números pares na lista");
    }
}
