using UnityEngine;

public class VetorEx01 : MonoBehaviour
{
    [SerializeField] string[] nomes;

    // Vetor são como pastas em uma gaveta de números, sempre começão do 0/ Ou uma lista
    // Exemplo vetor definido pelo inspector
    void Start()
    {
        print(nomes[0]);
    }
}
