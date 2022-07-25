using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ceausescudead : MonoBehaviour
{
    public AudioClip AC;
    public AudioSource AS;
    public void pog()
    {
        AS.PlayOneShot(AC);
        Invoke("yes", 2);
    }

    void yes()
    {
        SceneManager.LoadScene("Level 4");
    }
}
