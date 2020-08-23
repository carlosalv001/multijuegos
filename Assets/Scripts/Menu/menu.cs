using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickJugar()
    {
        int nivel = Random.Range(1, 3);
        if(nivel == 1)
            SceneManager.LoadScene("Caida");
        if (nivel == 2)
            SceneManager.LoadScene("Meteoro");
    }

    
}
