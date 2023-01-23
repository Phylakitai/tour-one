using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class timer : MonoBehaviour
{
    // Token: 0x060000A4 RID: 164 RVA: 0x00003D60 File Offset: 0x00001F60

    private float startTime;

    // Token: 0x04000094 RID: 148
    private bool finnished;
    // Token: 0x060000A5 RID: 165 RVA: 0x00003D64 File Offset: 0x00001F64
    private void Update()
    {
        if (this.i == 1)
        {
            this.süre += Time.deltaTime;
            this.örnek = (int)this.süre;
            PlayerPrefs.SetInt("sure", this.örnek);
            this.timerText.text = this.örnek.ToString();
        }
    }

    // Token: 0x060000A6 RID: 166 RVA: 0x00003DBF File Offset: 0x00001FBF
    [Obsolete]
    public void Finnish()
    {
        this.finnished = true;
        this.timerText.color = Color.green;
        this.timerText.fontSize = 50;
    }

    // Token: 0x0400008E RID: 142
    public int i;

    // Token: 0x0400008F RID: 143
    private int örnek;

    // Token: 0x04000090 RID: 144
    private float süre;

    // Token: 0x04000091 RID: 145
    public GameObject araba;

    // Token: 0x04000092 RID: 146
    public TMP_Text timerText;

    // Token: 0x04000093 RID: 147
    
}
