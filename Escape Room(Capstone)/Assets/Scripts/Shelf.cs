using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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

    }

    public void isComplete()
    {
        if (socketChecker.done == true)
        {
            puzzleManager.puzzles["shelf"] = true;
            puzzleManager.runTest = true;
        }   
    }


}
