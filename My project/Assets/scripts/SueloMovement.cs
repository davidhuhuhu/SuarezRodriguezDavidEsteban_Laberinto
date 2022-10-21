using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SueloMovement : MonoBehaviour
{

    
    Rigidbody suelo;
    InputSystem inputActions;
    [SerializeField]float rotacionR;
    [SerializeField]float rotacionL;
    [SerializeField]float mov;
    [SerializeField]Vector3 rightTorque;
    [SerializeField]Vector3 leftTorque;


    // Start is called before the first frame update

    private void Awake()
    {
        inputActions = new InputSystem();
        inputActions.Floor.JSR.performed += ctx => rotacionR = ctx.ReadValue<float>();
        inputActions.Floor.JSR.canceled += _ => rotacionR = 0;

        inputActions.Floor.JSL.performed += ctx => rotacionL = ctx.ReadValue<float>();
        inputActions.Floor.JSL.canceled += _ => rotacionL = 0;




    }

    void Start()
    {
        
        suelo = GetComponent<Rigidbody>();

        mov = 1.2f;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        MoverSuelo();
       
    }
    private void MoverSuelo()
    {
         rightTorque = Vector3.right * rotacionR * mov;
         leftTorque= Vector3.forward * rotacionL * mov;
        suelo.AddTorque(rightTorque);
        suelo.AddTorque(-leftTorque);
        
        //transform.eulerAngles = new Vector3(0f, 0f, rotacionR * -60f);
        


    }
  


    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
}
