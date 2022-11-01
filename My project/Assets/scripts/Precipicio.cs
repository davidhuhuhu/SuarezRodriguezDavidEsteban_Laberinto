using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Precipicio : MonoBehaviour
{

    int sceneToGO;
    int currentScene;
    [SerializeField] Image vidasImage;
    [SerializeField] Sprite vidas3;
    [SerializeField] Sprite vidas2;
    [SerializeField] Sprite vidas1;
    [SerializeField] Sprite vidas0;

    int lifes;
    [SerializeField] GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {

       // lifes = gameManager.Getlifes();


        
        
        
        //no es eficiente
        gameManager = GameObject.Find("Initgame").GetComponent<GameManager>();
        
        
        currentScene = SceneManager.GetActiveScene().buildIndex;
        print("Escena actual: " + currentScene);
        print("mi nombre:" + gameObject.name);
        if(gameObject.name.Trim() == "Collisionprecipicio")
        {
            vidasImage.sprite = vidas3;
            sceneToGO = currentScene;

        }
        else if(currentScene <3)
        {
            sceneToGO = currentScene + 1;


        }
        else
        {

            sceneToGO = 4;

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

            vidasImage.sprite = vidas2;

            // SceneManager.LoadScene("Laberinto_1");
            // SceneManager.LoadScene(0); El 0 es el numero de la escena, es otra forma de hacerlo.

        }

    }
}
