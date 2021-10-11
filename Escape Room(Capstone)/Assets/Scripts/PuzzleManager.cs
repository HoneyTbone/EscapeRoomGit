using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Relays all information about each puzzle
 * back to the RoomManager to determine
 * whether the room is complete or not */

public class PuzzleManager : MonoBehaviour
{
    
    RoomManager roomManager;
    // All puzzles added to a boolean array
    static public bool button, password;
    bool[] puzzles = new bool[2] {button,password};
    

    // Awake is called before the first frame update
    void Awake()
    {
        roomManager = GameObject.FindGameObjectWithTag("RoomManager").GetComponent <RoomManager>();
    }

    // Update is called once per frame 
    void FixedUpdate()
    {
        //Debug.Log(puzzles);
       
    }
}
