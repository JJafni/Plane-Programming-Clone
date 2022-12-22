using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnvironment : MonoBehaviour
{
    public float sendTimer = 0;
    public float frequency = 3.93f;
    public GameObject floor;

    void Update()
    {
        sendTimer -= Time.deltaTime;
        if (sendTimer <= 0)
        {
            Instantiate(floor, new Vector3(0.53f, -0.28f, -22.12f), transform.rotation);
            sendTimer = frequency;
        }
    }
}
