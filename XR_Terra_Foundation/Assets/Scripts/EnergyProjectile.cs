using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyProjectile : MonoBehaviour
{
    public GameObject hitParticlesPrefab;

    public float maxLifetime = 10f;
    float timer; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(hitParticlesPrefab, transform.position, transform.rotation);
            ScoreManager.Instance.AddToScore(); 
            Destroy(gameObject); 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 0f; 
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > maxLifetime)
        {
            Destroy(gameObject); 
        }

    }
}
