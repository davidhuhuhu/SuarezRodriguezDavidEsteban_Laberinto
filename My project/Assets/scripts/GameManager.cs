using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static int lifes;




    // Start is called before the first frame update
    void Start()
    {

        if (lifes == 0)
            lifes = 3;

        lifes = 3;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* public void Getlifes()
    {
        int actuallifes = lifes;

        return actuallifes;

    } 

    public void RestarVida()
        {
        lifes--;
        if(lifes <=0)
        {
            
        }
    
    }*/
}
