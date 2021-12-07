using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Shelf : MonoBehaviour
{
    PuzzleManager puzzleManager;
    SocketChecker socketChecker;

    void Awake()
    {
        puzzleManager = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<PuzzleManager>();
        socketChecker = GameObject.FindGameObjectWithTag("SocketCoffee").GetComponent<SocketChecker>();
    }

    void Update()
    {
        if(socketChecker.done == true)
        {
            isComplete();
        }
    }

    void isComplete()
    {
        puzzleManager.puzzles["shelf"] = true;
        puzzleManager.runTest = true;
    }


}
