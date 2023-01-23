using System;
using UnityEngine;
using TMPro;

// Token: 0x02000032 RID: 50
public class ikincicarpma : MonoBehaviour
{
    // Token: 0x0600009C RID: 156 RVA: 0x00003BB8 File Offset: 0x00001DB8
    private void Start()
    {
        this.sure = PlayerPrefs.GetInt("sure");
        this.cevap = (this.sure + 5) * 95 - this.sure * 95;
        this.soru.text = "Araç toprak yoldan gittiðinde " + this.sure + " saniyede gidiyor ancak asfalt yoldan gidince fazladan 5 saniye gidiyor.Aracýn ortalama hýzý 95 olduðuna göre, asfalt yol ve toprak yol arasýndaki uzunluk farkýný bulunuz.";
        this.answer.text = "C) " + this.cevap;
    }

    // Token: 0x04000081 RID: 129
    public TMP_Text answer;

    // Token: 0x04000082 RID: 130
    private int cevap;

    // Token: 0x04000083 RID: 131
    private int sure;

    // Token: 0x04000084 RID: 132
    public TMP_Text soru;
}
