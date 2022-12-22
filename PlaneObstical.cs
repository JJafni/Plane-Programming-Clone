using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneObstical : MonoBehaviour
{
    public float sendTimer = 1;
    public float frequency = 2;
    public float position;
    public GameObject myObstacle;
    public GameObject myPlane;

    // Update is called once per frame
    void Update()
    {
        sendTimer -= Time.deltaTime;
        if (sendTimer <= 0)
        {
            position = Random.Range(1, 6);
            transform.position = new Vector3(0, position, -3.7f);
            Instantiate(myObstacle, transform.position, transform.rotation);
            sendTimer = frequency;
        }

        if (myPlane != null) Time.timeScale = 1;
        else Time.timeScale = 0;
        
    }
}
