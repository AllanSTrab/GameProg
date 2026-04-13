using UnityEngine;

public class ExMisto03 : MonoBehaviour
{
    /*9. Sistema de notas com ranking
Crie:
• Um array de nomes de alunos
• Um array de notas
Use for para percorrer os arrays e:
• Mostrar nome + nota
• Usar if para classificar:
o Nota ≥ 9 → "Excelente"
o Nota ≥ 7 → "Bom"
o Senão → "Reprovado"
     */
    string[] nomes = new string[] { "Joao", "Jonathan", "Douglas" };
    int[] notas = new int[] { 7, 9, 3 };
    void Start()
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            print("Aluno: " + nomes[i] + " | Nota " + notas[i]);
            if (notas[i] >= 9)
            {
                print("Excelente");
            }
            else if (notas[i] >= 7)
            {
                print("Bom");
            }
            else
            {
                print("Reprovado");
            }
        }
    }
}
