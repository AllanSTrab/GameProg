using UnityEngine;

public class ExMisto02 : MonoBehaviour
{
    /*8. Sistema de inventário simples
Crie dois arrays:
• string[] itens
• int[] quantidades
Use um for para mostrar todos os itens e suas quantidades.
Use if para avisar quando algum item estiver com quantidade menor que 5:
"Item X está com estoque baixo!"
     */
    string[] itens = new string[] {"Pocao de mana", "Pocao de cura", "Pocao de velocidade", "Pocao de forca"};
    int[] quantidades = new int[] {6, 4, 2, 7};
    void Start()
    {
        for(int i = 0; i < itens.Length; i++)
        {
            print("Item: " + itens[i] + " | Quantidades: " + quantidades[i]);
            if(quantidades[i] < 5)
            {
                print("Item " + itens[i] + " está com estoque baixo");
            }
        }
    }
}
