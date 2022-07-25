using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject ciuperca;
    public AudioSource AD;
    public AudioClip AC;
    public Text HP;

    GameObject bullet1;

    void Start()
    {
        Random123();
    }

    void OnCollisionEnter2D()
    {   
            //HP.text = (Convert.ToInt32(HP.text) - 5).ToString();
            int x = Convert.ToInt32(HP.text);
            x -= 2;
            Debug.Log(x);
            if (x <= 0)
                Win();
            else if (x > 25 && x < 75)
            {
                HP.color = Color.yellow;
            }
            else if (x < 25)
            {
                HP.color = Color.red;
            }

            HP.text = x.ToString();     
    }

    void Win()
    {
        SceneManager.LoadScene("Level 3");
    }
    

    void Random123()
    {
        int a = (int)UnityEngine.Random.Range(0, 5);
        if (a % 2 == 0)
        {
            Shot1();
            Invoke("Random123", 1.8f);
        }
        else
        {
            Shot2();
            Invoke("Random123", 2.8f);
        }
    }
    void Shot1()
    {
        bullet1 = (GameObject)Instantiate(ciuperca);
        bullet.transform.position = new Vector3(46.2F, 2.4F, -0.1193919F);
        Invoke("Delete", 1.5f);
        AD.PlayOneShot(AC);
    }

    void Shot2()
    {
        bullet1 = (GameObject)Instantiate(bullet);
        bullet.transform.position = new Vector3(41.61F, -1.5F, -0.1193919F);
        Invoke("Delete", 1.5f);
        bullet1 = (GameObject)Instantiate(bullet);
        bullet.transform.position = new Vector3(41.61F, -2.2F, -0.1193919F);
        Invoke("Delete", 1.5f);
        AD.PlayOneShot(AC);
    }

    void Delete()
    {
        Destroy(this.bullet1);
    }
}
