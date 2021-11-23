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
    bool button, code;
    public bool runTest;
    //bool[] puzzles = new bool[];
    //List<bool> puzzles = new List<bool>();
    public Dictionary<string, bool> puzzles = new Dictionary<string, bool>();
    bool rtn;
    

    // Awake is called before the first frame update
    void Awake()
    {
        roomManager = GameObject.FindGameObjectWithTag("RoomManager").GetComponent <RoomManager>();

        puzzles.Add("button",button);
        puzzles.Add("code", code);
        //puzzles.Add("password",password);
        //Debug.Log(puzzles["button"]);    
    }

    // Update is called once per frame 
    void FixedUpdate()
    {
       if(runTest==true)
        {
            Debug.Log("RunTest");
            runTest = false;
            IsPuzzlesComplete(puzzles);
        }
    }

    bool IsPuzzlesComplete(Dictionary<string,bool> theDictionary)
    {
        bool result = true;
        button = true;
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
        
       
    }
}
