using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class RedLightGreenLight : MonoBehaviour
{
    public float speed;
    Vector3 movement;

    public float minRedTime, maxRedTime, minGreenTime, maxGreenTime;
    public bool wonGame;
    public bool canMove;
    bool reactionTimeActive;
    public float reactionTime = 1f; 
    

    public Transform respawnPoint;
    public MeshRenderer stoplight; 
    public Color redColor, greenColor; 

    // Start is called before the first frame update
    void Start()
    {
        wonGame = false;
        canMove = false;
        reactionTimeActive = false; 
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
            if(movement.magnitude > .1f && !reactionTimeActive)
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
                stoplight.sharedMaterial.color = redColor;
                StartCoroutine(ReactionTime());
                yield return new WaitForSeconds(Random.Range(minRedTime, maxRedTime));
               
            }

            else
            {
                // Set the light to green, because it is currently red
                canMove = true;
                stoplight.sharedMaterial.color = greenColor;
                yield return new WaitForSeconds(Random.Range(minGreenTime, maxGreenTime));
                
            }
        }
    }

    IEnumerator ReactionTime()
    {
        reactionTimeActive = true;
        yield return new WaitForSeconds(reactionTime);
        reactionTimeActive = false; 
    }

}
