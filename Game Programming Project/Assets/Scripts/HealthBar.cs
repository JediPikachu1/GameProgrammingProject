using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public PlayerScript health;
    public int currentHealth;

    public Slider slider;
    void Start()
    {
        currentHealth = health.currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = health.currentHealth;
    }
}
