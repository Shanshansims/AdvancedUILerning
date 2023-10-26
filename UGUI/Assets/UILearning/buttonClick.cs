using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonClick : MonoBehaviour
{
    int _index;
    GameObject[] players;
    [SerializeField] Material[] materials;


    private void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");



    }

    public void SetIndex(int ind)
    {
        _index = ind;
    }

    public void ClickButton()
    {
        if (_index >= 0 && _index < materials.Length)
        {
            for (int i = 0; i < players.Length; i++)
            {
                players[i].GetComponent<SkinnedMeshRenderer>().material = materials[_index];
            }
        }
        else
        {
            Debug.LogError("Index out of bounds for the 'materials' array.");
        }

    }

}
