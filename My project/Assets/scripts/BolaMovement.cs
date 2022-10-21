using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaMovement : MonoBehaviour
{
    InputSystem inputActions;

    Rigidbody bolita;
    float potencia;

    [SerializeField] float MovR;
    [SerializeField] float MovF;

    private void Awake()
    {
        inputActions = new InputSystem();

        inputActions.Bola.Keys.performed += ctx => MovF = ctx.ReadValue<float>();
        inputActions.Bola.Keys.canceled += _ => MovF = 0;


        inputActions.Bola.Keys2.performed += ctx => MovR = ctx.ReadValue<float>();
        inputActions.Bola.Keys2.canceled += _ => MovR = 0;
    }

    void Start()
    {


        bolita = GetComponent<Rigidbody>();
        potencia = 15.7f;

    }

    private void FixedUpdate()
    {
        bolita.AddForce(Vector3.forward * MovF * potencia);
        bolita.AddForce(Vector3.right * MovR * potencia);
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
    /*
    
    

    
    float Potencia;

    // Start is called before the first frame update





    // Update is called once per frame
    void MoverBola()
    {
        Vector3 movimientoR = Vector3.right * MovR * Time.deltaTime * Potencia;
        Vector3 movimientoF = Vector3.forward* MovF * Time.deltaTime * Potencia;

        
        transform.Translate(movimientoR, Space.World);

        transform.Translate(movimientoF, Space.World);
        
       // Bolita.AddForce(-transform.right * MovL * Potencia);
        //Bolita.AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }
    
    
    void Update()
    {

        MoverBola();
        
    }
    
    */
}
