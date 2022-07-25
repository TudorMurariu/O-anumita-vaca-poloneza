using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ciuperca : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "enemy?")
            Lose();
    }

    public void Lose()
    {
        SceneManager.LoadScene("Levels");
    }
}
