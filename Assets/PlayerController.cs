using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    Player1Controller controls;
    Vector2 move;

    // Start is called before the first frame update
    void Awake()
    {
        controls = new Player1Controller();

        //access movement axis_x
        controls.Gameplay.Move_X.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.Move_X.canceled += ctx => move = Vector2.zero;
     }


    void Update()
    {
        //axis_x movement function
        Vector2 movement = new Vector2(move.x, 0) * Time.deltaTime;
        transform.Translate(movement, Space.World);
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
