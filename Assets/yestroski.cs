using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yestroski : MonoBehaviour
{
    public BoxCollider2D b1;
    public BoxCollider2D b2;
    void OnTriggerEnter2D()
    {
        b1.enabled = true;
        b2.enabled = true;
    }
}
