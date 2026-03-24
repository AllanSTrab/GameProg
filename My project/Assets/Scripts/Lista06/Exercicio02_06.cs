using UnityEngine;

public class Exercicio02_06 : MonoBehaviour
{
    [SerializeField] bool temArma;
    [SerializeField] int forca;
    void Start()
    {
        /*2. Ataque em combate
Peça se tem arma e força:
• Se tem arma
o Se força > 50 → "Ataque forte"
o Senão → "Ataque médio"
• Senão
o Se força > 50 → "Ataque improvisado forte"
o Senão → "Ataque fraco"
         */
        if (temArma == true)
        {
            if(forca > 50)
            {
                print("Ataque Forte");
            }
            else
            {
                print("Ataque Médio");
            }
        }
        else
        {
            if (forca > 50)
            {
                print("Ataque improvisado Forte");
            }
            else
            {
                print("Ataque fraco");
            }
        }
    }
}
