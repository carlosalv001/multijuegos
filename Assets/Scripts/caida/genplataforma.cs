using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genplataforma : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0;
    public GameObject plataformaPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 2)
        {
            timer = 0;
            Instantiate(plataformaPrefab);
        }
    }
}
