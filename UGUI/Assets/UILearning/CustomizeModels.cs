using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeModels : MonoBehaviour
{
    public GameObject[] heads;
    private int currentHead;

    private void Update()
    {
        for (int i = 0; i < heads.Length; i++) {
            if(i== currentHead)
            {
                heads[i].SetActive(true);
            }
            else
            {
                heads[i].SetActive(false);
            }
                }
    }

    public void SwitchHeads()
    {

        if(currentHead  == heads.Length - 1)
        {
            currentHead = 0;
        }
        else
        {
            currentHead++;
        }
    }
}
