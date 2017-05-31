using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneGuageModifier : MonoBehaviour {

    public Slider sliderDollar;
    public Slider sliderLeaf;
    public Slider sliderComfort;

    public Text totalDolllar;
    public Text totalLeaf;
    public Text totalCoomfort;
    public Text timerValue;

    public void updateDollar(int value)
    {
        sliderDollar.value = value;
        totalDolllar.text = value.ToString();
    }

    public void updateEco(int value)
    {
        sliderLeaf.value = value;
        totalLeaf.text = value.ToString();
    }

    public void updateComfort(int value)
    {
        sliderComfort.value = value;
        totalCoomfort.text = value.ToString();
    }
    public void updateTimer(int value)
    {
        timerValue.text = value.ToString();
    }
}
