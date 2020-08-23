using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    float velocidad = 0;
    float timer = 0;
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 3.5f;
        bala = GameObject.Find("bala");
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (Input.GetMouseButton(0)) // si presiona el click 
        {
           // Debug.Log(Input.mousePosition);

            if (Input.mousePosition.x < 300) // si es en la parte izquierda
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x - velocidad * Time.deltaTime, gameObject.transform.position.y, 0);

            }

            if (Input.mousePosition.x > 400) // si es en la parte derecha
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + velocidad * Time.deltaTime, gameObject.transform.position.y, 0);

            }

        }

        if(timer > 1) // cada 1.5 seg se dispara
        {
            Instantiate(bala);
            timer = 0;
        }

    }
}
