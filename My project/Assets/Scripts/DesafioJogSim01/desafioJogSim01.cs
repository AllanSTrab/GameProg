using UnityEngine;

public class desafioJogSim01 : MonoBehaviour
{
    [SerializeField] int numero;
    [SerializeField] int numeroComp;
    [SerializeField] int tentativa;
    [SerializeField] string dif;
    void Start()
    {
        print("Escolha uma Dificuldade");
        print("Escolha um número");
        if(dif == "facil")
        {
            numeroComp = Random.Range(0, 51);
            print("Voce escolheu a dificuldade facil, tente acertar o número entre 0 a 50");
            print("Você tem 3 tentativas para acertar o número gerado");
        }
        else if(dif == "normal")
        {
            numeroComp = Random.Range(0, 101);
            print("Voce escolheu a dificuldade Normal, tente acertar o número entre 0 a 100");
            print("Você tem 4 tentativas para acertar o número gerado");
        }
        else
        {
            numeroComp = Random.Range(0, 501);
            print("Você escolheu a dificuldade Dificil, tente acertar o número entre 0 a 500");
            print("Você tem 5 tentativas para acertar o número gerado");
        }
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            print("Número digitado foi: " + numero);
            tentativa += 1;
            if (dif == "facil" || dif == "Normal")
            {
                print("Você tem 3 tentativas para acertar o número gerado");
            }
            else
            {
                print("Você tem 5 tentativas para acertar o número gerado");
            }
            if (dif == "facil")
            {
                if (numero > numeroComp)
                {
                    print("Muito Alto!");
                    print("-----------------");
                }
                else if (numero < numeroComp)
                {
                    print("Muito Baixo!");
                    print("-----------------");
                }
                else
                {
                    print("Você acertou!!!");
                    print("Você usou: " + tentativa + " Tentativas");
                } 
                if (tentativa == 3)
                {
                    print("Você não conseguiu nas tentativas necessárias :(");
                    print("Coninue jogando até acertar mesmo assim");
                }
                else if (tentativa == 2)
                {
                    print("Ultima tentativa para conseguir a pontuação máxima");
                    if (numeroComp >= 15 && numeroComp <= 30)
                    {
                        print("Esse número está entre 15 e 30");
                    }
                    else if (numeroComp >= 0 && numeroComp <= 15)
                    {
                        print("Esse número está entre 0 e 15");
                    }
                    else if (numeroComp >= 30 && numeroComp <= 50)
                    {
                        print("Esse número está entre 30 e 50");
                    }
                }
            }
            else if(dif == "normal")
            {
                if (numero > numeroComp)
                {
                    print("Muito Alto!");
                    print("-----------------");
                }
                else if (numero < numeroComp)
                {
                    print("Muito Baixo!");
                    print("-----------------");
                }
                else
                {
                    print("Você acertou!!!");
                    print("Você usou: " + tentativa + " Tentativas");
                }
                if (tentativa == 4)
                {
                    print("Você não conseguiu nas tentativas necessárias :(");
                    print("Coninue jogando até acertar mesmo assim");
                }
                else if (tentativa == 2)
                {
                    print("Ultima tentativa para conseguir a pontuação máxima");
                    if (numeroComp >= 30 && numeroComp <= 60)
                    {
                        print("Esse número está entre 30 e 60");
                    }
                    else if (numeroComp >= 0 && numeroComp <= 30)
                    {
                        print("Esse número está entre 0 e 30");
                    }
                    else if (numeroComp >= 60 && numeroComp <= 100)
                    {
                        print("Esse número está entre 60 e 100");
                    }
                }
            }
            else if(dif == "dificil")
            {
                if (numero > numeroComp)
                {
                    print("Muito Alto!");
                    print("-----------------");
                }
                else if (numero < numeroComp)
                {
                    print("Muito Baixo!");
                    print("-----------------");
                }
                else
                {
                    print("Você acertou!!!");
                    print("Você usou: " + tentativa + " Tentativas");
                }
                if (tentativa == 5)
                {
                    print("Você não conseguiu nas tentativas necessárias :(");
                    print("Coninue jogando até acertar mesmo assim");
                }
                else if (tentativa == 2)
                {
                    print("Ultima tentativa para conseguir a pontuação máxima");
                    if (numeroComp >= 150 && numeroComp <= 300)
                    {
                        print("Esse número está entre 150 e 300");
                    }
                    else if (numeroComp >= 0 && numeroComp <= 150)
                    {
                        print("Esse número está entre 0 e 150");
                    }
                    else if (numeroComp >= 300 && numeroComp <= 500)
                    {
                        print("Esse número está entre 300 e 500");
                    }
                }
            }
        }
    }
}
