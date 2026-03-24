using UnityEngine;

public class Exercicio07_06 : MonoBehaviour
{
    [SerializeField] int energia;
    void Start()
    {
        /*Peça energia:
• Se energia > 80
o Se energia == 100 → "Energia máxima"
o Senão → "Energia alta"
• Senão
o Se energia > 40 → "Energia média"
o Senão → "Energia baixa" 
         */
        if(energia > 80)
        {
            if(energia == 100)
            {
                print("Energia Cheia");
            }
            else
            {
                print("Energia Alta");
            }
        }
        else
        {
            if(energia > 30)
            {
                print("Energia Média");
            }
            else
            {
                print("Energia Baixa");
            }
        }
    }
}
