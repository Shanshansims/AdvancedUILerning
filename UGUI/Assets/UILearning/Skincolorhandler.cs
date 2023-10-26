using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Skincolorhandler : MonoBehaviour
{
    [SerializeField] Color[] _colors;
    [SerializeField] Button buttonPrefab;
    [SerializeField] Transform parent;

    private void Start()
    {
        for (int i = 0; i < _colors.Length; i++)
        {
            var instance = Instantiate(buttonPrefab, parent);
            instance.GetComponent<Image>().color = _colors[i];
            instance.GetComponent<buttonClick>().SetIndex(i);

        }
    }

}
