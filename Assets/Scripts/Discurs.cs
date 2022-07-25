using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Discurs : MonoBehaviour
{
    public AudioClip AC;
    public AudioSource AS;
    public static int x = 0;

    void OnTriggerEnter2D()
    {
        if(x == 0)
        {
            AS.PlayOneShot(AC);
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
