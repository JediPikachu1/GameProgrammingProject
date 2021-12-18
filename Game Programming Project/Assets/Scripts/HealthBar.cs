using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerScript health;

    public Slider slider;
    void Start()
    {
        slider.maxValue = health.maximumHealth;
        slider.minValue = 0;
        slider.value = health.maximumHealth;
        slider.wholeNumbers = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateHP()
    {
        slider.value = health.currentHealth;
    }
}
