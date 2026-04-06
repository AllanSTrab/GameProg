using UnityEngine;

public class Repetição03 : MonoBehaviour
{
    int score = 1000;
    int scoreInicial;
    int temp = 0;
    void Start()
    {
        scoreInicial = score;
        while(temp < 100)
        {
            score++;
            temp++;
        }
        while(temp < scoreInicial)
        {
            score += 10;
            temp++;
        }
        print(score);
    }

}
