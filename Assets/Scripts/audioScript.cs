using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class audioScript : MonoBehaviour
{

    public static audioScript instance;
    void Awake()
    {
        /*if(SceneManager.GetActiveScene().name == "DLC" || SceneManager.GetActiveScene().name == "Levels")
        {
            if (instance == null)
                instance = this;
            else 
            {
                Destroy(gameObject);
                return;
            }
            DontDestroyOnLoad(this.gameObject);
        }     */
    }

}
