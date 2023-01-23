using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000021 RID: 33
public class sorucevap1 : MonoBehaviour
{
    // Token: 0x0600006A RID: 106 RVA: 0x00003460 File Offset: 0x00001660
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Period))
        {
            SceneManager.LoadScene(2);
        }
    }
}
