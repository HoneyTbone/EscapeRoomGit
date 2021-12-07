using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject chest;

    public int checkingForKey = 1;
    SocketChecker socketChecker;

    void Awake()
    {
        socketChecker = GameObject.FindGameObjectWithTag("SocketKey").GetComponent<SocketChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        if(checkingForKey == 1)
        {
            if (socketChecker.key == true)
            {
                chest.GetComponent<Animator>().Play("Open");
                checkingForKey = 0;
            }
        }
        
    }
}
