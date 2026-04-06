using Unity.VisualScripting;
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
    int dadoCpu1;
    int dadoCpu2;
    [Header("Outros")]
    [SerializeField] int dano;
    [SerializeField] int bloq;
    [SerializeField] int bloqCpu;
    [SerializeField] int danoCpu;

    void Start()
    {
        vidaCpu = Random.Range(1, pontosCpu + 1);
        pontosCpu = pontosCpu - vidaCpu;
        atkCpu = Random.Range(1, pontosCpu + 1);
        pontosCpu = pontosCpu - atkCpu;
        defCpu = Random.Range(1, pontosCpu + 1);
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
                else if (vida + atk + def == pontos)
                {
                    if (vida > 0 && atk > 0 && def > 0)
                    {
                        print("Seus atributos: " + atk + " de Ataque, " + def + " de Defesa, " + vida + " de Vida");
                        print("Agora batalhe");

                        print("----------------------------");

                        dado1 = Random.Range(1, 7);
                        dado2 = Random.Range(1, 7);
                        print("Você rolou: " + dado1 + " E " + dado2);

                        if (dado1 % 2 == 0)
                        {
                            dadoCpu2 = Random.Range(1, 7);
                            bloqCpu = defCpu + dadoCpu2;
                            dano = (atk + dado2) - bloqCpu;
                        if (dano < 0)
                        {
                            dano = 0;
                        }
                            vidaCpu -= dano;
                            bloq = 0;

                            print("Voce atacou causando " + dano + " de dano!");
                        }
                        else
                        {
                            bloq = def + dado2;
                            print("Jogador bloqueará " + bloq + " De dano");
                        }


                        dadoCpu1 = Random.Range(1, 7);
                        dadoCpu2 = Random.Range(1, 7);

                        print("Inimigo rolou: " + dado1 + " e " + dado2);

                        if (dado1 % 2 == 0)
                        {
                            dado2 = Random.Range(1, 7);
                            bloq = def + dado2;
                            danoCpu = (atkCpu + dadoCpu2) - bloq;
                        if (danoCpu < 0)
                        {
                            danoCpu = 0;
                        }
                            vida -= dano;
                            bloq = 0;

                            print("Inimigo atacou causando " + danoCpu + " de dano!");
                        }
                        else
                        {
                            bloqCpu = defCpu + dado2;
                            print("Inimigo bloqueará " + bloqCpu + " De dano");
                        }

                        print("Vida Jogador: " + vida + " | Vida Inimigo: " + vidaCpu);
                        print("----------------------------");
                    }

                    if (vida > 0 && vidaCpu <= 0)
                        print("Você venceu!");
                    else
                        print("Você perdeu!");
                }
            }
        }
    }
