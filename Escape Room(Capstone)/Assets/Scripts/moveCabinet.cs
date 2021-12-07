using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCabinet : MonoBehaviour
{
    public float speed = 1.0f;
    public Transform target;

    Button button;
    Chest chest;

    public bool cab = false;
    public bool shelf = false;

    void Awake()
    {
        button = GameObject.FindGameObjectWithTag("PuzzleManager").GetComponent<Button>();
        chest = GameObject.FindGameObjectWithTag("Chest").GetComponent<Chest>();

    }

    void FixedUpdate()
    {
        if(cab == true)
        {
            if (button.checkingForTrophy == 0)
            {
                // Move our position a step closer to the target.
                float step = speed * Time.deltaTime; // calculate distance to move
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                // Check if the position of the cube and sphere are approximately equal.
                if (Vector3.Distance(transform.position, target.position) < 0.001f)
                {
                    //
                }
            }
        }
        if(shelf == true)
        {
            if (chest.checkingForKey == 0)
            {
                // Move our position a step closer to the target.
                float step = speed * Time.deltaTime; // calculate distance to move
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);

                // Check if the position of the cube and sphere are approximately equal.
                if (Vector3.Distance(transform.position, target.position) < 0.001f)
                {
                    //
                }
            }
        }
        
        
    }
}
