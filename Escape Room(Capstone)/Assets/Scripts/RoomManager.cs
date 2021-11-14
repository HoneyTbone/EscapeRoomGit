using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Checks if a room is complete then moves
 * to the next room in the sequence */

public class RoomManager : MonoBehaviour
{
    public bool levelComplete;
    public GameObject doorClosed;
    public GameObject doorOpen;
    PuzzleManager puzzleManager;


    // Awake is called before the first frame update
    void Awake()
    {
        doorClosed.SetActive(true);
        doorOpen.SetActive(false);
        puzzleManager = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<PuzzleManager>();
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
        levelComplete = false;
        doorOpen.SetActive(true);
        doorClosed.SetActive(false);
        Debug.Log("level complete");
    }
}
