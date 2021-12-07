using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Checks if a room is complete then moves
 * to the next room in the sequence */

public class RoomManager : MonoBehaviour
{
    public bool levelComplete;
    // Public object of two game objects/ 1 open door / 1 closed
    public GameObject doorClosed;
    public GameObject doorOpen;
    PuzzleManager puzzleManager;


    // Awake is called before the first frame update
    void Awake()
    {
        doorClosed.SetActive(true);
        doorOpen.SetActive(false);
        // references the puzzle manager
        puzzleManager = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<PuzzleManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // after the Puzzle Manager says the puzzle is complete the room manager setups the sequence to finish out the level
        if(levelComplete == true)
        {
            nextLevel();
        }
    }

    void nextLevel()
    {
        levelComplete = false;
        // opens the door
        doorOpen.SetActive(true);
        doorClosed.SetActive(false);
        Debug.Log("level complete");
    }
}
