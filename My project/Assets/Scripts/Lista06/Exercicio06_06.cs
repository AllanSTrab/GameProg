using UnityEngine;

public class Exercicio06_06 : MonoBehaviour
{
    [SerializeField] int inimigosDerrotados;
    [SerializeField] int tempo;
    void Start()
    {
        /*6. Missão concluída
Peça inimigos derrotados e tempo:
• Se inimigos >= 10
o Se tempo < 5 → "Missão perfeita"
o Senão → "Missão completa"
• Senão
o Se inimigos >= 5 → "Missão parcial"
o Senão → "Missão falhou"
         */
        if(inimigosDerrotados >= 10)
        {
            if(tempo < 5)
            {
                print("Missão Perfeita");
            }
            else
            {
                print("Missão Completa");
            }
        }
        else
        {
            if(inimigosDerrotados >= 5)
            {
                print("Missão Parcial");
            }
            else
            {
                print("Missão Falhou");
            }
        }
    }

}
