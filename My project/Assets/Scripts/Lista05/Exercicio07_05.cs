using UnityEngine;

public class Exercicio07_05 : MonoBehaviour
{
    [SerializeField] int nivelJogador;
    void Start()
    {
        /*7. Nível do Jogador
Com base na variável nivel:
• <= 10 → "Iniciante"
• <= 20 → "Intermediário"
• > 20 → "Avançado" 
         */
        if (nivelJogador <= 10)
        {
            print("Iniciante");
        }
        else if(nivelJogador <= 20)
        {
            print("Intermediario");
        }
        else
        {
            print("Avançado");
        }
    }

}
