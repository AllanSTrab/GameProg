using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class ExArrayVetor03 : MonoBehaviour
{
    /*6. Média de notas
Crie um array com 4 notas de um aluno e calcule a média.
Mostre no Console:
• A média
• Se o aluno foi aprovado (média ≥ 7)
     */
    [SerializeField] int[] notas = new int[] { 6, 9, 4, 8 };
    void Start()
    {
        float soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            soma = soma + notas[i];
        }
        print(soma / notas.Length);
        if (soma/notas.Length >= 7)
        {
            print("Aprovado");
        }
        else
        {
            print("Reprovado");
        }
    }
}
