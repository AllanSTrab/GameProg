using UnityEngine;

public class Exercicio06_02 : MonoBehaviour
{
    int danoBase = 10;
    bool critico = true;
    void Start()
    {
        /*6. Ataque crítico
Crie int danoBase = 10; e bool critico = true;
Se for crítico, multiplique o dano por 2.
         */
        if(critico == true)
        {
            print(danoBase * 2);
        }
    }

}
