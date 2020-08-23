using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class personaje : MonoBehaviour
{
    // Start is called before the first frame update
    float velocidad = 0;
    void Start()
    {
        velocidad = 2;
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0)) // si presiona el click 
        {
            //Debug.Log(Input.mousePosition);

            if(Input.mousePosition.x < 300) // si es en la parte izquierda
            {
                // gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1500 * Time.deltaTime, 0));
                gameObject.transform.position = new Vector3(gameObject.transform.position.x - velocidad * Time.deltaTime, gameObject.transform.position.y , 0);

            }

            if (Input.mousePosition.x > 400) // si es en la parte derecha
            {
                //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1500 * Time.deltaTime, 0));
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + velocidad * Time.deltaTime, gameObject.transform.position.y, 0);

            }

        }


    }


   
}
