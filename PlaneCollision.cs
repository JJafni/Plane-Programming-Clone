using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour
{


    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Environment"))
        {
           // Get the prefab to instantiate
GameObject deathPrefab = Resources.Load("DeathEffect") as GameObject;

// Instantiate the prefab at the object's position and rotation
GameObject deathObj = Instantiate(deathPrefab, transform.position, transform.rotation) as GameObject;;
            Destroy(gameObject);
        }
    }
    
}
