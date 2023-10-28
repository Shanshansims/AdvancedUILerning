using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    public Slider slider;

    private void Update()
    {
        slider.value = Mathf.MoveTowards(slider.value, 100.9f, 0.15f);
    }

}
