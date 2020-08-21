using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class general : MonoBehaviour
{
    float timer = 0;
    int nivel = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(GameObject.Find("personaje").GetComponent<Transform>().position.y < -18) // por si se cae
        {
            SceneManager.LoadScene("SampleScene");
        }

        if(timer > 15)
        {
            nivel = Random.Range(1, 3);
            Debug.Log(nivel);
            if (nivel == 1)
            {
                SceneManager.LoadScene("SampleScene");
            }

            if (nivel == 2)
            {
                SceneManager.LoadScene("Meteoro");
            }
        }

        


    }
}
