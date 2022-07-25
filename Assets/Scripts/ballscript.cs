using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{
    public Rigidbody2D rbbbbbb;
    void Start()
    {
        rbbbbbb.AddForce(Vector2.left * 2000);
    }
}
