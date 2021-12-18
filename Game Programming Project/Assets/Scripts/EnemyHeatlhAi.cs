using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHeatlhAi : MonoBehaviour
{
    [SerializeField] private int enemyMaxHealth;
    [SerializeField] private int enemyCurrentHealth;

    public Slider enemySlider;

    public Text displayHealthNumber;


    void Start()
    {
        EnemyReset();
        
    }

    
    void Update()
    {
        
    }

    #region EnemySlider functions
    void EnemyReset()
    {
        enemyMaxHealth = 150;
        enemyCurrentHealth = enemyMaxHealth;
        enemySlider.maxValue = enemyMaxHealth;
        enemySlider.minValue = 0;
        enemySlider.wholeNumbers = true;
        enemySlider.value = enemyCurrentHealth;
        displayHealthNumber.text = enemySlider.value.ToString() + "/" + enemyMaxHealth.ToString();
    }

    void UpdateSlider()
    {
        enemySlider.value = enemyCurrentHealth;
        displayHealthNumber.text = enemySlider.value.ToString() + "/" + enemyMaxHealth.ToString();
    }

    #endregion


    #region Enemy AI functions

    public void EnemyAction()
    {
        //This section tells what the enemy will do with certain chances
        float randomAction = Random.value;
        if (randomAction <= 0.3)
        {
            EnemyGainBlock();
        }
        if (0.3 < randomAction && randomAction <= 0.9)
        {
            EnemyAttack();
        }
        if (0.9 < randomAction && randomAction <= 1.0)
        {
            EnemyDebuff();
        }
    }

    void EnemyGainBlock()
    {

    }

    void EnemyAttack()
    {

    }

    void EnemyDebuff()
    {

    }


    #endregion
}
