using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Precipicio : MonoBehaviour
{

    int sceneToGO;
    int currentScene;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        print("Escena actual: " + currentScene);
        print("mi nombre:" + gameObject.name);
        if(gameObject.name.Trim() == "Collisionprecipicio")
        {

            sceneToGO = currentScene;

        }
        else if(currentScene <2)
        {
            sceneToGO = currentScene + 1;


        }
        else
        {

            sceneToGO = 3;

        }
        print("Escena siguiente: " + sceneToGO);
    }

    // Update is called once per frame
    void Update()
    {
     
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Sphere")
        {

            
            SceneManager.LoadScene( sceneToGO );



            // SceneManager.LoadScene("Laberinto_1");
            // SceneManager.LoadScene(0); El 0 es el numero de la escena, es otra forma de hacerlo.

        }

    }
}
