using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class RedLightGreenLight : MonoBehaviour
{
    public float speed;
    public bool canMove;
    public bool wonGame;
    public float minRedTime, maxRedTime, minGreenTime, maxGreenTime;
    Vector3 movement; 

    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
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
        transform.position += movement * speed * Time.deltaTime; 
    }

    IEnumerator RLGL()
    {
        while(!wonGame)
        {
            if (canMove)
            {
                yield return new WaitForSeconds(Random.Range(minRedTime, maxRedTime));
                canMove = false;
            }

            else
            {
                yield return new WaitForSeconds(Random.Range(minGreenTime, maxGreenTime));
                canMove = true;
            }
        }
    }

}
