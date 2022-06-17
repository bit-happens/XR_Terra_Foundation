using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesManager : MonoBehaviour
{
    public int totalCubesToCollect;
    public int cubesCollected;
    float timer; 



    // Start is called before the first frame update
    void Start()
    {
        cubesCollected = 0;
        timer = 0f; 
    }

    public void AddOneToScore ()
    {
        cubesCollected += 1; 
        if(cubesCollected == totalCubesToCollect)
        {
            Debug.Log("You win, you collected all of the cubes!");
            Debug.Log("It took you " + timer + " seconds to win.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
}
