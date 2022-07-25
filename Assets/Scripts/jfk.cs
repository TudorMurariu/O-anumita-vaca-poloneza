using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class jfk : MonoBehaviour
{
   void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("JFK");
        Debug.Log("jfk");
    }
}
