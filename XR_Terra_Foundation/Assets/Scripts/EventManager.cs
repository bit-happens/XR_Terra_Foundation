using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class EventManager : MonoBehaviour
{
    public event System.Action<float> SpacebarPressed;
    public float passedFloat; 

    public void SpaceBarPress(InputAction.CallbackContext context)
    {
        
        if (context.performed)
        {
            // here is where we call the event
            SpacebarPressed?.Invoke(passedFloat); 

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
