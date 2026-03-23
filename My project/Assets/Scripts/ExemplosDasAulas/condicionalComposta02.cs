using UnityEngine;

public class condicionalComposta02 : MonoBehaviour
{
    [SerializeField] int moeda;
    void Start()
    {
        if (moeda >= 0 && moeda <= 10)
        {
            moeda *= 1;
        }
        else if (moeda > 10 && moeda <= 50)
        {
            moeda *= 2;
        }
        else if(moeda > 50 && moeda <= 100)
        {
            moeda *= 3;
        }
        else
        {
            moeda *= 5;
        }

        print("Valor de moedas com bônus: " + moeda);
    }

}
