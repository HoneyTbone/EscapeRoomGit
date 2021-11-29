using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    PuzzleManager puzzleManager;
    public bool completed;

    // Start is called before the first frame update
    void Awake()
    {
        puzzleManager = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<PuzzleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(completed==true)
        {
            isComplete();
        } 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ButtonObject")
        {
            completed = true;
            Destroy(collision.gameObject);
        }
    }

    void isComplete()
    {
        puzzleManager.puzzles["button"] = true;
        puzzleManager.runTest = true;
        completed = false;
    }
}
