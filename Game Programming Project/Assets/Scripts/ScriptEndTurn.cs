using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptEndTurn : MonoBehaviour
{

    EnemyHealthAi enemy;
    PlayerScript player;
    

    void Start()
    {
        

    }
    public void onClick()
    {
        if (enemy.enemyAct == 1)
        {
            enemy.EnemyGainBlock();
        }
        else if (enemy.enemyAct == 2)
        {
            enemy.EnemyAttack();
        }
        else if (enemy.enemyAct == 3)
        {
            enemy.EnemyDebuff();
        }

        player.StartTurn();
    }
}
