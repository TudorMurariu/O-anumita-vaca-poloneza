using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class jfkdeathscript : MonoBehaviour
{
    public AudioClip AC;
    public AudioSource AS;

    public void Shot()
    {
        AS.PlayOneShot(AC);
        Invoke("lvl5",1.5f);
    }

    void lvl5()
    {
        SceneManager.LoadScene("Level 5");
    }
}
