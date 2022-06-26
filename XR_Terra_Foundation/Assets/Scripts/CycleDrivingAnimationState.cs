using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleDrivingAnimationState : MonoBehaviour
{
    Animator anim;
    bool isDriving;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isDriving = false;
        
    }

    public void ToggleDriving()
    {
        isDriving = !isDriving;
        anim.SetBool("isDriving", isDriving);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
