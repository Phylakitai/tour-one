using System;
using UnityEngine;

using TMPro;

// Token: 0x0200002C RID: 44
public class carpma : MonoBehaviour
{
    // Token: 0x06000090 RID: 144 RVA: 0x000039E8 File Offset: 0x00001BE8
    private void Start()
    {
        this.sure = PlayerPrefs.GetInt("sure");
        this.cevap = this.sure * 55;
        this.soru.text = "Bu turda oynadýðýnýz aracýn ortalama hýzý 65 m/s dir.Bu yolu " + this.sure + " saniyede yol alan aracýn aldýðý yolu bulunuz?";
        this.answer.text = "D) " + this.cevap;
    }

    // Token: 0x04000072 RID: 114
    public TMP_Text answer;

    // Token: 0x04000073 RID: 115
    private int cevap;

    // Token: 0x04000074 RID: 116
    private int sure;

    // Token: 0x04000075 RID: 117
    public TMP_Text soru;
}
