using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthAi : MonoBehaviour
{
    public int enemyMaxHealth;
    public int enemyCurrentHealth;

    public Slider enemySlider;

    public Text displayHealthNumber;

    public Text actionDisplay;
    public Text enemyBlockDisplay;

    public int enemyAct;
    public int enemyBlock;

    public PlayerScript player;


    void Start()
    {
        EnemyReset();
        EnemyActionDetermineAndDisplay();
    }

    #region EnemySlider functions
    void EnemyReset()
    {
        enemyMaxHealth = 200;
        enemyCurrentHealth = enemyMaxHealth;
        enemySlider.maxValue = enemyMaxHealth;
        enemySlider.minValue = 0;
        enemySlider.wholeNumbers = true;
        enemySlider.value = enemyCurrentHealth;
        displayHealthNumber.text = enemySlider.value.ToString() + "/" + enemyMaxHealth.ToString();
        EnemyBlockUpdate();
    }

    void UpdateSlider()
    {
        enemySlider.value = enemyCurrentHealth;
        displayHealthNumber.text = enemySlider.value.ToString() + "/" + enemyMaxHealth.ToString();
    }

    #endregion


    #region Enemy AI functions

    public void EnemyActionDetermineAndDisplay()
    {
        //This section tells what the enemy will do with certain chances
        float randomAction = Random.value;
        if (randomAction <= 0.3)
        {
            enemyAct = 1;
            actionDisplay.text = "The enemy plans to Block";
        }
        if (0.3 < randomAction && randomAction <= 0.8)
        {
            enemyAct = 2;
            actionDisplay.text = "The enemy plans to Attack";
        }
        if (0.8 < randomAction && randomAction <= 1.0)
        {
            enemyAct = 3;
            actionDisplay.text = "The enemy plans to use a Debuff";
        }
    }


    //These functions to be used after the End Turn button has been pressed
    public void EnemyGainBlock()
    {
        int gainBlock = Random.Range(18, 32);
        enemyBlock += gainBlock;
        EnemyBlockUpdate();
    }

    public void EnemyAttack()
    {
        
        int attackDamage = Random.Range(25, 36);
        player.PlayerTakeDamage(attackDamage);

    }

    public void EnemyDebuff()
    {
        player.strength -= 5;
        player.StrengthText();
    }

    public void EnemyTakeDamage(int damage)
    {
        int rolloverDamage;
        if (enemyBlock == 0)
        {
            

            enemyCurrentHealth -= damage;
            UpdateSlider();
            
        }
        else if (enemyBlock > 0)
        {
            rolloverDamage = damage - enemyBlock;
            enemyBlock -= damage;
            enemyCurrentHealth -= rolloverDamage;
            enemyBlock = 0;
            EnemyBlockUpdate();
        }
    }

    public void EnemyBlockUpdate()
    {
        enemyBlockDisplay.text = enemyBlock.ToString();
    }

    public void EnemyDeath()
    {
        if (enemyCurrentHealth <= 0)
        {
            player.onDeathImage.gameObject.SetActive(true);
            player.gameOverText.text = "You win the battle!";
        }
    }

    


    #endregion
}
