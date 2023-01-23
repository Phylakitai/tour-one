using System;
using System.Collections;
using UnityEngine;


using TMPro;

// Token: 0x02000003 RID: 3
public class FramePerSecond : MonoBehaviour
{
    // Token: 0x06000004 RID: 4 RVA: 0x0000208C File Offset: 0x0000028C
    private void Start()
    {
        base.StartCoroutine(this.ResetMinFramerate());
    }

    // Token: 0x06000005 RID: 5 RVA: 0x0000209B File Offset: 0x0000029B
    private IEnumerator ResetMinFramerate()
    {
        yield return new WaitForSeconds(1f);
        this.minframerate = 1000f;
        yield break;
    }

    // Token: 0x06000006 RID: 6 RVA: 0x000020AC File Offset: 0x000002AC
    private void Update()
    {
        if (this.timeCounter < this.refreshTime)
        {
            this.timeCounter += Time.deltaTime;
            this.frameCounter++;
            return;
        }
        float num = (float)this.frameCounter / this.timeCounter;
        if (this.minframerate > num)
        {
            this.minframerate = num;
        }
        if (this.maxframerate < num)
        {
            this.maxframerate = num;
        }
        this.frameCounter = 0;
        this.timeCounter = 0f;
        this.gösterge.text = num.ToString("n2");
      
    }

    // Token: 0x04000003 RID: 3
    private int frameCounter;

    // Token: 0x04000004 RID: 4
    private float timeCounter;

    // Token: 0x04000005 RID: 5
    private float refreshTime = 0.1f;

    // Token: 0x04000006 RID: 6
    private float maxframerate;

    // Token: 0x04000007 RID: 7
    private float minframerate = 1000f;

    // Token: 0x04000008 RID: 8
    [SerializeField]
    private TMP_Text gösterge;

    // Token: 0x04000009 RID: 9
    

}
