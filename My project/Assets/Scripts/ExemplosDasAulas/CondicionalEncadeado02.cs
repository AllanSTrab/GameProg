using UnityEngine;

public class CondicionalEncadeado02 : MonoBehaviour
{
    [SerializeField] int xp;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(xp <= 0)
        {
            print("Não há experiencia");
        }
        else
        {
            if(xp >= 10)
            {
                if(xp >= 1000)
                {
                    print("Jogador Experiente");
                }
            }
            else if(xp >= 200)
            {
                print("Jogador iniante avançado");
            }
            else
            {
                print("Jogador Iniante");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
