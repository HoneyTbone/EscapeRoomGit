using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Checks if a room is complete then moves
 * to the next room in the sequence */

public class RoomManager : MonoBehaviour
{
    public bool levelComplete;
    PuzzleManager puzzleManager;


    // Awake is called before the first frame update
    void Awake()
    {
        puzzleManager = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<PuzzleManager>();
        levelComplete = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(levelComplete == true)
        {
            nextLevel();
        }
    }

    void nextLevel()
    {
        Debug.Log("level complete");
        levelComplete = false;
    }
}
