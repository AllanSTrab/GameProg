using Unity.VisualScripting;
using UnityEngine;

public class Repetição04 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int vezes = 0;

        print("inicio");

        while (true)
        {
            int n = Random.Range(1, 100);
            vezes++;
            if(n >= 50 || n <= 60)
            {
                print(n);
                break;
            }
        }
        print(vezes + "Vezes");
        print("Fim");
    }

}
