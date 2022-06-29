using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Event : MonoBehaviour
{
    public EventManager envMan; 

    // Start is called before the first frame update
    void Start()
    {
        envMan.SpacebarPressed += MoveUp;   
    }

    private void OnDestroy()
    {
        envMan.SpacebarPressed -= MoveUp; 
    }

    void MoveUp(float receivedFloat)
    {
        transform.position += new Vector3(0, receivedFloat, 0f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
