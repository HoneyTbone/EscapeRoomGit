using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    PuzzleManager puzzleManager;
    SocketChecker socketChecker;
    public int checkingForTrophy = 1;

    // Start is called before the first frame update
    void Awake()
    {
        puzzleManager = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<PuzzleManager>();
        socketChecker = GameObject.FindGameObjectWithTag("SocketChecker").GetComponent<SocketChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (checkingForTrophy == 1)
        {
            {
                if (socketChecker.completed == true)
                {
                    isComplete();
                    checkingForTrophy = 0;
                }
            }
        }

    }


    void isComplete()
    {
        puzzleManager.puzzles["button"] = true;
        puzzleManager.runTest = true;
    }
}
