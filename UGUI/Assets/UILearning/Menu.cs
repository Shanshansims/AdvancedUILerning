using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Color[] headColors;
    public Material headMat;

    public Color[] eyesColors;
    public Material eyesMat;

    public Transform HairButtonParent;

    private void Start()
    {
        for (int i = 0; i < HairButtonParent.childCount; i++)
        {
            Transform buttonTransform = HairButtonParent.GetChild(i);
            int index = i;
            buttonTransform.GetComponent<Button>().onClick.AddListener(() =>
            {
                ChangeHairColor(index);
            });
        }
    }

    public void ChangeHairColor(int colorIndex)
    {
        Debug.Log("Changing head color to index: " + colorIndex);
        headMat.color = headColors[colorIndex];
    }

    public void ChangeEyesColor(int colorIndex)
    {
        eyesMat.color = eyesColors[colorIndex];
    }
}
