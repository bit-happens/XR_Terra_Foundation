using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHands : MonoBehaviour
{
    public InputActionReference gripReference;
    public InputActionReference triggerReference;
    Animator anim; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        triggerReference.action.started += GripStarted;
        triggerReference.action.canceled += GripCanceled;
        gripReference.action.started += TriggerStarted;
        gripReference.action.canceled += TriggerCanceled;
        

    }

    private void OnDestroy()
    {
        triggerReference.action.started -= GripStarted;
        triggerReference.action.canceled -= GripCanceled;
        gripReference.action.started -= TriggerStarted;
        gripReference.action.canceled -= TriggerCanceled;

    }

    void TriggerStarted(InputAction.CallbackContext context)
    {
       
        anim.SetBool("TriggerPressed", true);
        // Debug.Log("Trigger pressed!");
    }

    void TriggerCanceled(InputAction.CallbackContext context)
    {

        anim.SetBool("TriggerPressed", false);
        // Debug.Log("Trigger unpressed!");
    }

    void GripStarted(InputAction.CallbackContext context)
    {

        anim.SetBool("GripPressed", true);
        // Debug.Log("Grip pressed!");
    }

    void GripCanceled(InputAction.CallbackContext context)
    { 
        anim.SetBool("GripPressed", false);
        // Debug.Log("Grip unpressed!");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
