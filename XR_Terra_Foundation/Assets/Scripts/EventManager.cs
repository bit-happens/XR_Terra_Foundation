using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class EventManager : MonoBehaviour
{

    public void SpaceBarPress(InputAction.CallbackContext context)
    {
        Debug.Log("Receive spacebar press with context of: " + context.phase);

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
