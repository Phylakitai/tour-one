using System;
using UnityEngine;
using TMPro;

// Token: 0x02000032 RID: 50
public class ikincicarpma3 : MonoBehaviour
{
    // Token: 0x0600009C RID: 156 RVA: 0x00003BB8 File Offset: 0x00001DB8
    private void Start()
    {
        this.sure = PlayerPrefs.GetInt("sure");
        this.cevap = (this.sure + 7) * 95 - this.sure * 95;

        this.answer.text = "A) " + this.cevap;
    }

    // Token: 0x04000081 RID: 129
    public TMP_Text answer;

    // Token: 0x04000082 RID: 130
    private int cevap;

    // Token: 0x04000083 RID: 131
    private int sure;


}
