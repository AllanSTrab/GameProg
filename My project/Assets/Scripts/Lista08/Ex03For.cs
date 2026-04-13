using UnityEngine;

public class Ex03For : MonoBehaviour
{
    /*Crie uma variável int numero e use for para exibir a tabuada desse número de 1 a 10.
     */
    [SerializeField]int numero = 5;
    void Start()
    {
        for (int tabuada = 0; tabuada <= 10; tabuada++)
        {
            print(numero + " x " + tabuada + " = " + numero * tabuada);
        }
    }
}
