using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Checks if a room is complete then moves
 * to the next room in the sequence */

public class RoomManager : MonoBehaviour
{
    public bool levelComplete;
    public GameObject door;
    PuzzleManager puzzleManager;


    // Awake is called before the first frame update
    void Awake()
    {
        door.SetActive(true);
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
        door.SetActive(false);
        Debug.Log("level complete");
    }
}
