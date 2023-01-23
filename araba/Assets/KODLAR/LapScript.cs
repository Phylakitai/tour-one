using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Token: 0x02000014 RID: 20
public class LapScript : MonoBehaviour
{
    // Token: 0x06000044 RID: 68 RVA: 0x0000321F File Offset: 0x0000141F
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.Lap++;
        }
    }

    // Token: 0x06000045 RID: 69 RVA: 0x00003241 File Offset: 0x00001441
    private void Update()
    {
        if (this.Lap >= 2)
        {
            SceneManager.LoadScene("soru1");
        }
    }

    // Token: 0x04000056 RID: 86
    public int Lap;

    // Token: 0x04000057 RID: 87
    public int MaxLaps;

    // Token: 0x04000058 RID: 88
    public string Oynanabilir;
}