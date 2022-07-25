using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExilButtonAwake : MonoBehaviour
{
    public Button btn;
    public GameObject AD;
    void Start()
    {
        Invoke("ButtonAwake", 3);
    }
    void ButtonAwake()
    {
        btn.transform.position = new Vector3(600, 300, 0);
        Debug.Log("merge");
    }

    public void ButtonPressed()
    {
        Application.Quit();
    }
}
