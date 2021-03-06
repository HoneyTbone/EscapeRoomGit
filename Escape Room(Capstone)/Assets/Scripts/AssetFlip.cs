using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetFlip : MonoBehaviour
{
    public GameObject unused;
    public GameObject used;
    public bool smashable = false;
    public bool vaultLock = false;

    // Start is called before the first frame update
    void Start()
    {
        used.gameObject.SetActive(false);
        unused.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (vaultLock == true)
        {
            activateObject();
            vaultLock = false;
        }
    }
    public void activateObject()
    {
        used.gameObject.SetActive(true);
        unused.gameObject.SetActive(false);
    }
    public void dectivateObject()
    {
        used.gameObject.SetActive(false);
        unused.gameObject.SetActive(true);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Bullet")
        {
            if (smashable == true)
            {
                activateObject();
            }
            
        }
        
        
    }

}
