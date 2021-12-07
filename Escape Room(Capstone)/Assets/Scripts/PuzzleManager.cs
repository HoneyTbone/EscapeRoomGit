using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Relays all information about each puzzle
 * back to the RoomManager to determine
 * whether the room is complete or not */

public class PuzzleManager : MonoBehaviour
{
    // var allows reference to the Room Manager
    RoomManager roomManager;


    bool button, code, shelf; // List of Each puzzle
    public bool runTest; 

    public Dictionary<string, bool> puzzles = new Dictionary<string, bool>(); // public Dictionary thats stores the puzzles as a string as well as bool(completed or not)
    bool rtn;
    

    // Awake is called before the first frame update
    void Awake()
    {
        // Referecences the Room Manager
        roomManager = GameObject.FindGameObjectWithTag("RoomManager").GetComponent <RoomManager>();

        // adds the puzzles to the dictionary
        puzzles.Add("button",button);
        puzzles.Add("code", code);
        puzzles.Add("shelf", shelf);

    }

    // Update is called once per frame 
    void FixedUpdate()
    {
        // after each puzzle is completed they reference this and set this to true
       if(runTest==true)
        {
            // Then checks if the Dictionary is True
            Debug.Log("RunTest");
            runTest = false;
            IsPuzzlesComplete(puzzles);
        }
    }

    bool IsPuzzlesComplete(Dictionary<string,bool> theDictionary)
    {
        bool result = true;
        button = true;
        // runs through each puzzle and checks if they are complete
        foreach (KeyValuePair<string,bool> item in puzzles)
        {
            result = result && item.Value;
        }
        if (result == true)
        {
            roomManager.levelComplete = true;
        }        
        rtn = result;
        Debug.Log("result is " + result);
        return result;

        // if the result is true it tells the room manager that the level is complete
        
       
    }
}
