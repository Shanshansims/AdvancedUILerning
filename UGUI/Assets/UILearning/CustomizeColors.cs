using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CustomizeColors : MonoBehaviour
{
    public Color[] headColors;
    public Material headMat;

    public Color[] eyesColors;
    public Material eyesMat;

    public void ChangeHeadColor(int colorIndex)
    {
        Debug.Log("Changing head color to index: " + colorIndex);
        headMat.color = headColors[colorIndex]; 
    }

    public void ChangeEyesColor(int colorIndex)
    {
        eyesMat.color = eyesColors[colorIndex];
    }
}
