using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class TimeOfDay : MonoBehaviour
{
    Light directionalLight; 
    public Gradient lightColor;
    public AnimationCurve intensityCurve; 

    // Start is called before the first frame update
    void Start()
    {
        directionalLight = GetComponent<Light>(); 
    }

    public void RotateSun(Slider passedSlider)
    {
        float percent = (passedSlider.value - passedSlider.minValue) / (passedSlider.maxValue - passedSlider.minValue);
        // Debug.Log("percent has a value of: " + percent);

        directionalLight.color = lightColor.Evaluate(percent);
        directionalLight.intensity = intensityCurve.Evaluate(percent); 
        Vector3 newRotation = new Vector3(passedSlider.value, transform.rotation.y, transform.rotation.z);
        transform.rotation = Quaternion.Euler(newRotation); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
