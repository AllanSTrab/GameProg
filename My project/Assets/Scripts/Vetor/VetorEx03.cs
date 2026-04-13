using UnityEngine;

public class VetorEx03 : MonoBehaviour
{
    [SerializeField]int[] numeros = new int[10];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Tamanho Do vetor: " + numeros.Length); // Para mostrar o tamanho do Vetor

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Random.Range(1, 100);
            print(numeros[i]);
        }
    }
}
