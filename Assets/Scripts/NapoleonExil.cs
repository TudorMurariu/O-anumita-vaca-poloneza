using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NapoleonExil : MonoBehaviour
{
    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("Exil");
    }
}
