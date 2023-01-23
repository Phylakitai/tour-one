using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
    public void Start()
    {
        this.timerText.SetActive(false);
        this.zamanlama.SetActive(false);
    }

    // Token: 0x06000002 RID: 2 RVA: 0x0000206A File Offset: 0x0000026A
    private void ShowCharacters()
    {
        this.timerText.SetActive(true);
        this.zamanlama.SetActive(true);
    }

    // Token: 0x04000001 RID: 1
    public GameObject zamanlama;

    // Token: 0x04000002 RID: 2
    public GameObject timerText;
}