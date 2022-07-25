using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class troskiDied : MonoBehaviour
{
    void OnCollisionEnter2D()
    {
        Debug.Log("gg");
        SceneManager.LoadScene("Levels");
    }
    void Start()
    {
        ///
    }

    void Update()
    {
        ///
    }
}
