using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class AudioManagerLvl5 : MonoBehaviour
{
    public static AudioManagerLvl5 instance;
    void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Level 5")
        {
            if (instance == null)
                instance = this;
            else
            {
                Destroy(gameObject);
                return;
            }
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
