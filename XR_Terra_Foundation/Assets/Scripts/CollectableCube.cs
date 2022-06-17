using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    public CollectablesManager colMan;
    BoxCollider collider;
    MeshRenderer renderer; 

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
        renderer = GetComponent<MeshRenderer>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if(other.gameObject.CompareTag("Player"))
        {
            colMan.AddOneToScore();
            collider.enabled = false;
            renderer.enabled = false; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
