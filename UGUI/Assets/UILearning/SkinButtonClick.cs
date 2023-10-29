using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinButtonClick : MonoBehaviour
{
    int _index;
    GameObject[] players;
    [SerializeField] Material[] materials;


    private void Awake()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        foreach(var player in players)
        {
            Debug.Log(player.name);
        }


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
