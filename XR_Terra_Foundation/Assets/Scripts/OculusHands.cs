using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class OculusHands : MonoBehaviour
{
    public InputActionReference triggerAction;
    public InputActionReference gripAction;
    Animator anim; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        triggerAction.action.started += OnTriggerPressed;
        triggerAction.action.canceled += OnTriggerUnpressed;
        gripAction.action.started += OnGripPressed;
        gripAction.action.canceled += OnGripUnpressed;

    }

    void OnTriggerPressed(InputAction.CallbackContext ctx)
    {
       
        anim.SetBool("TriggerPressed", true);
        Debug.Log("Trigger pressed!");
    }

    void OnTriggerUnpressed(InputAction.CallbackContext ctx)
    {

        anim.SetBool("TriggerPressed", false);
        Debug.Log("Trigger unpressed!");
    }

    void OnGripPressed(InputAction.CallbackContext ctx)
    {

        anim.SetBool("GripPressed", true);
        Debug.Log("Grip pressed!");
    }

    void OnGripUnpressed(InputAction.CallbackContext ctx)
    {

        anim.SetBool("Grip Pressed", false);
        Debug.Log("Grip unpressed!");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
