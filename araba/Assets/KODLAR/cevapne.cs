using System;
using UnityEngine;
using TMPro;

// Token: 0x02000029 RID: 41
public class cevapne : MonoBehaviour
{
   

    private void Start()
    {
        this.sure = PlayerPrefs.GetInt("sure");
        this.cevap = this.sure * 55;
        this.soru.text = "Arac�n h�z� 65m/s dir, h�z� elde etti�iniz s�re (" + this.sure + ") ile �arpman�z gerekiyor.";
    }

    // Token: 0x0400006A RID: 106
    private int cevap;

    // Token: 0x0400006B RID: 107
    private int sure;

    // Token: 0x0400006C RID: 108
    public TMP_Text soru;
}
