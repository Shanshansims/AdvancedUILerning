using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtonClick : MonoBehaviour
{
   public void ClickTest()
    {
        Debug.Log("clicked");
    }

    public void ClickTest2 (string text)
    {
        Debug.Log(text);
    }
}
