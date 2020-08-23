
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeMeteoros : MonoBehaviour
{
    float timer = 0;
    public GameObject Meteoro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > .8f) {
            Instantiate(Meteoro);
            timer = 0;
        }
        
    }
}
