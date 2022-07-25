using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.09f;
    public Vector3 offset = new Vector3(0, 0, -1);

    void LateUpdate()
    {
        Vector3 smoothPos = Vector3.Lerp(transform.position, target.position + offset,smoothSpeed);
        transform.position = smoothPos;
    }
}
