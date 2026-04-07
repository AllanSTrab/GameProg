using UnityEngine;

public class Repetição05 : MonoBehaviour
{
    [SerializeField] int quantidade;
    [SerializeField] GameObject quadrado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0; // a variavel é criada aqui porque só tem funcionalidade aqui
        float posX = 0;
        float posY = 0;
        while (i < quantidade) 
        {
            i++;
            print(i);

            GameObject quadradoCopia = Instantiate(quadrado);
            quadradoCopia.transform.position = new Vector2(posX, posY); // vector 2(X, y), vector 3(x, y, z)
            posX += transform.localScale.x;
            posY += transform.localScale.y;
        }

        print("Fim.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
