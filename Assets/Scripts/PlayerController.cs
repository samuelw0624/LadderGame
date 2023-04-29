using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    Player1Controller controls;
    Vector2 move;
    Vector2 height;
    Rigidbody rb;
    float climbValue;

    Renderer renderer;

    // Start is called before the first frame update
    void Awake()
    {
        controls = new Player1Controller();

        //access movement axis_x
        controls.Gameplay.Move_X.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move_X.canceled += ctx => move = Vector2.zero;

        controls.Gameplay.Hold.started += Hold;
        controls.Gameplay.Hold.canceled += ctx => rb.useGravity = true;

    }

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        renderer = this.GetComponent<Renderer>();

    }


    void Update()
    {


        //climb function
        if (controls.Gameplay.Climb_Left.triggered)
        {
            controls.Gameplay.Climb_Left.performed += ClimbLeft;

        } else 
        {
            controls.Gameplay.Climb_Left.canceled += ctx => climbValue = 0;

        }


        if (controls.Gameplay.Climb_Right.triggered)
        {
            controls.Gameplay.Climb_Right.performed += ClimbRight;

        }
        else
        {
            controls.Gameplay.Climb_Right.canceled += ctx => climbValue = 0;

        }


        
        if (controls.Gameplay.Equip01.triggered)
        {
            controls.Gameplay.Equip01.performed += Equip1;
        } else if (controls.Gameplay.Equip02.triggered)
        {
            controls.Gameplay.Equip02.performed += Equip2;
        }
        else if (controls.Gameplay.Equip03.triggered)
        {
            controls.Gameplay.Equip03.performed += Equip3;
        }



        // axis_x movement function
        Vector2 movement = new Vector2(move.x, climbValue) * Time.deltaTime;
        transform.Translate(movement, Space.World);

    }

    void Equip1(InputAction.CallbackContext context)
    {
        renderer.material.color = Color.yellow;
        Debug.Log("1");
    }
    void Equip2(InputAction.CallbackContext context)
    {
        renderer.material.color = Color.green;
        Debug.Log("2");
    }
    void Equip3(InputAction.CallbackContext context)
    {
        renderer.material.color = Color.red;
        Debug.Log("3");
    }

    private void ClimbLeft(InputAction.CallbackContext context)
    {
        climbValue = 1;
        
    }

    private void ClimbRight(InputAction.CallbackContext context)
    {
        climbValue = 1;

    }


    private void Hold(InputAction.CallbackContext context)
    {
        rb.useGravity = false;

    }


    void OnEnable()
    {
        controls.Gameplay.Enable();
    }

    void OnDisable()
    {
        controls.Gameplay.Disable();
    }




}
