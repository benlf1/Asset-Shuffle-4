using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ValueBarScript : MonoBehaviour
{
    public Slider slider;

    public void setValue(int val) {
        slider.value = val;
    }
}
