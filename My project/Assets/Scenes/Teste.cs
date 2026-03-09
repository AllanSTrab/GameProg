using UnityEngine;

public class Teste: MonoBehaviour
{
    public string Nome;
    public int idade;
    public bool Estudando;
    public float Altura;

    void Start()
    {
        print(Nome);
        print(idade);
        print(Estudando);
        print(Altura);
    }

    void Update()
    {
        print("Update");
    }
}
