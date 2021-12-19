using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public int currentHealth;
    public int maximumHealth = 100;

    public int playerEnergy;
    public int playerBlock;

    public int strength;

    public HealthBar bar;

    public CardFunction cardFunction;
    public Text currentStrength;
    public Text blockText;

    public Text currentEnergy;
    // Start is called before the first frame update
    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    void Update()
    {
        currentEnergy.text = playerEnergy.ToString();
    }


    void ResetGame()
    {
        currentHealth = maximumHealth;
        playerEnergy = 3;
        StrengthText();
        BlockTextUpdate();
    }

    public void StrengthText()
    {
        currentStrength.text = strength.ToString();
    }

    public void BlockTextUpdate()
    {
        blockText.text = playerBlock.ToString();
    }

    public void BlockIntUpdate(int block)
    {
        playerBlock += block;
        BlockTextUpdate();
    }
    public void StartTurn()
    {
        playerEnergy = 3;
        cardFunction.isCast();
        cardFunction.DrawCardstoHandsize();
    }

    public void PlayerTakeDamage(int damage)
    {
        int rolloverDamage;
        if (playerBlock == 0)
        {
            if (damage > 0)
            {
                rolloverDamage = damage - playerBlock;
                playerBlock -= damage;
                currentHealth -= rolloverDamage;
                playerBlock = 0;
                BlockTextUpdate();
            }

            currentHealth -= damage;
            bar.UpdateHP();
        }
    }
}
