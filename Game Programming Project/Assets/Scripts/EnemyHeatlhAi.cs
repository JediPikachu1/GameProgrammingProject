using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHeatlhAi : MonoBehaviour
{
    [SerializeField] private int enemyMaxHealth;
    [SerializeField] private int enemyCurrentHealth;

    public Slider enemySlider;


    void Start()
    {
        EnemyReset();
        
    }

    
    void Update()
    {
        
    }

    void EnemyReset()
    {
        enemyMaxHealth = 150;
        enemyCurrentHealth = enemyMaxHealth;
        enemySlider.maxValue = enemyMaxHealth;
        enemySlider.minValue = 0;
        enemySlider.wholeNumbers = true;
        enemySlider.value = enemyCurrentHealth;
    }

    void UpdateSlider()
    {
        enemySlider.value = enemyCurrentHealth;
    }
}
