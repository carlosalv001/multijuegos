using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class moneda : MonoBehaviour
{
    // Start is called before the first frame update
    float velocidad = 0;
    
    void Start()
    {
        gameObject.transform.SetPositionAndRotation(new Vector3(Random.Range(-3, 3), -10, 0), new Quaternion(0, 0, 0, 0));
        velocidad = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.SetPositionAndRotation(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + velocidad * Time.deltaTime, 0), new Quaternion(0, 0, 0, 0));
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("Moneda");
        if(coll.gameObject.name == "personaje")
        {
            Debug.Log("moneda");
            Destroy(gameObject);

        }
    }
}
