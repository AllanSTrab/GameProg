using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private GameObject[] bullet = new GameObject[2];
    int escolha = 0;

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * 5.0f * Time.deltaTime;
        transform.Translate(x, 0.0f, 0.0f);

        if (Input.GetButtonDown("Jump"))
        {
            if(escolha == 0)
            {
                escolha = 1;
            }
            else
            {
                escolha = 0;
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet[escolha], transform.position, transform.rotation);
        }
    }
}
