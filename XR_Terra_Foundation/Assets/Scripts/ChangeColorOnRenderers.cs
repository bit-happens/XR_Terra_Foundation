using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnRenderers : MonoBehaviour
{
    public MeshRenderer[] renderersToChange; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangeColor(ColorHolder colorHolder)
    {
        foreach (MeshRenderer rend in renderersToChange)
        {
            rend.material.color = colorHolder.heldColor; 
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
