using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acıkpanel : MonoBehaviour
{
    public GameObject panel;


    private void Start()
    {
        panel.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            panel.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            panel.SetActive(false);


        }
    }


}
