using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public int currentHealth;
    public int maximumHealth = 100;

    public int playerEnergy;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maximumHealth;
        playerEnergy = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
