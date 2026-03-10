using UnityEngine;

public class Exercicio12 : MonoBehaviour
{
    public int pontosBase;
    public int inimigosDerrotados;
    public int bonus;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
          12) Sistema de Pontuação Completo
Crie:
• public int pontosBase;
• public int inimigosDerrotados;
• public int bonus;
Calcule:
pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus;*/
        print("Sua pontuação final é de: " + ((pontosBase * inimigosDerrotados) + bonus) + " Pontos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
