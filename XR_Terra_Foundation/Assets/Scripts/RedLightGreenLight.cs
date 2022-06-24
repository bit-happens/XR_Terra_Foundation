using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class RedLightGreenLight : MonoBehaviour
{
    public float speed;
    Vector3 movement;

    public float minRedTime, maxRedTime, minGreenTime, maxGreenTime;
    public bool canMove;
    public bool wonGame;

    public Transform respawnPoint; 

    // Start is called before the first frame update
    void Start()
    {
        canMove = false;
        wonGame = false;
        StartCoroutine(RLGL());
    }

    public void OnMovement(InputAction.CallbackContext context) 
    {
        Vector2 givenMovement = context.ReadValue<Vector2>();
        movement = new Vector3(givenMovement.x, 0, givenMovement.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            transform.position += movement * speed * Time.deltaTime;
        }
        else
        {
            if(movement.magnitude > .1f)
            {
                // teleport player back to the start
                transform.position = respawnPoint.position;
            }
        }
         
    }

    IEnumerator RLGL()
    {
        while(!wonGame)
        {
            if (canMove)
            {
                // Set the light to red, because it is currently green
                canMove = false;
                // Change the stoplight material to red 
                yield return new WaitForSeconds(Random.Range(minRedTime, maxRedTime));
               
            }

            else
            {
                // Set the light to green, because it is currently red
                canMove = true;
                // Change the stoplight material to green
                yield return new WaitForSeconds(Random.Range(minGreenTime, maxGreenTime));
                
            }
        }
    }

}
