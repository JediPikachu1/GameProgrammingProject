using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCounter : MonoBehaviour
{
    public CardFunction cf;
    public Transform[] Counters;

    public GameObject Hold;

    void Start()
    {
        Restart();
    }

    void Update()
    {
        
            if (cf.firstIsCast)
            {
                Counters[0].gameObject.SetActive(false);
            }

            if (cf.secondIsCast)
            {
                Counters[1].gameObject.SetActive(false);
            }

            if (cf.thirdIsCast)
            {
                Counters[2].gameObject.SetActive(false);
            }

            if (cf.fourthIsCast)
            {
                Counters[3].gameObject.SetActive(false);
            }

            if (cf.fifthIsCast)
            {
                Counters[4].gameObject.SetActive(false);
            }
    }


    public void Restart()
    {
        Counters = new Transform[5];
        Counters[0] = Hold.transform.GetChild(0);
        Counters[1] = Hold.transform.GetChild(1);
        Counters[2] = Hold.transform.GetChild(2);
        Counters[3] = Hold.transform.GetChild(3);
        Counters[4] = Hold.transform.GetChild(4);

        for (int i = 0; i < 5; i++)
        {
            Counters[i].gameObject.SetActive(true);
        }
    }
}
