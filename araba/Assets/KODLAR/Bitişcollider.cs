using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bitişcollider : MonoBehaviour
{
    
    // Token: 0x0600008E RID: 142 RVA: 0x00003980 File Offset: 0x00001B80
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.isim.GetComponent<timer>().i++;
        }
        if (this.isim.GetComponent<timer>().i >= 2)
        {
            GameObject.Find("araba").SendMessage("Finnished");
        }
    }

    // Token: 0x04000070 RID: 112
    public int sayac;

    // Token: 0x04000071 RID: 113
    public GameObject isim;
}
