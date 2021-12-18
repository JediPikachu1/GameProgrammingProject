using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    public int currentHealth;
    public int maximumHealth = 100;

    public int playerEnergy;

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
    }

    void StartTurn()
    {
        playerEnergy = 3;
    }
}
