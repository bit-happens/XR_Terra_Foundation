using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RotateTheCar(float passedValue)
    {
        //Debug.Log("Rotating the car"); 
        Vector3 newRotation = new Vector3(transform.rotation.x, passedValue, transform.rotation.z);
        transform.rotation = Quaternion.Euler(newRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
