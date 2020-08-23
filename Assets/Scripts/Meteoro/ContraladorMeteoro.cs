using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContraladorMeteoro : MonoBehaviour
{
    Vector3 pos;
    float gravedad = 0;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector3(Random.Range(-2.5f, 2), 6, 0);
        gameObject.transform.position = pos;
        gravedad = Random.Range(.1f, .4f); // para que vaya mas rapido o normal 
        gameObject.GetComponent<Rigidbody2D>().gravityScale = gravedad; //esto le establece la gravedad por lo que va mas rapido o no 
        
    }

    // Update is called once per frame
    void Update()
    {
        //este si usa las fisicas del unity


        if(gameObject.transform.position.y < -15) // si se sale de la pantalla se elimina
        {
            Destroy(gameObject);
        }

    }


    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag =="Bala" && col.gameObject.name =="bala(Clone)") // si pega con la bala se elimina el meteoro 
        {
            Destroy(gameObject);
            Destroy(col.gameObject);
        }


        if (col.gameObject.name == "personaje") // si se pega el meteorito con el personaje perdio 
        {
            SceneManager.LoadScene("SampleScene");
        }

    }

}
