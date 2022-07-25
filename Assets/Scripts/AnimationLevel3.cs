using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnimationLevel3 : MonoBehaviour
{
    
    void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("AnimationLvL3");
    }
}
