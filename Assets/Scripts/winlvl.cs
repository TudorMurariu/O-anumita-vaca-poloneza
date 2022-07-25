using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class winlvl : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "win")
            Win();
    }

    public void Win()
    {
        /// deblochezi stuff
        int x = SceneManager.GetActiveScene().buildIndex; 
        if(x-3 < 5)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else
            SceneManager.LoadScene("Main Menu");

    }
}
