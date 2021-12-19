using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptEndTurn : MonoBehaviour
{

    public EnemyHealthAi enemy;
    public PlayerScript player;

    public CardFunction cf;

    

    void Start()
    {
        

    }
    public void EndTurn()
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

        //player.StartTurn();
        cf.EndTurnDiscard();
    }
}
