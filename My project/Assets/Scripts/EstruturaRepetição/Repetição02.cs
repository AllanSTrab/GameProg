using UnityEngine;

public class Repetição02 : MonoBehaviour
{
    int qntddDeNmrsCriados;
    void Start()
    {
        while(qntddDeNmrsCriados < 100)
        {
            int nmrTemp = Random.Range(1, 1000);

            if(nmrTemp % 2 == 0)
            {
                print(nmrTemp);
                qntddDeNmrsCriados++;
            }

        }
    }

    void Update()
    {
        
    }
}
