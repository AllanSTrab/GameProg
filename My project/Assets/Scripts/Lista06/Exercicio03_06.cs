using UnityEngine;

public class Exercicio03_06 : MonoBehaviour
{
    [SerializeField] int hp;
    void Start()
    {
        /*3. Sistema de vida
Peça HP:
• Se HP > 70
o Se HP == 100 → "Vida cheia"
o Senão → "Saudável"
• Senão
o Se HP > 30 → "Ferido"
o Senão → "Crítico"
         */
        if(hp > 70)
        {
            if(hp == 100)
            {
                print("Vida cheia");
            }
            else
            {
                print("Saudavel");
            }
        }
        else
        {
            if( hp > 30)
            {
                print("Ferido");
            }
            else
            {
                print("Crítico");
            }
        }
    }

}
