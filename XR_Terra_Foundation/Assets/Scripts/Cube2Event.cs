using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Event : MonoBehaviour
{
    public EventManager envMan;

    // Start is called before the first frame update
    void Start()
    {
        envMan.SpacebarPressed += MoveRight;
    }

    private void OnDestroy()
    {
        envMan.SpacebarPressed -= MoveRight;
    }

    void MoveRight(float receivedFloat)
    {
        transform.position += new Vector3(receivedFloat, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
