using UnityEngine;

public class ExArrayVetor01 : MonoBehaviour
{
    /*4. Armazenando nomes
Crie um array com 5 nomes e imprima todos no Console.
Desafio extra: peça para o usuário escolher um índice e mostre o nome correspondente
     */

    [SerializeField] int escolhaIndice;

    [SerializeField] string[] nomes = new string[] {"a", "b", "c", "d", "e"};
    void Start()
    {
        print(nomes[escolhaIndice]);

        for (int i = 0; i < nomes.Length; i++)
        {
            print(nomes[i]);
        }
    }
}
