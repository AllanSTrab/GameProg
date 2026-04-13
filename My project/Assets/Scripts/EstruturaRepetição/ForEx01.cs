using UnityEngine;

public class ForEx01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 1000; i > 10; i--)
        {
            if(i == 50)
            {
                break;
            }
            print(i);
        }
        for (int x = 0; x <= 10; x++) //While só q menor e não da para ficar indeterminado(Só usa For qnd ja sabe quando vai parar)
        {
            print(x);
        }
    }
    // ";" serve para terminar uma Instrução
    // For(Inicio; Condição de Parada; Incrementador/decrementador){}
    // For(int x = 0; x <= 10; x++){}
}

