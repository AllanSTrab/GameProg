using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    public float velocidadeInicial;
    public float aceleracao;
    public float tempo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*11) Velocidade com Aceleração
Crie:
• public float velocidadeInicial;
• public float aceleracao;
• public float tempo;
Calcule a velocidade final usando:
velocidadeFinal = velocidadeInicial + aceleracao * tempo;*/
        print("Sua velocidade Final é de: " + (velocidadeInicial + aceleracao * tempo));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
