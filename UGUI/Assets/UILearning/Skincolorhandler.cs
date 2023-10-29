using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkinColorHandler : MonoBehaviour
{
    [SerializeField] Color[] _colors;
    [SerializeField] SkinButtonClick buttonPrefab;
    [SerializeField] Transform parent;

    private void Awake()
    {
        for (int i = 0; i < _colors.Length; i++)
        {
            var instance = Instantiate(buttonPrefab, parent);
            instance.GetComponent<SkinButtonClick>().SetIndex(i);
            instance.gameObject.SetActive(true);
            instance.GetComponent<Image>().color = _colors[i];

        }
    }
}
