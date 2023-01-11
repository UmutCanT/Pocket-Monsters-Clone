using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private Vector2 playerInput;

    public Vector2 PlayerInput { get => playerInput; private set => playerInput = value; }

    // Update is called once per frame
    void Update()
    {
        playerInput.x = Input.GetAxisRaw("Horizontal");
        playerInput.y = Input.GetAxisRaw("Vertical"); 

        //Disabling diagonal movement
        if(playerInput.x != 0) playerInput.y = 0;
    }
}
