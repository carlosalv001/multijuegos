using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class plataformaController : MonoBehaviour
{
    // Start is called before the first frame update
 
    float timer = 0;
    bool toco = false;
    float velocidad = 0;
    Vector3 pos;
    void Start()
    {
        pos = new Vector3(Random.Range(-2, 2f), -5f, 0);
        gameObject.transform.position = pos;
        velocidad = 2;
    }

    // Update is called once per frame
    void Update()
    {

        //hace que vaya para arriba a una velocidad constante
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + velocidad * Time.deltaTime, 0);


        if(gameObject.transform.position.y >= 5) // si se sale de la pantalla se destruye
        {
            Destroy(gameObject);
        }

        if (toco) // si ya toco la plataforma
        {
            timer += Time.deltaTime; //contamos dos seg
            if(timer >= 1.5f)
            {
                Destroy(gameObject); //destruimos el objeto 
                toco = false;
            }


        }

    }


    void OnCollisionEnter2D(Collision2D coll)
    {
       // Debug.Log("Holaa");
        toco = true;
      
    }


}
