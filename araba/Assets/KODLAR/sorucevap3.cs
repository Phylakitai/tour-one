using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000022 RID: 34
public class sorucevap3 : MonoBehaviour
{
    // Token: 0x0600006C RID: 108 RVA: 0x00003479 File Offset: 0x00001679
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Period))
        {
            SceneManager.LoadScene(6);
        }
    }
}
