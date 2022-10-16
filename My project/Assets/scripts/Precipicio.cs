using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Precipicio : MonoBehaviour
{
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
     
        

    }
    private void OnTriggerEnter(Collider other)
    {

        int y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(y + 1);
       // SceneManager.LoadScene("Laberinto_1");
       // SceneManager.LoadScene(0); El 0 es el numero de la escena, es otra forma de hacerlo.

    }
}
