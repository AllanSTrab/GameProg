using UnityEngine;

public class Exercicio12_Lista01 : MonoBehaviour
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
        int pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus;
        print("Sua pontuação final é de: " + pontuacaoFinal + " Pontos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
