using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public RedLightGreenLight rlgl;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rlgl.wonGame = true;
            Debug.Log("You win, yay!");
        }

    }
}
