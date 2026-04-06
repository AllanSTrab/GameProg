using UnityEngine;

public class EstruturaRepetição : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] float gap;
    int linha = 0;
    int coluna = 0;

    Vector2 pos = Vector2.zero;
    void Start()
    {
        

        while(linha < 5)
        {
            linha++;
            while(coluna < 5)
            {
                coluna++;
                GameObject o = Instantiate(obj);//Criar um obj na cena
                o.transform.position = new Vector2(gap, linha);//Colocar Lugar pro obj
                gap+= 1.5f;//Aumentar o gap
            }

            coluna = 0;
            gap = 1;
        }
    }

    void Update()
    {
        //Não colocar While aqui.
        //E principalmente fazer um looping infinito, senao trava a unity
        
    }
}
