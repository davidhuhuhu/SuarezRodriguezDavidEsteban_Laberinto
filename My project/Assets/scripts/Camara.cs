using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    
    public GameObject bola;

    // Start is called before the first frame update
    void Start()
    {
        bola = GameObject.Find("Sphere"); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(bola.transform.position.x, bola.transform.position.y + 5, bola.transform.position.z - 10);
    }
}
