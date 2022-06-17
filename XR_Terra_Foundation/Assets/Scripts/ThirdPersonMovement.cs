using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonMovement : MonoBehaviour
{
    public float speed;
    Vector3 movementVector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Vector2 movement = context.ReadValue<Vector2>();

        //Debug.Log(movement);
        movementVector = new Vector3(movement.x, 0, movement.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movementVector * Time.deltaTime * speed;
    }
}
