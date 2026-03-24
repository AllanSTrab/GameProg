using UnityEngine;

public class Exercicio09_06 : MonoBehaviour
{
    [SerializeField] int nivel;
    [SerializeField] string equipamento;
    void Start()
    {
        /*9. Sistema de boss
Peça nível e equipamento:
• Se nível >= 20
o Se equipamento == "raro" → "Pronto para o boss"
o Senão → "Arriscado enfrentar o boss"
• Senão → "Muito fraco para o boss"
         */
        if(nivel > 20)
        {
            if(equipamento == "Raro")
            {
                print("Pronto para o Boss");
            }
            else
            {
                print("Arriscado enfrentar o boss");
            }
        }
        else
        {
            print("Muito fraco para o boss");
        }
    }
}
