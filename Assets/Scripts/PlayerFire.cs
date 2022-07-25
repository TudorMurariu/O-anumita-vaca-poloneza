using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public Transform PolishCow;
    public AudioSource AD;
    public AudioClip AC;

    GameObject bullet1;
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.X) || Input.GetMouseButtonDown(0))
        {
            Debug.Log("shot");
            bullet1 = (GameObject)Instantiate(bullet);
            bullet.transform.position = new Vector3(PolishCow.position.x + 1, PolishCow.position.y, PolishCow.position.z);
            AD.PlayOneShot(AC);
            Invoke("Delete", 1.5f);
        }
    }

    void Delete()
    {
        Destroy(this.bullet1);
    }
}
