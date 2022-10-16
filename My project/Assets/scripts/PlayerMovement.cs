using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    Rigidbody suelo;
    [SerializeField]float rotacionR=10f;
    [SerializeField]float rotacionL =10f;
    [SerializeField]float mov=5.4f;
    InputSystem inputActions;

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
        MoverSuelo();
        suelo = GetComponent<Rigidbody>();

        mov = 1f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        print(rotacionR);
        print(rotacionL);


    }
    private void MoverSuelo()
    {
        suelo.AddTorque(transform.right * rotacionR*mov);
        suelo.AddTorque(-transform.right * rotacionL*mov);


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
