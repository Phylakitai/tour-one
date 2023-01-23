using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000024 RID: 36
public class trigger1 : MonoBehaviour
{
	// Token: 0x06000070 RID: 112 RVA: 0x000034AB File Offset: 0x000016AB
	private void OnCollisonEnter(Collider other)
	{
		SceneManager.LoadScene(4);
	}
}
