using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public Transform targetObject;

    public Vector3 offset;

    //create smooth factor
    public float smoothFactor = 1f;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - targetObject.transform.position;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = targetObject.transform.position + offset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);

    }
}
