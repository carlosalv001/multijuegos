using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Bala : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 pos;
    float velocidad = 0;
    float posx = 0;
    void Start()
    {
        posx = GameObject.Find("personaje").GetComponent<Transform>().position.x; // tomamos la pos de la nave 
        gameObject.transform.position = new Vector3(posx, -2.7f, 0); // hacemos que la bala este en la pos inicial
        velocidad = 3; // velocidad del proyectil 
        // GameObject.Find("bala").transform.position = new Vector3 ( GameObject.Find("personaje").transform.position.x, -2.7f,0);

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(posx, gameObject.transform.position.y + velocidad * Time.deltaTime, 0); // hace que se mueva

        if(gameObject.transform.position.y > 5.2f && gameObject.name == "bala(Clone)")
        {
            Destroy(gameObject);
        }

    }








}
