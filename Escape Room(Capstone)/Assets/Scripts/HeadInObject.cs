using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadInObject : MonoBehaviour
{
    public GameObject Canvas;


    void Awake()
    {
            Canvas.gameObject.SetActive(false);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
                Canvas.gameObject.SetActive(true);
        }   
    }
    void OnCollisionExit(Collision collision)
     {
         if (collision.collider.tag == "Wall")
         {       
                Canvas.gameObject.SetActive(false);

        }  
     }
}
