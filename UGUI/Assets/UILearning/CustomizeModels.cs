using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeModels : MonoBehaviour
{
    public List<GameObject> hairs;

    private int currentHair;


    private void Start()
    {
        hairs = new List<GameObject>();
        for (int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            if (child.name.Contains("Hair"))
            {
                hairs.Add(child.gameObject);
            }
        }
    }


    private void Update()
    {
        for (int i = 0; i < hairs.Count; i++)
        {
            if (i == currentHair)
            {
                hairs[i].SetActive(true);
            }
            else
            {
                hairs[i].SetActive(false);
            }
        }
    }

    public void SwitchHairs()
    {

        if (currentHair == hairs.Count - 1)
        {
            currentHair = 0;
        }
        else
        {
            currentHair++;
        }
    }
}
