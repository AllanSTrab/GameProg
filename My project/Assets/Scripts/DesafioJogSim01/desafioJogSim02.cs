using UnityEngine;
using UnityEngine.Video;

public class desafioJogSim02 : MonoBehaviour
{
    [Header("Atributos")]
    [SerializeField] int vida;
    [SerializeField] int atk;
    [SerializeField] int def;
    int pontos = 5;
    [Header("Atributos da CPU")]
    [SerializeField] int vidaCpu;
    [SerializeField] int atkCpu;
    [SerializeField] int defCpu;
    int pontosCpu = 5;
    [Header("Dados")]
    int dado1;
    int dado2;
    [Header("Outros")]
    [SerializeField] int dano;
    [SerializeField] int danoCpu;

    void Start()
    {
        vidaCpu = Random.Range(0, pontosCpu);
        pontos = pontos - vidaCpu;
        atkCpu = Random.Range(0, pontosCpu);
        pontos = pontos - atkCpu;
        defCpu = Random.Range(0, pontosCpu);
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (vida <= 0 || atk <= 0 || def <= 0)
            {
                print("Você colocou seus pontos errados, precisa ter no minimo 1");
            }
            else if (vida + atk + def > pontos)
            {
                print("Opa, tem pontos a mais no seu personagem");
            }
            else if (vida + atk + def < pontos)
            {
                print("Voce ainda tem pontos a gastar, max 5");
            }
            else if(vida + atk + def == pontos)
            {
                if (vida > 0 && atk > 0 && def > 0)
                {
                    print("Seus atributos: " + atk + " de Ataque, " + def + " de Defesa, " + vida + " de Vida");
                    print("Agora batalhe");
                    print("----------------------------");
                    dado1 = Random.Range(1, 7);
                    if (dado1 %2 == 0)
                    {
                        dano = (atk + dado1) - defCpu;
                    }
                    else if(dado1 %2 == 1)
                    {
                        def = (atk + dado1);
                    }
                }
            }
        }
    }
}
