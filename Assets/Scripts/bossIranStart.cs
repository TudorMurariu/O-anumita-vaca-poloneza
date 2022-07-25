using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class bossIranStart : MonoBehaviour
{
    public PlayerFire pf;
    public BossScript Bs;
    public Text UcanShot;
    public Text Hp;
    public Text ll;
    private void OnTriggerEnter2D(Collider2D col)
    {
       if(col.gameObject.tag == "Player")
        {
            pf.enabled = true;
            Bs.enabled = true;
            Hp.enabled = true;
            ll.enabled = true;
            Debug.Log("Pog");
            UcanShot.text = "Press X to fire stuff LOOL";
            Invoke("AscundeText", 3);
        }
    }

    void AscundeText()
    {
        UcanShot.enabled = false;
    }
}
