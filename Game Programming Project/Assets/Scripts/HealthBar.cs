using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerScript health;

    public Slider slider;

    public Text displayHealthNumber;
    void Start()
    {
        ResetSlider();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHP()
    {
        slider.value = health.currentHealth;
        displayHealthNumber.text = slider.value.ToString() + "/" + health.maximumHealth.ToString();
    }

    void ResetSlider()
    {
        slider.maxValue = health.maximumHealth;
        slider.minValue = 0;
        slider.value = health.maximumHealth;
        slider.wholeNumbers = true;
        displayHealthNumber.text = slider.value.ToString() + "/" + health.maximumHealth.ToString();
    }
}
