using System;
using UnityEngine;
using TMPro;

// Token: 0x0200002A RID: 42
public class cevapne2 : MonoBehaviour
{
    // Token: 0x0600008C RID: 140 RVA: 0x000038F4 File Offset: 0x00001AF4
    private void Start()
    {
        this.sure = PlayerPrefs.GetInt("sure");
        this.cevap = (this.sure + 5) * 95 - this.sure * 95;
        this.soru.text = string.Concat(new object[]
        {
            "Ara� toprak yoldan gitti�inde ",
            this.sure,
            " ile 95'i �arp�yoruz ki toprak yolun uzunlu�unu bulal�m. ",
            this.sure,
            "+5 ile 95'i �arparsak asfalt yolun uzunlu�unu buluyoruz. Asfalt yol uzunlu�u - toprak yol uzunlu�u yaparsak cevab�m�za ula��yoruz."
        });
    }

    // Token: 0x0400006D RID: 109
    private int cevap;

    // Token: 0x0400006E RID: 110
    private int sure;

    // Token: 0x0400006F RID: 111
    public TMP_Text soru;
}
